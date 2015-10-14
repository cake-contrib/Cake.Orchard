# Cake.Orchard

An Addin for Cake that reproduces the [Orchard Project](http://docs.orchardproject.net) custom MSBuild tasks.

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

## License

This addin is licensed under the Apache 2.0 license, a copy is included in the repository.
