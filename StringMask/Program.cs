using System;
using BenchmarkDotNet.Running;
using static Mask;

namespace StringMask
{
  class Program
  {
    static void Main(string[] args)
    {
      BenchmarkRunner.Run<Mask>();
    }
  }
}
