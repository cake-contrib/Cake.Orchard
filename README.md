# Cake.Orchard

An Addin for Cake that reproduces the [Orchard Project](http://docs.orchardproject.net) custom MSBuild tasks.

## Give a Star! :star:

If you like or are using this project please give it a star. Thanks!

## How to use

```csharp
#addin Cake.Orchard

Task("ValidateProjectFiles")
    .Does(()=>{
        ValidateProjectFiles("<path>");
    })
```

## Issues

Please open an issue in the Github issue tracker. We will try to respond.

## Contributions

Contributions are gladly accepted.  Please submit a pull request on the develop branch.

## Discussion

For questions and to discuss ideas & feature requests, use the [GitHub discussions on the Cake GitHub repository](https://github.com/cake-build/cake/discussions), under the [Extension Q&A](https://github.com/cake-build/cake/discussions/categories/extension-q-a) category.

[![Join in the discussion on the Cake repository](https://img.shields.io/badge/GitHub-Discussions-green?logo=github)](https://github.com/cake-build/cake/discussions)

## Release History

Click on the [Releases](https://github.com/cake-contrib/Cake.Orchard/releases) tab on GitHub.

---

This addin is licensed under the Apache 2.0 license, a copy is included in the repository.
