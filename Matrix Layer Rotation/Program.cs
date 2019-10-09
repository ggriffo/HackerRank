using System;

namespace Matrix_Layer_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            MatrixRotation();
        }

        private static void MatrixRotation()
        {
            string input = Console.ReadLine();
            string[] arr = input.Split(' ');
            int row = Convert.ToInt32(arr[0].Trim());
            int col = Convert.ToInt32(arr[1].Trim());
            int rotations = Convert.ToInt32(arr[2].Trim());

            int[,] matrix = new int[row, col];
            int[][] mx = new int[row][];

            for (int i = 0; i < row; i++)
            {
                mx[i] = GetInts(Console.ReadLine(), col);

                for (int j = 0; j < col; j++)
                    matrix[i, j] = mx[i][j];
            }

            RotateAntiClockwiseByLayer(matrix, rotations);

            for (int i = 0; i < row; i++)
            {
                string s = "";
                for (int j = 0; j < col; j++)
                    s += matrix[i, j] + " ";
                Console.WriteLine(s.Trim());
            }
            Console.ReadLine();
        }

        static int[] GetInts(string inp, int cnt)
        {
            string[] vals = inp.Split(new char[] { ' ' });
            int[] res = new int[cnt];
            for (int i = 0; i < cnt; i++)
            {
                res[i] = Convert.ToInt32(vals[i]);
            }
            return res;
        }

        public static bool RotateAntiClockwiseByLayer(int[,] matrix, int steps)
        {
            if (matrix == null) return false;

            int rows = matrix.GetLength(0);  // rows
            int cols = matrix.GetLength(1);  // columns

            int startRow = 0;
            int startCol = 0;

            while (rows > 1 && cols > 1)
            {
                int circleLength = 2 * rows + 2 * cols - 4;
                int actualSteps = steps % circleLength;

                for (int step = 0; step < actualSteps; step++) //  move one step anti-clockwise a time
                {
                    int lt_corner = matrix[startRow, startCol]; // left-top corner element

                    for (int colIndex = startCol; colIndex < startCol + cols - 1; colIndex++)
                        matrix[startRow, colIndex] = matrix[startRow, colIndex + 1];

                    int lastCol = startCol + cols - 1;
                    for (int rowIndex = startRow; rowIndex < startRow + rows - 1; rowIndex++)
                        matrix[rowIndex, lastCol] = matrix[rowIndex + 1, lastCol];

                    int lastRow = startRow + rows - 1;
                    for (int colIndex = startCol + cols - 1; colIndex >= startCol + 1; colIndex--)
                        matrix[lastRow, colIndex] = matrix[lastRow, colIndex - 1];

                    for (int rowIndex = startRow + rows - 1; rowIndex >= 1 + startRow; rowIndex--)
                        matrix[rowIndex, startCol] = matrix[rowIndex - 1, startCol];

                    matrix[startRow + 1, startCol] = lt_corner;
                }

                startRow++;
                startCol++;

                rows -= 2;
                cols -= 2;
            }

            return true;
        }
    }
}
