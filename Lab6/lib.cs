public static class Lib
{
    public static int[] SumColumns(int[,] matrix)
    {
        int[] sums = new int[matrix.GetLength(1)];
        
        for (int j = 0; j < matrix.GetLength(1); j++)
            for (int i = 0; i < matrix.GetLength(0); i++)
                sums[j] += matrix[i, j];
                
        return sums;
    }
}