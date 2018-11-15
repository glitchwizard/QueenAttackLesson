using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace QueenAttackGame.Tests
{
  [TestClass]
  public class QueenAttackTest
  {
    [TestMethod]
        public void checkXCoordinates_test_true()
        {
          int[] queenCoordtest = new int[] {1, 2};
          int[] playerCoordtest = new int[] {1, 4};
          Assert.AreEqual(true, QueenAttack.checkCoordinates(queenCoordtest,playerCoordtest));
        }
    [TestMethod]
        public void checkYCoordinates_test_true()
        {
          int[] queenCoordtest = new int[] {3, 2};
          int[] playerCoordtest = new int[] {4, 2};
          Assert.AreEqual(true, QueenAttack.checkCoordinates(queenCoordtest,playerCoordtest));
        }
  }
}
