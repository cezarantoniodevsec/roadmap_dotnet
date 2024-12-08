using System.Collections;

namespace CSharpFoundation.DSA
{
    public class QueueExercises
    {
        public static int[] reversingTheFirstKElements(Queue queue, int k)
        {
            Queue<int> result = new Queue<int>();
            var pilhaAux = new Stack();
            for (int i = 0; i < k; i++)
            {
                pilhaAux.Push((int)queue.Peek());
                queue.Dequeue();
            }

            foreach (var item in pilhaAux)
                result.Enqueue((int)item);

            var cont = queue.Count;
            for (int i = 0; i < cont; i++)
            {
                result.Enqueue((int)queue.Peek());
                queue.Dequeue();
            }
            return result.ToArray();
        }
    }
}
