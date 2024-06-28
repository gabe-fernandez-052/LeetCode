namespace LeetCode.Challenges
{
    /// <summary>
    /// Given an integer n, return a string array answer (1-indexed) where:
    /// answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
    /// answer[i] == "Fizz" if i is divisible by 3.
    /// answer[i] == "Buzz" if i is divisible by 5.
    /// answer[i] == i(as a string) if none of the above conditions are true.
    /// </summary>
    public class FizzBuzz : ILeetCode
    {
        public IList<string> Run(int n)
        {
            var results = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    results.Add("FizzBuzz");
                    continue;
                }

                if (i % 3 == 0)
                {
                    results.Add("Fizz");
                    continue;
                }

                if (i % 5 == 0)
                {
                    results.Add("Buzz");
                    continue;
                }

                results.Add(i.ToString());
            }

            return results;
        }

        public IList<string> Switch(int n)
        {
            var list = new List<string>(n);

            for (int i = 1; i <= n; i++)
            {
                string item = (i % 3 == 0, i % 5 == 0) switch
                {
                    (true, true) => "FizzBuzz",
                    (true, false) => "Fizz",
                    (false, true) => "Buzz",
                    (false, false) => i.ToString()
                };

                list.Add(item);
            }

            return list;
        }
    }
}