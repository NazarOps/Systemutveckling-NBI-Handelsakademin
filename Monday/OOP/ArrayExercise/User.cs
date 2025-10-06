namespace ArrayExercise
{
    internal class User
    {
        public int AmountToStore;
        public int[] NumbersToStore;




        public void AskUser()
        {
            Console.WriteLine("How many numbers do you want to store?");
            AmountToStore = Convert.ToInt32(Console.ReadLine());
            int[] AmounttoStore = new int[AmountToStore];

            NumbersToStore = new int[AmountToStore];

            for (int i = 0; i < AmountToStore; i++)
            {
                Console.Write($"Enter numbers {i + 1}: ");
                NumbersToStore[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < NumbersToStore.Length; i++) 
            {
                Console.WriteLine($"\nNumber {i + 1}: {NumbersToStore[i]}");
            }
        }
    }
}
