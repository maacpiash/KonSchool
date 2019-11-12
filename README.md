<h1 align="center">Kon School?</h1>
<h3 align="center">Fuzzy-AHP-based recommendation system for secondary schools in Bangladesh 🏫 🇧🇩</h3>

<p align="center">
  <a href="https://KonSchool.azurewebsites.net">
    <img src="https://img.shields.io/website?label=www&logo=microsoft-azure&style=flat-square&up_color=deepgreen&url=https%3A%2F%2FKonSchool.azurewebsites.net" alt="Live on Azure">
  </a>
  <a href="https://KonSchool.herokuapp.com">
    <img src="https://img.shields.io/website?label=www&logo=heroku&style=flat-square&up_color=deepgreen&url=https%3A%2F%2FKonSchool.herokuapp.com" alt="Live on Heroku">
  </a>
  <a href="https://hub.docker.com/r/maacpiash/konschool">
    <img src="https://img.shields.io/docker/pulls/maacpiash/konschool.svg?label=pulls&logo=docker&style=flat-square" alt="Docker pulls">
  </a>
  <a href="https://dotnet.microsoft.com/download/dotnet-core/2.1">
    <img src="https://img.shields.io/badge/Core-v2.1-692079.svg?logo=.net&style=flat-square" alt=".NET Core 2.1">
  </a>
  <a href="https://github.com/maacpiash/KonSchool/blob/master/src/KonSchool.csproj">
    <img src="https://img.shields.io/librariesio/github/maacpiash/konschool?label=deps&logo=nuget&style=flat-square" alt="Libraries.io dependency status for GitHub repo">
  </a>
  <a href="https://www.codefactor.io/repository/github/maacpiash/konschool">
    <img src="https://img.shields.io/codefactor/grade/github/maacpiash/KonSchool?label=quality&logo=codefactor&style=flat-square" alt="CodeFactor Grade">
  </a>
  <a href="https://codeclimate.com/github/maacpiash/KonSchool">
    <img src="https://img.shields.io/codeclimate/maintainability-percentage/maacpiash/KonSchool?logo=code-climate&style=flat-square" alt="Code Climate maintainability">
  </a>
  <br>
  <a href="https://ci.appveyor.com/project/maacpiash/konschool">
    <img src="https://img.shields.io/appveyor/ci/maacpiash/KonSchool?label=Windows&logo=appveyor&style=flat-square" alt="AppVeyor">
  </a>
  <a href="https://travis-ci.org/maacpiash/KonSchool">
    <img src="https://img.shields.io/travis/maacpiash/KonSchool?label=macOS%2FUbuntu&logo=travis&style=flat-square" alt="Travis (.org)">
  </a>
  <a href="https://hub.docker.com/r/maacpiash/konschool">
    <img src="https://img.shields.io/docker/cloud/build/maacpiash/konschool?logo=docker&style=flat-square" alt="Travis (.org)">
  </a>
  <a href="https://ci.appveyor.com/project/maacpiash/konschool">
    <img src="https://img.shields.io/appveyor/tests/maacpiash/KonSchool.svg?logo=appveyor&style=flat-square" alt="AppVeyor tests">
  </a>
  <a href="https://codecov.io/gh/maacpiash/KonSchool">
    <img src="https://img.shields.io/codecov/c/gh/maacpiash/KonSchool.svg?logo=codecov&style=flat-square"
    alt="Codecov">
  </a>
</p>

*Kon School?* (Bengali: *কোন স্কুল?*, meaning *"Which school?"*) is a recommendation system that gives secondary schools personalized compatibility scores based on user's preferences.

<div id="toc">

