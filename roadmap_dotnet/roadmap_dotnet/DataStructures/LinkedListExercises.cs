using CSharpFoundation.DSA.MyCollections;

namespace CSharpFoundation.DSA
{
    public static class LinkedListExercises
    {
        public static bool AreIdentical(MyLinkedList first, MyLinkedList second)
        {
            while (first.head != null && second.head != null)
            {
                if (first.head.value != second.head.value)
                    return false;

                first.head = first.head.next;
                second.head = second.head.next;
            }
            return (first.head == null & second.head == null);
        }
    }
}
