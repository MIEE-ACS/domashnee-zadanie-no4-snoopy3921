double[,] A = new double[10, 10], B = new double[10, 10];
double s = 0;
int n, cnt = 0;
Random rand = new Random();
Console.WriteLine("Original matrix:");
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        A[i, j] = rand.Next(-10, 11);
        Console.Write(A[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("\nSmoothed matrix:");//Сглаженная матрица
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        n = 8; // Number of cells surrounding {i,j}cell
        try { B[i, j] += A[i + 1, j]; }     catch { n--; }
        try { B[i, j] += A[i + 1, j + 1]; } catch { n--; }
        try { B[i, j] += A[i, j + 1]; }     catch { n--; }
        try { B[i, j] += A[i - 1, j + 1]; } catch { n--; }
        try { B[i, j] += A[i - 1, j]; }     catch { n--; }
        try { B[i, j] += A[i - 1, j - 1]; } catch { n--; }
        try { B[i, j] += A[i, j - 1]; }     catch { n--; }
        try { B[i, j] += A[i + 1, j - 1]; } catch { n--; }
        B[i, j] /= n;
        if (i < j) s += Math.Abs(B[i, j]); // Sum of elements above main diagonal
        if (B[i, j] > A[i, j]) cnt++; // Number of local minimum number in matrix A
        Console.Write(Math.Round(B[i, j], 3) + "\t");
    }
    Console.WriteLine();
}
Console.Write("\nThe sum of elements above the main diagonal is equal to {0}", Math.Round(s, 3));
Console.Write("\nNumber of local minimum number is equal to {0}", cnt);
