namespace TargetQuestions;

public class Question2
{
      public static void IsFibonacci(int first, int second, int target)
      {
            int next = first + second;

            if (next == target)
            {
                  Console.WriteLine($"O numero {target} pertence a sequencia fibonacci.");
                  return;
            }

            if (next > target)
            {
                  Console.WriteLine($"O numero {target} não pertence a sequencia fibonacci.");
                  return;
            }

            if (next < target)
            {
                  IsFibonacci(second, next, target);
            }
      }
}
