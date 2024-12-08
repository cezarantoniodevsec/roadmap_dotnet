namespace CSharpFoundation.DSA.MyCollections
{
    public class MyLinkedList
    {
        public Node head { get; set; }
        public class Node
        {
            public int value { get; set; }
            public Node next { get; set; }

            public Node(int v)
            {
                next = null;
                this.value = v;
            }
        }

        public void Add(int new_value)
        {
            var new_node = new Node(new_value);
            new_node.next = head;
            head = new_node;
        }
    }
}
