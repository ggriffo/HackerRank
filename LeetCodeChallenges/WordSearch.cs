using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallenges
{
    public class WordSearch
    {
        public bool Exist(char[][] board, string word)
        {
            var m = board.Length;
            var n = board[0].Length;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (board[i][j] == word[0] && DeepFirstSearch(board, i, j, 0, word))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool DeepFirstSearch(char[][] board, int i, int j, int count, string word)
        {
            if (count == word.Length)
            {
                return true;
            }

            if (i < 0 || i >= board.Length || j < 0 || j >= board[0].Length || board[i][j] != word[count])
            {
                return false;
            }

            char temp = board[i][j];
            board[i][j] = ' ';
            bool found = DeepFirstSearch(board, i + 1, j, count + 1, word) ||
                         DeepFirstSearch(board, i - 1, j, count + 1, word) ||
                         DeepFirstSearch(board, i, j + 1, count + 1, word) ||
                         DeepFirstSearch(board, i, j - 1, count + 1, word);
            board[i][j] = temp;

            return found;
        }
    }
}