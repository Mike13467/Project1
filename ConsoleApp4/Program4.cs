using System;

class Program
{
    static void Main()
    {

        int[,] matrix = new int[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (i == j) 
                    matrix[i, j] = 1;
                else 
                    matrix[i, j] = 0;
            }
        }
        int[][] dynamicArray = new int[3][];
        
        for (int i = 0; i < 3; i++)
        {
            dynamicArray[i] = new int[3]; 
            for (int j = 0; j < 3; j++)
            {
                dynamicArray[i][j] = matrix[i, j];
            }
        }
        PrintJagged(dynamicArray);
    }

    static void PrintRectangular(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }


    static void PrintJagged(int[][] arr)
    {
        foreach (int[] row in arr)
        {
            foreach (int item in row)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
        }
    }
}