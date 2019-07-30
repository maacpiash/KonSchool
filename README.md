# Kon School?

[![Live on Azure](https://img.shields.io/badge/Azure-Live-0089D6.svg?style=flat-square&logo=microsoft-azure)](https://KonSchool.azurewebsites.net)
[![Docker pulls](https://img.shields.io/docker/pulls/maacpiash/konschool.svg?logo=docker&style=flat-square)](https://hub.docker.com/r/maacpiash/konschool)
[![.NET Core 2.2](https://img.shields.io/badge/Core-v2.2-692079.svg?logo=.net&style=flat-square)](https://github.com/maacpiash/KonSchool/blob/master/src/KonSchool.csproj#L4)
[![GitHub last commit](https://img.shields.io/github/last-commit/maacpiash/KonSchool.svg?logo=git&style=flat-square)](https://github.com/maacpiash/KonSchool/commits)
[![PRs welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg?logo=github&style=flat-square)](https://github.com/maacpiash/KonSchool/pulls)

**Build Status:**

| Platform | Status |
| --- | --- |
| Widows (VS2017) | [![Build Status](https://dev.azure.com/ahadc/KonSchool/_apis/build/status/KonSchool?branchName=master&jobName=Job&configuration=Job%20windows)](https://dev.azure.com/ahadc/KonSchool/_build/latest?definitionId=3&branchName=master) |
| macOS (10.13) | [![Build Status](https://dev.azure.com/ahadc/KonSchool/_apis/build/status/KonSchool?branchName=master&jobName=Job&configuration=Job%20mac)](https://dev.azure.com/ahadc/KonSchool/_build/latest?definitionId=3&branchName=master) |
| Linux (Ubuntu 16.04) | [![Build Status](https://dev.azure.com/ahadc/KonSchool/_apis/build/status/KonSchool?branchName=master&jobName=Job&configuration=Job%20linux)](https://dev.azure.com/ahadc/KonSchool/_build/latest?definitionId=3&branchName=master) |

**Tests and code Coverage:**

[![AppVeyor tests](https://img.shields.io/appveyor/tests/maacpiash/KonSchool.svg?compact_message&logo=appveyor&style=flat-square)](https://ci.appveyor.com/project/maacpiash/konschool)
[![Codecov](https://img.shields.io/codecov/c/gh/maacpiash/KonSchool.svg?logo=codecov&style=flat-square)](https://codecov.io/gh/maacpiash/KonSchool)

*Kon School?* (Bengali: *কোন স্কুল?*, meaning *"Which school?"*) is a system that recommends a secondary school based on user's preferences and school data.

- [Process](#Process)
  - [Criteria of schools](#Criteria-of-schools)
  - [Inputs](#Inputs)
  - [Calculation](#Calculation)
  - [Outputs](#Outputs)
- [Data on Schools](#Data-on-schools)
- [Running the web app](#Running-the-web-app)
  - [Compilation of source](#Compilation-of-source)
  - [Docker image](#Docker-image)
- [REST API](#REST-API)
- [Acknowledgement](#Acknowledgement)
- [Contributing](#Contributing)

## Process

### Criteria of Schools

- Teacher-student ratio
- Male-female ratio (among students)
- Socio-economic status (of guardians of students)
- Distance of school from home
- Age of school (based on year of establishment)
- Difference between the age of the child and the average age of the students in the intended class (grade)

### Inputs

- Crisp inputs: student data (age, sex, class (grade), location, guardian's profession)
- Fuzzy inputs: pairwise comparison between criteria of schools: 5 comparisons for 6 criteria

### Calculation

After getting the inputs, the system

- uses these linguitic values to run Fuzzy Analytic Hierarchy Process (Fuzzy AHP) to evaluate weights of each criterion
- takes data from a dataset on secondary schools of Bangladesh and calculates comparative values for each criterion
- gives each school a score, which is a sum of weighted criteria-values.

For more details on calculation of weights from fuzzy inputs, please check the [`docs`](https://github.com/maacpiash/KonSchool/tree/master/docs).

### Outputs

- Weights of 6 criteria
- Compatibility scores for all eligible schools


## Data on schools

The dataset on schools that is used for this system was compiled from several datasets that were originally collected from [Bangladesh Open Data](http://data.gov.bd/dataset). It contains the data on 14,274 schools across thecountry. The SQLite database can be found [here](https://drive.google.com/open?id=1_MZnVRHl0ZLHEMab7lBhpUvuS3yaLoPZ). You can also use API endpoints to access the data (view the [REST API section](#REST-API) below for further instructions).

The collection of data and its preprocessing is discussed in the [`docs`](https://github.com/maacpiash/KonSchool/tree/master/docs).

## Running the web app

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

The app can now be accessed from http://localhost:80.
You can get instructions on installing Docker from their [documentation](https://docs.docker.com/install/).

## REST API

In addition to the server-side-rendered pages, there are two RESTful API endpoints:

### Fuzzy AHP endpoint, `/api/fahp`

This endpoint can be used to get results of 6 criteria by providing 5 integers (between -9 and 9, inclusive).

**Examples:**

- [`/api/fahp/0,0,0,0,0`](https://konschool.azurewebsites.net/api/fahp/0,0,0,0,0) would return equal weights for 6 criteria (`0.166...`).
- [`/api/fahp/1,2,3,4,5`](https://konschool.azurewebsites.net/api/fahp/1,2,3,4,5) would return 6 weights that are exponentially increasing.
- [`/api/fahp/-5,-4,-3,-2,-1`](https://konschool.azurewebsites.net/api/fahp/-5,-4,-3,-2,-1) would return 6 weights that are exponentially decreasing.

For detailed information regarding the integer values, please check the [`docs`](https://github.com/maacpiash/KonSchool/tree/master/src).

### School data endpoint, `/api/schools`

This endpoint can be used to access data of schools. Schools can be queried about by EIIN, divisions or districts.

**Examples:**

- [`/api/schools`](https://konschool.azurewebsites.net/api/schools) would return the data of all the schools.
- [`/api/schools/div/RAJSHAHI`](https://konschool.azurewebsites.net/api/schools/div/RAJSHAHI) would return the data of all the schools inside the division of Rajshahi.
- [`/api/schools/dis/BOGRA`](https://konschool.azurewebsites.net/api/schools/dis/BOGRA) would return the data of all the schools inside the district of Bogra.
- [`/api/schools/100005`](https://konschool.azurewebsites.net/api/schools/100005) would return the data of the school with EIIN 100005.

All these endpoints return response in standard JSON format.

## Acknowledgement

I am very grateful to Dr. Rashedur M. Rahman ([NSU ECE](http://ece.northsouth.edu/people/rashedur-rahman/), [Google Scholar](https://scholar.google.ca/citations?user=L9S6rlUAAAAJ)), Professor at Department of Electrical and Computer Engineering, North South University; and our honorable instructor of the Fuzzy Logic course (CSE470). He mentored my group on this project and made sure our research work got [published](https://link.springer.com/chapter/10.1007/978-3-319-98678-4_29) in Springer and presented at a prestigeous [conference](https://missi.pwr.edu.pl/2018/).<p>I would also like to thank my groupmates — N.S.M. Rezaur Rahman, for the development of the mathematical model; and [Abdullah-Al Nahian Siraj](https://github.com/Nahian-Siraj), for his cooperation with finding related research paper.</p>

## Contributing

This project is under [Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International Public License](https://github.com/maacpiash/KonSchool/blob/master/LICENSE.md). Please read the [contribution guideline](https://github.com/maacpiash/KonSchool/blob/master/CONTRIBUTING.md) in advance.
