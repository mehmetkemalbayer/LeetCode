using System;
using Xunit;
using LeetCodeSolutions;
using System.Collections.Generic;
using FluentAssertions;
namespace LeetCodeTests
{
    public class MergeTwoSortedListTests
    {
        
        ListNode list1, list2;
        MergeTwoSortedListProblem problem = new MergeTwoSortedListProblem();
        public MergeTwoSortedListTests()
        {

        }
        [Fact]
        public void Return112344() {
            list1 = ListNode.FromList(new List<int> { 1, 2, 4 });
            list2 = ListNode.FromList(new List<int> { 1, 3, 4 });
            ListNode result = problem.MergeTwoLists(list1, list2);
            List<int> expected = new List<int> { 1, 1, 2, 3, 4, 4 };
            expected.Should().Equal(result.ToList());
        }
        [Fact]
        public void ReturnsEmpty()
        {
            list1 = ListNode.FromList(new List<int> {});
            list2 = ListNode.FromList(new List<int> {});
            ListNode result = problem.MergeTwoLists(list1, list2);
            Assert.Null(result);
        }
        [Fact]
        public void ReturnsZero()
        {
            list1 = ListNode.FromList(new List<int> { });
            list2 = ListNode.FromList(new List<int> { 0 });
            ListNode result = problem.MergeTwoLists(list1, list2);
            List<int> expected = new List<int> { 0 };
            result.ToList().Should().Equal(expected);
        }
    }
}
