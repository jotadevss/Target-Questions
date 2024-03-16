namespace TargetQuestions;

public class Question3
{
      // 03. a) 9
      public static void OddNumbers(int sentences)
      {
            int index = 0;
            int value = 0;
            int[] oddSequence = new int[sentences];

            while (index < sentences)
            {
                  if (value <= 0) value++;
                  oddSequence[index] = value;
                  index++;
                  value += 2;
            }
      }

      // 03. b) 128
      public static void TwoTimes(int sentences)
      {
            int index = 0;
            int value = 0;
            int[] twoTimesSequence = new int[sentences];

            while (index < sentences)
            {
                  if (value < 2)
                  {
                        twoTimesSequence[index] = value += 2;
                        index++;
                  }

                  twoTimesSequence[index] = value *= 2;
                  index++;
            }
      }

      // 03. c) 49
      public static void PerfectSquare(int sentences)
      {
            int index = 0;
            int[] perfectSequence = new int[sentences];

            while (index < sentences)
            {
                  perfectSequence[index] = index * index;
                  index++;
            }
      }

      // 03. d) 100
      public static void CoupleSquare(int sentences)
      {
            int index = 0;
            int value = 0;
            int[] coupleSquare = new int[sentences];

            while (index < sentences)
            {
                  if (value <= 0) value += 2;
                  coupleSquare[index] = value * value;
                  index++;
                  value += 2;
            }
      }

      //03. e) 13
      public static void Fibonacci(int first, int second, int sentences, int counter)
      {
            if (counter < sentences)
            {
                  Fibonacci(second, first + second, sentences, counter++);
            }
      }

      // 03. f) O próximo elemento é 200, pois todos os números da sequencia começa com D
}
