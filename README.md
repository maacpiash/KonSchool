# Kon School?

[![Build Status](https://travis-ci.org/maacpiash/KonSchool.svg?branch=master)](https://travis-ci.org/maacpiash/KonSchool)
[![Build status](https://ci.appveyor.com/api/projects/status/bsmib72le6n8pc1u?svg=true)](https://ci.appveyor.com/project/maacpiash/konschool)
[![.NET Core 2.2](https://img.shields.io/badge/Core-v2.2-692079.svg?logo=.net)](https://github.com/maacpiash/KonSchool/blob/master/src/KonSchool.csproj#L4)
[![License](https://img.shields.io/github/license/maacpiash/KonSchool.svg)](https://github.com/maacpiash/KonSchool/blob/master/LICENSE)
[![Open issues](https://img.shields.io/github/issues/maacpiash/KonSchool.svg)](https://github.com/maacpiash/KonSchool/issues)
[![PRs welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=round-square)](https://github.com/maacpiash/KonSchool/pulls)
[![Contributors](https://img.shields.io/github/contributors/maacpiash/KonSchool.svg)](https://github.com/maacpiash/KonSchool/graphs/contributors)
[![Recent Activities](https://img.shields.io/github/commit-activity/w/maacpiash/KonSchool.svg)](https://github.com/maacpiash/KonSchool/commits/master)

*Kon School?* (Bengali: *কোন স্কুল?*, meaning *"Which school?"*) is a system that recommends a secondary school based on user's preferences and school data. The user gives student data (age, sex, class (grade), location, guardian's profession) as input. The user also compares every pair of criteria and gives each pair a relative linguistic value. Then the system
- uses these linguitic values to run Fuzzy Analytic Hierarchy Process (Fuzzy AHP) to evaluate weights of each criterion
- takes data from a dataset on secondary schools of Bangladesh and calculates comparative values for each criterion
- gives each school a score, which is a sum of weighted criteria-values.

The dataset used for this system was compiled from several datasets originally collected from [Bangladesh Open Data](http://data.gov.bd/dataset). The SQLite database can be found [here](https://drive.google.com/open?id=1_MZnVRHl0ZLHEMab7lBhpUvuS3yaLoPZ).

### Acknowledgement
I am very grateful to [Dr. Rashedur M. Rahman](http://ece.northsouth.edu/people/rashedur-rahman/) sir, Associate Professor at Department of Electrical and Computer Engineering, North South University; and our honorable instructor of the Fuzzy Logic course (CSE470). He mentored my group on this project and made sure our research work got [published](https://link.springer.com/chapter/10.1007/978-3-319-98678-4_29) in Springer and presented at a prestigeous [conference](https://missi.pwr.edu.pl/2018/).<p>I would also like to thank my groupmates — N.S.M. Rezaur Rahman, for the development of the mathematical model; and [Abdullah-Al Nahian Siraj](https://github.com/Nahian-Siraj), for his cooperation with finding related research paper.</p>
