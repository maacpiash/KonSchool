# Data on administrative regions and occupation options

## Administrative regions

The CSV, XLS, and XLSX files in the [original](./original) directory are the original datasets collected from [data.gov.bd](http://data.gov.bd/group/education). The current version of these files are downloaded on 14 December 2021.

There are four data files in this directory, which contain data on the administrative regions of Bangladesh and the occupation options — each in two formats (JSON and YAML).

The data is formatted as one whole nested object, based on the following regional hierarchy:

- Divisions
    - `division1: { district1: {...}, district2: {...}, ... }`
- Districts
    - `district1: { thana1: {...}, upazilla1: {...}, ... }`
- *Thana* (city/town) or *Upazilla* (rural)
    - `thana1: { ward1: {...}, ward2: {...}, ... }`
    - `upazilla1: { union1: {...}, union2: {...}, ... }`
- Ward (city/town) or Union (rural)
    - `ward1: [suburb1, suburb2, ...]`
    - `union1: [village1, village2, ...]`
- Suburb (city/town) or Village (rural)

## Occupation options

The data is an object with the property `Occupations`, which is an array of all the available options for the guardian's occupation field.
