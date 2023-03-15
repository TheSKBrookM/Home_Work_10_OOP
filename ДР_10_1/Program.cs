namespace ДР_10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Array Length: ");
            string a = Console.ReadLine();
            int arrayLength = string.IsNullOrEmpty(a) ? 0 : Int32.Parse(a);

            var list = new MyList<float>();

            var r = new Random();
            for (int i = 0; i < arrayLength; i++)
            {
                list.Add(r.NextSingle());
            }

            Console.WriteLine();

            Console.WriteLine("Array elements:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Find contains number: ");
            float contains = Single.Parse(Console.ReadLine());

            Console.WriteLine();

            if (list.Contains(contains))
            {
                Console.WriteLine("Array contains your number!");
            }
            else
            {
                Console.WriteLine("Your number was not found");
            }

            Console.ReadKey();
        }
    }
}