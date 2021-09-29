### Project was created with the following commands:
-> .\
create solution\
```dotnet sln -n "StringMask"```

create console project\
```dotnet new console -n ""```

add project to solution\
```dotnet sln StringMask.sln add ./StringMask/StringMask.csproj```

-> ./StringMask\
to add Nuget package\
```dotnet add package BenchmarkDotNet```

### To run the project and see benchmark output use:
-> ./StringMask\
```dotnet run -c Release```

The output should resamble this table:
|                Method |     password | unmaskedLength |      Mean |    Error |   StdDev |  Gen 0 | Allocated |
|---------------------- |------------- |--------------- |----------:|---------:|---------:|-------:|----------:|
|         withIteration | Password123! |              3 | 171.73 ns | 0.350 ns | 0.273 ns | 0.1273 |     400 B |
|     withStringBuilder | Password123! |              3 |  83.69 ns | 0.581 ns | 0.543 ns | 0.0587 |     184 B |
| withStringConstructor | Password123! |              3 |  37.08 ns | 0.250 ns | 0.234 ns | 0.0382 |     120 B |
|      withStringCreate | Password123! |              3 |  29.02 ns | 0.199 ns | 0.176 ns | 0.0433 |     136 B |

### VS Code
Install following plugins for VS Code:
- C# from Microsoft

For auto formating of .cs files add the following to VS Code settings.json:\
```JSON
"[csharp]": {
  "editor.defaultFormatter": "ms-dotnettools.csharp"
}
```
