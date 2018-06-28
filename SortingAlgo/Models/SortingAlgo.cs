using System;
using System.Collections.Generic;
using System.Linq;
namespace SortingAlgo
{
public class SortingAlgoClass
  {
    public List<int> bubbleList = new List<int> { 24, 69, 420, 10, 10000, 101, 36, 8008 };
    public List<int> testList = new List<int> {};
    public List<int> BubbleSort(List<int> parseMe)
    {
      foreach(int i in parseMe)
      {
        Console.WriteLine(i);
        testList.Add(i);
        Console.WriteLine(testList);
      }
      Console.WriteLine("This is the final list " + testList);
      return testList;

    }
  }
}
