using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrayCalc.Controllers;
using ArrayCalc.Services;

namespace ArrayCalcTest
{
    [TestClass]
    public class ArrayCalcControllerTest
    {
        ArrayCalcController arrayCalcController = new ArrayCalcController();
        ArrayOperator arrayOperator = new ArrayOperator();

        [TestMethod]
        public void Reverse_Success()
        {
            int[] testProductIds = new int[] { 1, 2, 3, 4, 5 };
            arrayCalcController.Reverse(testProductIds);
            CollectionAssert.AreEqual(testProductIds, new int[] { 5, 4, 3, 2, 1 });
        }

        [TestMethod]
        public void Reverse_Fail()
        {
            int[] testProductIds = new int[] { 0, 2, 3, 4, 5 };
            arrayCalcController.Reverse(testProductIds);
            CollectionAssert.AreNotEqual(testProductIds, new int[] { 5, 4, 3, 2 });
        }

        [TestMethod]
        public void DeletePart_Success()
        {
            int[] testProductIds = new int[] { 1, 2, 3, 4, 5 };
            int position = 5;
           Assert.AreEqual(( arrayOperator.RemoveElementAt(position, testProductIds)).ToString(), (new int[] { 1, 2, 3, 4}).ToString());
        }


        [TestMethod]
        public void DeletePart_Fail()
        {
            int[] testProductIds = new int[] { 1, 2, 3, 4, 5 };
            int position = 6;
            Assert.AreNotEqual((arrayOperator.RemoveElementAt(position, testProductIds)), (new int[] { 1, 2, 3, 4 }));
        }

    }
}
