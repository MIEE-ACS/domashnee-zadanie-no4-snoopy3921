static void Swap(ref int A, ref int B)
{
    int temp;
    temp = A;
    A = B;
    B = temp;
}



try
{
    Console.WriteLine("User input N(array length): ");
    int N = Convert.ToInt32(Console.ReadLine());

    int[] Arr = new int[N];

    Random rnd = new Random();

    Console.Write("Array:\t\t\t\t");
    for (int i = 0; i < N; i++)
    {
        Arr[i] = rnd.Next(-10, 10); //Value range [-10, 10]
        Console.Write("{0}\t", Arr[i]);
    }
    int Min = Arr[0];
    for (int i = 0; i < N; i++)
    {
        Min = Min < Arr[i] ? Min : Arr[i];
    }
    Console.WriteLine("\nMinimum of array:\t{0}", Min);
    int Sum = 0;
    for (int i = 0; i < N; i++)
    {
        if (Arr[i] != 0) continue;
        else
        {
            for (int j = i; j < N; j++)
            {
                Sum += Arr[j];
            }
        }
    }
    Console.WriteLine("Sum of elements after the first zero number:\t{0}", Sum);
    if (N % 2 == 0)
    {
        for (int i = 0; i < N; i += 2)
        {
            if (i >= N / 2) break;
            Swap(ref Arr[i], ref Arr[N - 1 - i]);
        }
    }
    else
    {
        for (int i = 0; i < N; i += 2)
        {
            if (i >= (N - 1) / 2) break;
            Swap(ref Arr[i], ref Arr[(N - 1) - 1 - i]);
        }
    }
    Console.Write("New array after rearranging:\t");
    for (int i = 0; i < N; i++)
    {
        Console.Write("{0}\t", Arr[i]);
    }
    Console.ReadKey();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    return;
}
