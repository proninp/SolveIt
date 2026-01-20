namespace SolveIt.Easy._3213;

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class ReverseListSolution
{
    public ListNode ReverseList(ListNode head)
    {
        var current = head;
        ListNode prev = null;
        ListNode next;

        while (current != null)
        {
            next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }
        
        return prev;
    }
}