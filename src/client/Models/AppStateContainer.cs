using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using KonSchool.Shared;
using static System.Math;

namespace KonSchool.Client.Models
{
	public class AppStateContainer
	{
		#region User inputs
		public Student Student { get; set; }
		public bool LimitByDivision { get; set; }
		public bool LimitByDistrict { get; set; }
		#endregion

		public int[] FuzzyInputs { get; set; }
		public double[] Weights { get; set; }

		public List<School> Alternatives;

		public AppStateContainer()
		{
			Student = new Student();
			FuzzyInputs = new int[5];
		}

		public void SetValues()
		{
			List<School> eligibleSchools = new List<School>();
			foreach (School s in Alternatives)
				if (IsEligible(s)) eligibleSchools.Add(s);

			foreach (School s in eligibleSchools)
			{
				// MFR
				if (Student.IsFemale) s.MFR = 1 - s.MFR;

				// LOC
				if (Student.Address.Division != default(string))
					s.LOC = Student.Address.Division == s.Division
						? (Student.Address.District == s.District
							? (Student.Address.Thana == s.Thana
								? (Student.Address.Union_Ward == s.Union_Ward
									? 1.0 // same union/ward
									: 0.9) // same thana, different unions/wards
								: 0.7) // same district, different thanas
							: 0.4) // same division, different districts
						: 0.0; // different divisions
				else
					Console.Error.WriteLine("LOC not set!");

				// SES
				if (Student.Social > 1.0)
				{
					double sescore = (int)(Student.Social / 2.5) switch
					{
						1 => s.SEScore1,
						2 => s.SEScore2,
						3 => s.SEScore3,
						4 => s.SEScore4,
						_ => 0,
					};
					s.SES = (sescore * 2 + s.SES) / 3;
				}
			}

			// AGE
			GetAGE(eligibleSchools);

			Alternatives = eligibleSchools;
		}

		public void GetAGE(List<School> EligibleSchools)
		{
			int max = EligibleSchools.Count;

			double[] ageDiffs = new double[max];
			for (int i = 0; i < max; i++)
			{
				try
				{
					double averAge = Student.Class switch
					{
						6 => EligibleSchools[i].AverAge6,
						7 => EligibleSchools[i].AverAge7,
						8 => EligibleSchools[i].AverAge8,
						9 => EligibleSchools[i].AverAge9,
						10 => EligibleSchools[i].AverAgeX,
						_ => 0.0,
					};
					ageDiffs[i] = Abs(averAge - (double)Student.Age);
				}
				catch (Exception x)
				{
					Console.Error.WriteLine(x.GetType().ToString());
					Console.Error.WriteLine($"i = {i}, max = {max}");
				}
			}

			double mean = ageDiffs.Average();
			double sd = Stat.StdDev(ageDiffs);

			for (int i = 0; i < max; i++)
				EligibleSchools[i].ADS = 1 - Stat.NORMDIST(ageDiffs[i], mean, sd, true);
		}

		public bool IsEligible(School s)
		{
			if (Student.IsFemale && s.Type == "BOYS")
				return false;
			if (!Student.IsFemale && s.Type == "GIRLS")
				return false;
			if (Student.Class > 8 && s.Level == "Junior Secondary")
				return false;
			return true;
		}
	}
}
