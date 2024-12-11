class MaxDiff2
{
    static void Main(string[] args)
    {
        int[] a = { 1, 2, 3, 4, 5 }; // ตัวอย่างอาร์เรย์ที่ใช้ทดสอบ
        int result = MaxDiff(a);
        Console.WriteLine($"The maximum difference in the array is: {result}");
    }
    static int MaxDiff(int[] a)
    {
        int maxdiff = 0;
        for (int i = 0; i < a.Length; i++)
            for (int j = i + 1; j < a.Length; j++)
            {
                int diff = Math.Abs(a[i] - a[j]);
                if (diff > maxdiff)
                    maxdiff = diff;
            }
        return maxdiff;
    }
}