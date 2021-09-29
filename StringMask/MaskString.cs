using System;
using System.Text;
using BenchmarkDotNet.Attributes;


[MemoryDiagnoser]
public class Mask
{
  [Benchmark]
  [Arguments("Password123!", 3)]
  public string withIteration(string password, int unmaskedLength = 3)
  {
    string maskedPassword = password.Substring(0, unmaskedLength);
    int maskLength = password.Length - unmaskedLength;

    for (int i = 0; i < maskLength; i++)
    {
      maskedPassword += "*";
    }

    return maskedPassword;
  }

  [Benchmark]
  [Arguments("Password123!", 3)]
  public string withStringBuilder(string password, int unmaskedLength = 3)
  {
    string maskedPassword = password.Substring(0, unmaskedLength);
    int maskLength = password.Length - unmaskedLength;
    var stringBuilder = new StringBuilder(maskedPassword);

    for (int i = 0; i < maskLength; i++)
    {
      stringBuilder.Append("*");
    }

    return stringBuilder.ToString();
  }

  [Benchmark]
  [Arguments("Password123!", 3)]
  public string withStringConstructor(string password, int unmaskedLength = 3)
  {
    string unmaskedCharacters = password.Substring(0, unmaskedLength);
    int maskLength = password.Length - unmaskedLength;
    // Repeat pattern (first argument) by number supplied as second argument
    string asterisks = new string('*', maskLength);

    return unmaskedCharacters + asterisks;
  }

  [Benchmark]
  [Arguments("Password123!", 3)]
  public string withStringCreate(string password, int unmaskedLength = 3)
  {
    return string.Create(password.Length, password, (span, value) =>
    {
      value.AsSpan().CopyTo(span);
      span[unmaskedLength..].Fill('*');
    });
  }
}