- [Process](#Process)
  - [Criteria of schools](#Criteria-of-schools)
  - [Inputs](#Inputs)
  - [Calculation](#Calculation)
  - [Outputs](#Outputs)
- [Data on Schools](#Data-on-schools)
- [Running the web app locally](#Running-the-web-app-locally)
  - [Compilation of source](#Compilation-of-source)
  - [Docker image](#Docker-image)
- [REST API](#REST-API)
  - [Fuzzy AHP endpoint, `/api/fahp`](#Fuzzy-AHP-endpoint-apifahp)
  - [School data endpoint, `/api/schools`](#School-data-endpoint-apischools)
- [Acknowledgement](#Acknowledgement)
- [Contributing](#Contributing)

</div>

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

**[⬆ back to toc](#toc)**

## Data on schools

The dataset on schools that is used for this system was compiled from several datasets that were originally collected from [Bangladesh Open Data](http://data.gov.bd/dataset). It contains the data on 14,274 schools across the country. The SQLite database can be found [here](https://drive.google.com/open?id=1_MZnVRHl0ZLHEMab7lBhpUvuS3yaLoPZ). You can also use API endpoints to access the data (view the [REST API section](#REST-API) below for further instructions).

The collection of data and its preprocessing is discussed in the [`docs`](https://github.com/maacpiash/KonSchool/tree/master/docs).

**[⬆ back to toc](#toc)**

## Running the web app locally

There are two ways.

### Compilation of source

If you have .NET Core SDK (v2.1) installed, you can run the application directly from the source:

```bash
git clone https://github.com/maacpiash/KonSchool
dotnet run --project KonSchool/src/KonSchool.csproj
```

Now, navigate to either http://localhost:5000 or https://localhost:5001.

I recommend this method over the next one. You can download .NET Core SDK from [Microsoft](https://dotnet.microsoft.com/download/dotnet-core/2.1).

### Docker image

If you do not have Docker installed, please follow the official [documentation](https://docs.docker.com/install/).

For the first time, you may run the following command, which would download the docker image from Docker Hub, create a container from the image and start the container:

```bash
docker run -it -p 5000:80 --name konschool maacpiash/konschool
```

Now the application can be accessed via http://localhost:5000. Omit the `-it` part from the command if you want to keep it running in the background.

From then on, every time you need to use the app, run the following command to start the container that was built the first time:

```bash
docker container start -i konschool
```

The app can now be accessed from http://localhost:5000. Omit the `-i` part from the command if you want to keep it running in the background.

To stop the container running in the foreground, press `Ctrl` + `C`. If you started the container in the background (as a Windows service or a daemon on Unix/Linux), run the following command to stop the container:

```bash
docker container stop konschool
```

**[⬆ back to toc](#toc)**

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

**[⬆ back to toc](#toc)**

## Acknowledgement

I am very grateful to Dr. Rashedur M. Rahman ([NSU ECE](http://ece.northsouth.edu/people/rashedur-rahman/), [Google Scholar](https://scholar.google.ca/citations?user=L9S6rlUAAAAJ)), Professor at Department of Electrical and Computer Engineering, North South University; and our honorable instructor of the Fuzzy Logic course (CSE470). He mentored my group on this project and made sure our research work got [published](https://link.springer.com/chapter/10.1007/978-3-319-98678-4_29) in Springer and presented at a prestigeous [conference](https://missi.pwr.edu.pl/2018/).

I would also like to thank my groupmates — N.S.M. Rezaur Rahman, for the development of the mathematical model; and [Abdullah-Al Nahian Siraj](https://github.com/Nahian-Siraj), for his cooperation with finding related research paper.

**[⬆ back to toc](#toc)**

## Contributing

This project is under [GNU Affero General Public License v3](https://github.com/maacpiash/KonSchool/blob/master/LICENSE.md). Please read the [contribution guideline](https://github.com/maacpiash/KonSchool/blob/master/CONTRIBUTING.md) in advance.

[![Say Thanks!](https://img.shields.io/badge/Say%20Thanks-!-1EAEDB.svg?style=flat-square)](https://saythanks.io/to/maacpiash)
[![Twitter URL](https://img.shields.io/twitter/url/https/github.com/maacpiash/KonSchool?style=social)](https://twitter.com/intent/tweet?url=https%3A//konschool.azurewebsites.net)

**[⬆ back to toc](#toc)**
