namespace TargetQuestions;

public class Question4
{
      public static void IdentifySwitches()
      {
            int heatingTime = 5;
            // Simular estados de switch 
            bool[] switchStates = { true, false, true }; // true: Ligado, false: Desligado

            // Simular os estados da lâmpada com base nos estados do interruptor 
            bool[] lampStates = { false, false, false }; // false: Desligado, true: Ligado

            // Simular a primeira visita
            lampStates[0] = true;  // Ligue a lâmpada 1 (controlada pelo interruptor 1) para o aquecimento
            Thread.Sleep(heatingTime * 1000); // Simule a espera com 1 segundo de atraso por unidade
            switchStates[0] = false;  // Desligar interruptor 1
            switchStates[1] = true; // Ligue brevemente o interruptor 2
            Thread.Sleep(1000);     //  Simule um pequeno atraso
            switchStates[1] = false;  // Desligue o interruptor 2
            switchStates[2] = true;  // Ligue o interruptor 3 para observação

            // // Simular a segunda visita
            Dictionary<int, int> lampResults = new Dictionary<int, int>();
            for (int i = 0; i < 3; i++)
            {
                  if (lampStates[i])
                  {
                        // A lâmpada está acesa, controlada pelo interruptor atualmente ativo (3)
                        lampResults.Add(2, i + 1);
                  }
                  else
                  {
                        /// A lâmpada está apagada, determine o controle com base na temperatura (simulada por estados de interruptor)
                        if (switchStates[0])  // A lâmpada 1 estava anteriormente ligada (quente)
                        {
                              lampResults.Add(0, i + 1);
                        }
                        else
                        {
                              lampResults.Add(1, i + 1);
                        }
                  }
            }

            Console.WriteLine($"Interruptor 1 controla lampada: {lampResults[0]}");
            Console.WriteLine($"Interruptor 2 controla lampada: {lampResults[1]}");
            Console.WriteLine($"Interruptor 3 controla lampada: {lampResults[2]}");


      }
}
