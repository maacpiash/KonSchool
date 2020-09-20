# Contributing

This project is under [GNU Affero General Public License v3](../LICENSE). Please read the [code of conduct](./CODE_OF_CONDUCT.md) before you proceed.

## Guideline

### Before you start

Please take a look at the roadmap listed down [here](#Roadmap) before working on any issue or feature. The enhancements that I require for this project are listed here, sort of a *wishlist*. Also look at the list of open [issue(s)](https://github.com/maacpiash/KonSchool/issues) that might need fixing. You might find find interest in one or two of them.

To work on a new issue or feature, please [email me](mailto:maacpiash@outlook.com) or [open an issue](https://github.com/maacpiash/KonSchool/issues/new) before forking. It is recommended that you follow one of the templates described [here](https://github.com/maacpiash/KonSchool/tree/master/docs). After discussion, if the issue is deemed necessary to be addressed, we can start working on it.

To work on the issue, fork this repository as a project under your own GitHub username. You may want to create a new branch, properly named after the issue. This would help you if you would like to work on more issues down the road.

### Time to code

Please follow Microsoft's [C# coding conventions](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions). Write as many unit tests for the code you wrote as you can. Use the [scripts](../scripts) to generate test coverage. I have used xUnit for unit tests in this project.

For commit messages, please try to follow [this guideline](https://chris.beams.io/posts/git-commit/) and [this template](https://codeinthehole.com/tips/a-useful-template-for-commit-messages/), so that each commit message clearly describes what was done in the commit. There is no need to follow the rules for [Conventional Commits](https://www.conventionalcommits.org). Commit your changes and push them to the branch you opened. Create a new Pull Request when you're done.


## Roadmap

- [ ] Port to microservices architecture: separate services (Web APIs) for FAHP calculation and information of schools.
- [ ] Integrate GraphQL with the Web API for information of schools.
- [x] Write more unit tests for the classes in `KonSchool.Models` namespace.
- [ ] Upgrade to Blazor (SSR)
- [ ] Component for comparisons of criteria
- [ ] Component for the list of eligible schools
  - [ ] Pagination
  - [ ] Add/remove location-based (division/district) constraints.
- [ ] Add a swagger for the Web API endpoints.
- [x] Fix a CI/CD pipeline so that the app can be deployed on Heroku with every commit push.
- [ ] Upgrade app to the upcoming .NET 5 to leverage the performance boost. (Since .NET 5 RC has come out, I have started working on it.)
  - [ ] Rewrite a large part of the UI should be rewritten.
  - [ ] Some UI tests might need fixes.
- [ ] More "inclusive" e2e tests.
