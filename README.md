# Kon School?
*কোন স্কুল?* is an app that recommends a secondary school based on user's preferences and school data. The user gives student data (age, sex, class (grade), location, guardian's profession) as input. The user also compares every pair of criteria and gives each pair a relative linguistic value. Then the system
- uses these linguitic values to run Fuzzy Analytic Hierarchy Process (Fuzzy AHP) to evaluate weights of each criterion
- takes data from a dataset on secondary schools of Bangladesh and calculates comparative values for each criterion
- gives each school a score, which is a sum of weighted criteria-values.
<br/>


The dataset used for this system was compiled from several datasets originally collected from [Bangladesh Open Data](http://data.gov.bd/dataset).

### Acknowledgement
I am very grateful to [Dr. Mohammad Rashedur Rahman](http://ece.northsouth.edu/people/rashedur-rahman/) sir, our honorable instructor of the Fuzzy Logic course (CSE470) at North South University, who mentored my group on this project and made sure our research work got published in [The 11th edition of International Conference 
on Multimedia & Network Information Systems](https://missi.pwr.edu.pl/2018/).<p>I would also like to thank my groupmates — N.S.M. Rezaur Rahman, for the development of the mathematical model; and [Abdullah-Al Nahian Siraj](https://github.com/Nahian-Siraj), for his cooperation.</p>