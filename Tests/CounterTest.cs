using System;
using System.Collections.Generic;
using Xunit;

namespace CountWord
{
  public class RepeateCounterTest
  {
    [Fact]
    public void Test_CounterString()
    {
      int expectedResult = 1;
      RepeatCounter testRepeateCounter = new RepeatCounter("dog", "dog");

      int result = testRepeateCounter.CountRepeats();

      Assert.Equal(expectedResult, result);
    }
    [Fact]
    public void Test_CounterString_DogTo_dog()
    {
      int expectedResult = 1;
      RepeatCounter testRepeateCounter = new RepeatCounter("Dog", "dog");

      int result = testRepeateCounter.CountRepeats();

      Assert.Equal(expectedResult, result);
    }
    [Fact]
    public void Test_CounterString_PunctuationCharArr()
    {
      int expectedResult = 1;
      RepeatCounter testRepeateCounter = new RepeatCounter(" dog ", "dog");

      int result = testRepeateCounter.CountRepeats();

      Assert.Equal(expectedResult, result);
    }
    [Fact]
    public void Test_CounterString_0()
    {
      int expectedResult = 0;
      RepeatCounter testRepeateCounter = new RepeatCounter("cat", "my dog is the best dog");

      int result = testRepeateCounter.CountRepeats();

      Assert.Equal(expectedResult, result);
    }
    [Fact]
    public void Test_CounterStringSentence_1()
    {
      int expectedResult = 1;
      RepeatCounter testRepeateCounter = new RepeatCounter("dog", "dog play fetch");

      int result = testRepeateCounter.CountRepeats();

      Assert.Equal(expectedResult, result);
    }
    [Fact]
    public void Test_CounterString_2()
    {
      int expectedResult = 2;
      RepeatCounter testRepeateCounter = new RepeatCounter("dog", "my dog is an awesome dog");

      int result = testRepeateCounter.CountRepeats();

      Assert.Equal(expectedResult, result);
    }
  }
}
