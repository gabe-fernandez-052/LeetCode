namespace LeetCode.Challenges.Medium
{
    /// <summary>
    /// Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:
    /// Each row must contain the digits 1-9 without repetition.
    /// Each column must contain the digits 1-9 without repetition.
    /// Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
    /// Launch Code:
    /// string[][] stringArray =
    ///[
    ///    [".",".",".",".","5",".",".","1","."],
    ///    [".","4",".","3",".",".",".",".","."],
    ///    [".",".",".",".",".","3",".",".","1"],
    ///    ["8",".",".",".",".",".",".","2","."],
    ///    [".",".","2",".","7",".",".",".","."],
    ///    [".","1","5",".",".",".",".",".","."],
    ///    [".",".",".",".",".","2",".",".","."],
    ///    [".","2",".","9",".",".",".",".","."],
    ///    [".",".","4",".",".",".",".",".","."]
    ///];
    ///
    ///char[][] charArray = new char[stringArray.Length][];
    ///for (int i = 0; i<stringArray.Length; i++)
    ///{
    ///    charArray[i] = new char[stringArray[i].Length];
    ///
    ///    for (int j = 0; j<stringArray[i].Length; j++)
    ///    {
    ///        charArray[i][j] = stringArray[i][j][0];
    ///    }
    ///}
    /// </summary>
    public class ValidSudoku : ILeetCode
    {
        public bool Run(char[][] board)
        {
            var hashSet = new HashSet<char>();

            //validate rows
            for (int i = 0; i < 9; i++)
            {
                hashSet.Clear();

                for (int j = 0; j < 9; j++)
                {
                    var character = board[i][j];

                    if (hashSet.Contains(character))
                    {
                        return false;
                    }

                    if (character != '.')
                    {
                        hashSet.Add(character);
                    }
                }
            }

            //validate columns
            for (int i = 0; i < 9; i++)
            {
                hashSet.Clear();

                for (int j = 0; j < 9; j++)
                {
                    var character = board[j][i];

                    if (hashSet.Contains(character))
                    {
                        return false;
                    }

                    if (character != '.')
                    {
                        hashSet.Add(character);
                    }
                }
            }

            //validate boxes
            var startPoints = new int[][] { [0, 0], [0, 3], [0, 6], [3, 0], [3, 3], [3, 6], [6, 0], [6, 3], [6, 6] };

            foreach (var array in startPoints)
            {
                hashSet.Clear();

                for (int i = array[0]; i < array[0] + 3; i++)
                {
                    for (int j = array[1]; j < array[1] + 3; j++)
                    {
                        var character = board[i][j];

                        if (hashSet.Contains(character))
                        {
                            return false;
                        }

                        if (character != '.')
                        {
                            hashSet.Add(character);
                        }
                    }
                }
            }

            return true;
        }
    }
}