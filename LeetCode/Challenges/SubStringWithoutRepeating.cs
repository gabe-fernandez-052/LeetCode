namespace LeetCode.Challenges
{
    /// <summary>
    /// Given a string s, find the length of the longest substring without repeating characters.
    /// s consists of English letters, digits, symbols and spaces.
    /// </summary>
    public class SubStringWithoutRepeating : ILeetCode
    {
        public int Run(string s)
        {
            int result = 0;
            var allCharactersOuter = s.ToArray();
            var seenCharacters = new HashSet<char>();
            ///dvdf
            for (int i = 0; i < allCharactersOuter.Length; i++)
            {
                seenCharacters.Add(allCharactersOuter[i]);
                result = seenCharacters.Count() > result ? seenCharacters.Count() : result;

                for (int j = i + 1; j < allCharactersOuter.Length; j++)
                {
                    if (seenCharacters.Contains(allCharactersOuter[j]))
                    {
                        seenCharacters.Clear();
                        break;
                    }

                    seenCharacters.Add(allCharactersOuter[j]);
                    result = seenCharacters.Count() > result ? seenCharacters.Count() : result;
                }
            }

            return result;
        }
    }
}