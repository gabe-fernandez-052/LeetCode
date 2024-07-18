namespace LeetCode.Challenges.Easy
{
    /// <summary>
    /// Write a function that takes the binary representation of a positive integer and returns the number of set bits it has(also known as the Hamming weight).
    /// </summary>
    public class NumberOfBits : ILeetCode
    {
        public int Run(int n)
        {
            var count = 0;

            while (n != 0)
            {
                if ((n & 1u) == 1)
                {
                    count++;
                }

                n >>= 1;
            }

            return count;
        }
    }
}