// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[][] matrix;
matrix = new int[3][];
matrix[0] = new int[4];
matrix[1] = new int[4];
matrix[2] = new int[4];
matrix[0][0] = 1;
matrix[0][1] = 2;
matrix[0][2] = 3;
matrix[0][3] = 4;
matrix[1][0] = 5;
matrix[1][1] = 1;
matrix[1][2] = 2;
matrix[1][3] = 3;
matrix[2][0] = 9;
matrix[2][1] = 5;
matrix[2][2] = 1;
matrix[2][3] = 2;

Console.WriteLine(IsToeplitzMatrix(matrix).ToString());

static bool IsToeplitzMatrix(int[][] matrix)
{
    KeyValuePair<char, int> keyValuePair = new KeyValuePair<char, int>();
    keyValuePair.ad
    return false;
}
