``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 7 SP1 (6.1.7601.0)
Intel Core i7-4710HQ CPU 2.50GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
Frequency=2435820 Hz, Resolution=410.5394 ns, Timer=TSC
.NET SDK=5.0.401
  [Host]     : .NET 5.0.10 (5.0.1021.41214), X64 RyuJIT
  DefaultJob : .NET 5.0.10 (5.0.1021.41214), X64 RyuJIT


```
|                Method |     password | unmaskedLength |      Mean |    Error |   StdDev |  Gen 0 | Allocated |
|---------------------- |------------- |--------------- |----------:|---------:|---------:|-------:|----------:|
|         withIteration | Password123! |              3 | 171.73 ns | 0.350 ns | 0.273 ns | 0.1273 |     400 B |
|     withStringBuilder | Password123! |              3 |  83.69 ns | 0.581 ns | 0.543 ns | 0.0587 |     184 B |
| withStringConstructor | Password123! |              3 |  37.08 ns | 0.250 ns | 0.234 ns | 0.0382 |     120 B |
|      withStringCreate | Password123! |              3 |  29.02 ns | 0.199 ns | 0.176 ns | 0.0433 |     136 B |
