# Kon School?

[![Build status](https://ci.appveyor.com/api/projects/status/bsmib72le6n8pc1u?svg=true)](https://ci.appveyor.com/project/maacpiash/konschool)
[![Docker pulls](https://img.shields.io/docker/pulls/maacpiash/konschool.svg)](https://hub.docker.com/r/maacpiash/konschool)
[![.NET Core 2.2](https://img.shields.io/badge/Core-v2.2-692079.svg?logo=.net)](https://github.com/maacpiash/KonSchool/blob/master/src/KonSchool.csproj#L4)
[![Docs](https://inch-ci.org/github/maacpiash/konschool.svg?branch=master)](https://github.com/maacpiash/KonSchool/blob/master/docs)
[![License](https://img.shields.io/github/license/maacpiash/KonSchool.svg)](https://github.com/maacpiash/KonSchool/blob/master/LICENSE)
[![Open issues](https://img.shields.io/github/issues/maacpiash/KonSchool.svg)](https://github.com/maacpiash/KonSchool/issues)
[![PRs welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=round-square)](https://github.com/maacpiash/KonSchool/pulls)
[![Contributors](https://img.shields.io/github/contributors/maacpiash/KonSchool.svg)](https://github.com/maacpiash/KonSchool/graphs/contributors)

## Introduction

*Kon School?* (Bengali: *কোন স্কুল?*, meaning *"Which school?"*) is a system that recommends a secondary school based on user's preferences and school data.

## Criteria, inputs and outputs

**Criteria of Schools:**

- Teacher-student ratio
- Male-female ratio (among students)
- Socio-economic status (of guardians of students)
- Distance of school from home
- Age of school (based on year of establishment)
- Difference between the age of the child and the average age of the students in the intended class (grade)

**Inputs:**

- Crisp inputs: student data (age, sex, class (grade), location, guardian's profession)
- Fuzzy inputs: pairwise comparison between criteria of schools: 5 comparisons for 6 criteria

**Outputs:**

- Weights of 6 criteria
- Compatibility scores for all eligible schools

## How this works

After getting the inputs, the system

- uses these linguitic values to run Fuzzy Analytic Hierarchy Process (Fuzzy AHP) to evaluate weights of each criterion
- takes data from a dataset on secondary schools of Bangladesh and calculates comparative values for each criterion
- gives each school a score, which is a sum of weighted criteria-values.

For more details on calculation of weights from fuzzy inputs, please check the [`docs`](https://github.com/maacpiash/KonSchool/tree/master/src).

## Data on schools

The dataset on schools that is used for this system was compiled from several datasets that were originally collected from [Bangladesh Open Data](http://data.gov.bd/dataset). It contains the data on 14,274 schools across thecountry. The SQLite database can be found [here](https://drive.google.com/open?id=1_MZnVRHl0ZLHEMab7lBhpUvuS3yaLoPZ). You can also use API endpoints to access the data (view below for instructions).

## How to run the web app

There are two ways.

### Compilation of source

If you have .NET Core SDK (2.x) installed, you can run the application directly from the source:

```bash
git clone https://github.com/maacpiash/KonSchool
dotnet run KonSchool/src/KonSchool.csproj
```

Now, navigate to either http://localhost:5000 or https://localhost:5001.

I recommend this method over the next one. You can download .NET Core SDK installer or binary from [Microsoft](https://dot.net/get-core).

### Docker image

You may run from the docker image:

```bash
docker container run -it -p 80:80 maacpiash/konschool
```

The app can now be accessed from http://localhost:70.
You can get instructions on installing Docker from their [documentation](https://docs.docker.com/install/).

## REST API

In addition to the server-side-rendered pages, there are two RESTful API endpoints:

### Fuzzy AHP endpoint, `/api/fahp`

This endpoint can be used to get results of 6 criteria by providing 5 integers (between -9 and 9, inclusive).

**Example:**

- `/api/fahp/0,0,0,0,0` would return equal weights for 6 criteria (`0.166...`).
- `/api/fahp/1,2,3,4,5` would return 6 weights that are exponentially increasing.
- `/api/fahp/-5,-4,-3,-2,-1` would return 6 weights that are exponentially decreasing.

For detailed information regarding the integer values, please check the [`docs`](https://github.com/maacpiash/KonSchool/tree/master/src).

### School data endpoint, `api/schools`

This endpoint can be used to access data of schools. Schools can be queried about by EIIN, divisions or districts.

**Example:**

- `/api/schools` would return the data of all the schools.
- `/api/schools/div/RAJSHAHI` would return the data of all the schools inside the division of Rajshahi.
- `/api/schools/dis/BOGRA` would return the data of all the schools inside the district of Bogra.
- `/api/schools/100005` would return the data of the school with EIIN 1005.

## Acknowledgement

I am very grateful to Dr. Rashedur M. Rahman ([NSU ECE](http://ece.northsouth.edu/people/rashedur-rahman/), [Google Scholar](https://scholar.google.ca/citations?user=L9S6rlUAAAAJ)), Professor at Department of Electrical and Computer Engineering, North South University; and our honorable instructor of the Fuzzy Logic course (CSE470). He mentored my group on this project and made sure our research work got [published](https://link.springer.com/chapter/10.1007/978-3-319-98678-4_29) in Springer and presented at a prestigeous [conference](https://missi.pwr.edu.pl/2018/).<p>I would also like to thank my groupmates — N.S.M. Rezaur Rahman, for the development of the mathematical model; and [Abdullah-Al Nahian Siraj](https://github.com/Nahian-Siraj), for his cooperation with finding related research paper.</p>

## Contributing

This project is under [GNU General Public License 3.0](https://github.com/maacpiash/KonSchool/blob/master/LICENSE). Please read the [contribution guideline](https://github.com/maacpiash/KonSchool/blob/master/CONTRIBUTING.md) in advance.
