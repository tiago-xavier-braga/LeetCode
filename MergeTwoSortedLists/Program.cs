namespace LeetCode.MergeTwoSortedLists
{
    public class Program
    {
        public static void Main()
        {
            ListNode indexATree = new(3);
            ListNode indexATwo = new(2, indexATree);
            ListNode indexAOne = new(1, indexATwo);

            ListNode indexBTree = new(4);
            ListNode indexBTwo = new(3, indexBTree);
            ListNode indexBOne = new(1, indexBTwo);

            List<ListNode> listA = new()
            {
                indexAOne,
                indexATwo,
                indexATree
            };

            List<ListNode> listB = new()
            {
                indexBOne,
                indexBTwo,
                indexBTree
            };

            List<List<ListNode>> listNodes = new() {listA, listB};
            int loopCount = listNodes.Max(list => list.Count());

            Solution solution = new();
            for (int currentIndex = 0; currentIndex < loopCount; currentIndex++)
            {
                solution.MergeTwoLists(listA[currentIndex], listB[currentIndex]);
            }

        }
    }
}
