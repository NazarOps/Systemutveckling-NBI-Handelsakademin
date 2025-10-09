using System.Runtime.InteropServices;

namespace QueueExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create object
            Queue queue = new Queue();
            queue.Run();
            queue.UserChoice();

            // create a queue
            Queue<string> customerQueue = new Queue<string>();

            customerQueue.Enqueue("1");
        }
    }
}
