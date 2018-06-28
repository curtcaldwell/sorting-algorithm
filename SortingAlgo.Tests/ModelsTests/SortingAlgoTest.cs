using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingAlgo;
using System;
using System.Collections.Generic;

namespace SortingAlgo.Tests
{
  [TestClass]
  public class SortingAlgoTest
  {
    [TestMethod]
    public void BubbleSort_Select0Index_Return0thIndex()
    {
      List<int> lol = new List<int> {1, 3, 4, 5, 6};
      SortingAlgoClass newSort = new SortingAlgoClass();
      List<int> result = newSort.BubbleSort(lol);
      Console.WriteLine(result);
      Assert.AreEqual(lol[0], result[0]);
    }
    [TestMethod]
    public void BubbleSort_SelectingAllNumbers_BubbleArrayEqualTestArray()
    {
      List<int> lol = new List<int> {1, 3, 4, 5, 6};
      SortingAlgoClass newSort = new SortingAlgoClass();
      List<int> result = newSort.BubbleSort(lol);
      Console.WriteLine(result);
      for(int i=0; i<4;i++)
      {
        Assert.AreEqual(lol[i],result[i]);
      }
    }
  }
}
