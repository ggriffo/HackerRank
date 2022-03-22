// See https://aka.ms/new-console-template for more information
int n = Convert.ToInt32(Console.ReadLine());
string[] ar_temp = Console.ReadLine().Split(' ');
long[] ar = Array.ConvertAll(ar_temp, Int64.Parse);
long result = aVeryBigSum(n, ar);
Console.WriteLine(result);

static long aVeryBigSum(int n, long[] ar)
{
    // Complete this function
    long sum = 0;
    for (int i = 0; i < n; i++)
    {
        sum += ar[i];
    }
    return sum;
}