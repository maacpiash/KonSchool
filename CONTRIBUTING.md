# Contributing

See [license](https://github.com/maacpiash/KonSchool/blob/master/LICENSE.md) and [code of conduct](https://github.com/maacpiash/KonSchool/blob/master/CODE_OF_CONDUCT.md) before you proceed.

## Guideline

### Before you start

Please take a look at the roadmap listed down [here](#Roadmap) before working on any issue or feature. The enhancements that I require for this project are listed here, sort of a *wishlist*. Also look at the list of open [issue(s)](https://github.com/maacpiash/KonSchool/issues) that might need fixing. You might find find interest in one or two of them.

To work on a new issue or feature, please [email me](mailto:maacpiash@outlook.com) or [open an issue](https://github.com/maacpiash/KonSchool/issues/new) before forking. After discussion, if the issue is deemed necessary to be addressed, we can start working on it.

To work on the issue, fork this repository as a project under your own GitHub username. You may want to create a new branch, properly named after the issue. This would help you if you would like to work on more issues down the road.

### Time to code

Please follow Microsoft's [C# coding conventions](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions). Write as many unit tests for the code you wrote as you can. I have used XUnit for unit tests in this project.

For commit messages, please follow [this guideline](https://chris.beams.io/posts/git-commit/) and [this template](https://codeinthehole.com/tips/a-useful-template-for-commit-messages/). Commit your changes and push them to the branch you opened. Create a new Pull Request when you're done.


## Roadmap

- [ ] Write more unit tests for the classes in `KonSchool.Models` namespace.
- [ ] Add pagination to the page that show the list of eligible schools.
- [ ] *Optional:* Add UI elements that can add/remove location-based (division/district) constraints on list of schools page.
- [ ] *Optional:* Fix a CI/CD pipeline so that the app can be deployed on Heroku with every commit push.
- [ ] *Optional:* Upgrade app to the upcoming .NET Core 3.0 to leverage the performance boost and the Blazor library.
  - [ ] A large part of the UI would require to be rewritten.

