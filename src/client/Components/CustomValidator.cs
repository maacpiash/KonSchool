// src: https://docs.microsoft.com/en-us/aspnet/core/blazor/forms-validation?view=aspnetcore-5.0#validator-components
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace KonSchool.Client.Components
{
	public class CustomValidator : ComponentBase
	{
		private ValidationMessageStore messageStore;

		[CascadingParameter]
		private EditContext CurrentEditContext { get; set; }

		protected override void OnInitialized()
		{
			if (CurrentEditContext == null)
			{
				throw new InvalidOperationException(
					$"{nameof(CustomValidator)} requires a cascading " +
					$"parameter of type {nameof(EditContext)}. " +
					$"For example, you can use {nameof(CustomValidator)} " +
					$"inside an {nameof(EditForm)}.");
			}

			messageStore = new ValidationMessageStore(CurrentEditContext);

			CurrentEditContext.OnValidationRequested += (s, e) => messageStore.Clear();
			CurrentEditContext.OnFieldChanged += (s, e) => messageStore.Clear(e.FieldIdentifier);
		}

		public void DisplayErrors(Dictionary<string, List<string>> errors)
		{
			foreach (var err in errors)
			{
				messageStore.Add(CurrentEditContext.Field(err.Key), err.Value);
			}

			CurrentEditContext.NotifyValidationStateChanged();
		}

		public void ClearErrors()
		{
			messageStore.Clear();
			CurrentEditContext.NotifyValidationStateChanged();
		}
	}
}
