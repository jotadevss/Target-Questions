namespace TargetQuestions;

public class Question5
{
      public static void ReverseString(string pattern)
      {
            char[] letters = pattern.ToCharArray();

            int index = 0;
            char[] reversedLetters = new char[letters.Length];
            for (int i = letters.Length - 1; i >= 0; i--)
            {
                  reversedLetters[index] = letters[i];
                  index++;
            }

            string revertsePattern = new(reversedLetters);

            Console.WriteLine(revertsePattern);
      }
}
