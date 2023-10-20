/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution 
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    {
        // 반환할 새로운 노드의 헤드
        ListNode dummyHead = new ListNode();
        
        // 새로운 노드를 순회할때 사용할 변수
        ListNode current = dummyHead;

        // 자리수 변수 초기에는 0으로 설정
        int carry = 0;

        while (l1 != null || l2 != null)
        {
            // 벨류를 가져온다.
            int l1Val = (l1 != null) ? l1.val : 0;
            int l2Val = (l2 != null) ? l2.val : 0;

            // 합을 구하는데 이전에 추가된 자리수를 더한다. 
            int sum = l1Val + l2Val + carry;

            // 합산 결과 10을 나누었을 때 몫은 합할 때, 추가되는 자리수이다. 
            carry = sum / 10;

            // 합산 결과 10을 나누었을 때, 나머지는 일의 자리 수다.
            current.next = new ListNode(sum % 10);

            // 다음 스탭으로 이동 
            current = current.next;

            if (l1 != null) l1 = l1.next;
            if (l2 != null) l2 = l2.next;
        }

        // 마지막에 계산 후 만약 자리수가 추가된다면
        if (carry > 0)
        {
            current.next = new ListNode(carry);
        }

        return dummyHead.next;
    }
}