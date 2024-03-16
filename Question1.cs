namespace TargetQuestions;

public class Question1
{
      public static void ValueSum()
      {
            int indice = 13;
            int soma = 0;
            int k = 0;

            while (k < indice)
            {
                  k++;
                  soma += k;
            }

            Console.WriteLine(soma); // SOMA = 91;
      }
}
