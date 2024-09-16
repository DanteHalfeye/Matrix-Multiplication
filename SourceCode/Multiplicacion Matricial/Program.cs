namespace Multiplicacion_Matricial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("¿Cuantos problemas de multiplicación matricial desea?");
            int amount;
            int.TryParse(Console.ReadLine(), out amount);


            for (int d = 0; d < amount; d++)
            {
                Console.WriteLine(" ");
                Random rnd = new Random();

                // Define the dimensions for the two matrices
                int n = rnd.Next(2, 7); // Rows of matrix 1
                int m = rnd.Next(2, 7); // Columns of matrix 1 and rows of matrix 2
                int k = rnd.Next(2, 7); // Columns of matrix 2

                // Initialize the two matrices
                int[,] matrixOneArray = new int[n, m];
                int[,] matrixTwoArray = new int[m, k];

                // Populate matrixOneArray with random values
                for (int i = 0; i < matrixOneArray.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixOneArray.GetLength(1); j++)
                    {
                        matrixOneArray[i, j] = rnd.Next(-12, 12);
                    }
                }

                // Populate matrixTwoArray with random values
                for (int i = 0; i < matrixTwoArray.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixTwoArray.GetLength(1); j++)
                    {
                        matrixTwoArray[i, j] = rnd.Next(-12, 12);
                    }
                }

                // Display both matrices side by side
                int maxRows = Math.Max(matrixOneArray.GetLength(0), matrixTwoArray.GetLength(0));

                Random fila = new Random();
                Random columna = new Random();

                int p = 0, s = 0;

                


                Console.ForegroundColor = ConsoleColor.White;
                if (n<=k)
                {
                        p = fila.Next(1, k);
                        s = columna.Next(1, k);
                    Console.WriteLine($"A\t   ⋅\t     B\t Encuentre la fila {p} y la columna {s}");
                }
                else
                {
                        p = fila.Next(1, n);
                        s = columna.Next(1, n);
                    Console.WriteLine($"A\t   ⋅\t     B\t Encuentre la fila {p} y la columna {s}");
                }
                Console.WriteLine(" ");
                for (int i = 0; i < maxRows; i++)
                {
                    // Print rows of matrixOneArray
                    if (i < matrixOneArray.GetLength(0))
                    {
                        for (int j = 0; j < matrixOneArray.GetLength(1); j++)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"{matrixOneArray[i, j],4} ");
                        }
                    }
                    else
                    {
                        // Print spaces if matrixOneArray has fewer rows
                        Console.Write(new string(' ', matrixOneArray.GetLength(1) * 5));
                    }

                    Console.Write("\t");

                    // Print rows of matrixTwoArray
                    if (i < matrixTwoArray.GetLength(0))
                    {
                        for (int j = 0; j < matrixTwoArray.GetLength(1); j++)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write($"{matrixTwoArray[i, j],4} ");
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine();
                }

            }
                Console.ReadLine();
        }

    }
}
