int[,] GetMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rand.Next(1, 9);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int FindMinRowSum(int[,] matrix)
{   
    int minRowSum = int.MaxValue;
     int indexMinRow = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int rowSum = 0;
        
        for (int j = 0; j < matrix.GetLength(1); j++)       
             rowSum = matrix[i, j] + rowSum;
            
        if  (rowSum < minRowSum)   
        {
            minRowSum = rowSum;
            indexMinRow = i;
        }    
    }
    return   indexMinRow;
}
int[,] matrix = GetMatrix(3, 3);
PrintMatrix(matrix);
System.Console.WriteLine();
int summ = FindMinRowSum(matrix);
System.Console.WriteLine($"{summ + 1} строка");