// See https://aka.ms/new-console-template for more information
TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

string[] nd = Console.ReadLine().Split(' ');

int n = Convert.ToInt32(nd[0]);

int d = Convert.ToInt32(nd[1]);

int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
;
int[] result = rotLeft(a, d);

textWriter.WriteLine(string.Join(" ", result));

textWriter.Flush();
textWriter.Close();


// Complete the rotLeft function below.
static int[] rotLeft(int[] a, int d)
{
    int n = a.Length;
    int[] b = new int[n];
    for (int i = 0; i < n - d; i++)
    {
        b[i] = a[d + i];
    }
    int l = 0;
    for (int i = n - d; i < n; i++)
    {
        b[i] = a[l++];
    }
    return b;
}