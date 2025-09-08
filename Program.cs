namespace Assignment3._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddMatrices();
        }

        static void AddMatrices()
        {
            int n;
            Console.Write("Input the size of the square matrix (less than 5): ");
            n = Convert.ToInt32(Console.ReadLine());
            int[,] firstMatrix = new int[n, n];
            int[,] secondMatrix = new int[n, n];
            int[,] sumMatrix = new int[n, n];

            Console.WriteLine("Input elements in the first matrix :");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"element - [{i}],[{j}] : ");
                    firstMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Input elements in the second matrix :");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"element - [{i}],[{j}] : ");
                    secondMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            // Adding two matrices
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sumMatrix[i, j] = firstMatrix[i, j] + secondMatrix[i, j];
                }
            }

            // Displaying the first matrix
            Console.WriteLine("The First matrix is:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(firstMatrix[i, j].ToString().PadLeft(n + 5));
                }
                Console.WriteLine();
            }

            // Displaying the second matrix
            Console.WriteLine("The Second matrix is :");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(secondMatrix[i, j].ToString().PadLeft(n + 5));
                }
                Console.WriteLine();
            }

            // Displaying the result
            Console.WriteLine("The Addition of two matrix is :");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(sumMatrix[i, j].ToString().PadLeft(n + 5));
                }
                Console.WriteLine();
            }
        }
    }
}
