namespace homework_4_27_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the array size : ");

            int.TryParse(Console.ReadLine(), out int size);

            int[] arr = new int[size];
            int[] helpArr = new int[size];

            for (int i = 0; i<size; i++)
            {
                Console.Write($" array[{i+1}] ");
                int.TryParse(Console.ReadLine(), out arr[i]);
            }

            Console.Write("Enter position split of array : ");

            int.TryParse(Console.ReadLine(), out int pos);

            for (int i = pos+1 ; i < size; i++) 
            {
                helpArr[i - pos -1] = arr[i];
            }
            for (int i = 0; i <= pos; i++) 
            {
                helpArr[size-pos-1+i] = arr[i];
            }

            foreach (int i in helpArr) 
            {
                Console.WriteLine(i+" ") ;
            }
        }
    }
}