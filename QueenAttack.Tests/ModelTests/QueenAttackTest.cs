using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace QueenAttack.Tests
{
  [TestClass]
  public class QueenAttackTest
  {
    [TestMethod]
        public void checkCoordinates_test_true()
        {
          QueenAttack testQueenAttack = new QueenAttack();
          Assert.AreEqual(true, testQueenAttack.checkCoordinates());
        }
  }
}
