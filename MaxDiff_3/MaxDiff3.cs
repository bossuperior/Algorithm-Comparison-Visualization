class MaxDiff3
{
    static void Main(String[] args)
    {
        int[] a = { 2, 4, 6, 8, 10 };
        int result = MaxDiff(a);
        Console.WriteLine($"Maximun Difference is: {result}");
    }
    static int MaxDiff(int[] a)
    {
        int min = int.MaxValue;
        int max = int.MinValue;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] > max) max = a[i];
            if (a[i] < min) min = a[i];
        }
        return max - min;
    }
}