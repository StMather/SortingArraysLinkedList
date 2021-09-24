using LinkedListsTraining.AddTwoNumbers;
using LinkedListTraining_tests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedListTraining_tests
{
    [TestClass]
    public class AddTwoNumbers_tests
    {
        [TestMethod]
        public void AddTwoNumbers_SingleDigits_ReturnsAddedNumbers()
        {
            //Arrange
            var input_l1 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 1 });
            var input_l2 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 2 });
            var expected = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 3 });
            var sut = new Solution();
            //Act
            var actual = sut.AddTwoNumbers(input_l1, input_l2);
            //Assert
            AssertLinkedLists.NodesHaveEqualValue(expected, actual);
        }

        [TestMethod]
        public void AddTwoNumbers_MultipleDigits_ReturnsAddedNumbers()
        {
            var input_l1 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 1, 1, 1 });
            var input_l2 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 2, 2, 2 });
            var expected = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 3, 3, 3 });
            var sut = new Solution();

            var actual = sut.AddTwoNumbers(input_l1, input_l2);

            AssertLinkedLists.NodesHaveEqualValue(expected, actual);
        }
        [TestMethod]
        public void AddTwoNumbers_L1Longer_ReturnsAddedNumbers()
        {
            var input_l1 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 1, 1, 1 });
            var input_l2 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 2, 2 });
            var expected = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 3, 3, 1 });
            var sut = new Solution();

            var actual = sut.AddTwoNumbers(input_l1, input_l2);

            AssertLinkedLists.NodesHaveEqualValue(expected, actual);
        }
        [TestMethod]
        public void AddTwoNumbers_L2Longer_ReturnsAddedNumbers()
        {
            var input_l1 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 1, 1 });
            var input_l2 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 2, 2, 2 });
            var expected = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 3, 3, 2 });
            var sut = new Solution();

            var actual = sut.AddTwoNumbers(input_l1, input_l2);

            AssertLinkedLists.NodesHaveEqualValue(expected, actual);
        }
        [TestMethod]
        public void AddTwoNumbers_L2WayLonger_ReturnsAddedNumbers()
        {
            var input_l1 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 1, 1 });
            var input_l2 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 2, 2, 2,2,2,2,2,2,2,2,2,2 });
            var expected = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 3, 3, 2,2,2,2,2,2,2,2,2,2 });
            var sut = new Solution();

            var actual = sut.AddTwoNumbers(input_l1, input_l2);

            AssertLinkedLists.NodesHaveEqualValue(expected, actual);
        }
        [TestMethod]
        public void AddTwoNumbers_AddZero_ReturnsAddedNumbers()
        {
            var input_l1 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 1, 1 ,1 });
            var input_l2 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 2, 2, 0 });
            var expected = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 3, 3, 1 });
            var sut = new Solution();

            var actual = sut.AddTwoNumbers(input_l1, input_l2);

            AssertLinkedLists.NodesHaveEqualValue(expected, actual);
        }
        [TestMethod]
        public void AddTwoNumbers_AddBothZero_ReturnsAddedNumbers()
        {
            var input_l1 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 0 });
            var input_l2 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 0 });
            var expected = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 0 });
            var sut = new Solution();

            var actual = sut.AddTwoNumbers(input_l1, input_l2);

            AssertLinkedLists.NodesHaveEqualValue(expected, actual);
        }
        [TestMethod]
        public void AddTwoNumbers_SimpleCarry_ReturnsAddedNumbers()
        {
            var input_l1 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 2, 8, 2 });
            var input_l2 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 2, 2, 2 });
            var expected = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 4, 0, 5 });
            var sut = new Solution();

            var actual = sut.AddTwoNumbers(input_l1, input_l2);

            AssertLinkedLists.NodesHaveEqualValue(expected, actual);
        }
        [TestMethod]
        public void AddTwoNumbers_MoreSimpleCarry_ReturnsAddedNumbers()
        {
            var input_l1 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 2, 4, 3});
            var input_l2 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 5, 6, 4 });
            var expected = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 7, 0 ,8 });
            var sut = new Solution();

            var actual = sut.AddTwoNumbers(input_l1, input_l2);

            AssertLinkedLists.NodesHaveEqualValue(expected, actual);
        }
        [TestMethod]
        public void AddTwoNumbers_CarryAtEnd_ReturnsAddedNumbers()
        {
            var input_l1 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 2, 4, 6 });
            var input_l2 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 5, 2, 4 });
            var expected = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 7, 6, 0, 1 });
            var sut = new Solution();

            var actual = sut.AddTwoNumbers(input_l1, input_l2);

            AssertLinkedLists.NodesHaveEqualValue(expected, actual);
        }
        
        [TestMethod]
        public void AddTwoNumbers_Some9s_ReturnsAddedNumbers()
        {
            var input_l1 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 9, 9, 9, 9, 9, 9, 9 } );
            var input_l2 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 9, 9, 9, 9 });
            var expected = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 8, 9, 9, 9, 0, 0, 0, 1 });
            var sut = new Solution();

            var actual = sut.AddTwoNumbers(input_l1, input_l2);

            AssertLinkedLists.NodesHaveEqualValue(expected, actual);
        }
        [TestMethod]
        public void AddTwoNumbers_LongLong_ReturnsAddedNumbers()
        {
            var input_l1 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 });
            var input_l2 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 });
            var expected = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 8, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 1 });
            var sut = new Solution();

            var actual = sut.AddTwoNumbers(input_l1, input_l2);

            AssertLinkedLists.NodesHaveEqualValue(expected, actual);
        }
        [TestMethod]
        public void AddTwoNumbers_WRONG()
        {
            var input_l1 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 4 });
            var input_l2 = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 4 });
            var expected = LinkedListBuilder.CreateSinglyLinkedList(new int[] { 5 });
            var sut = new Solution();

            var actual = sut.AddTwoNumbers(input_l1, input_l2);

            AssertLinkedLists.NodesHaveEqualValue(expected, actual);
        }
    }
}
