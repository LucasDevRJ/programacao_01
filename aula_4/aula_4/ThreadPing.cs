using System.Net.NetworkInformation;

namespace aula_4
{
    public class ThreadPing()
    {
        private string endereco = "google.com";
        int countPing = 0;
        bool executePing = false;

        internal void StartPing()
        {
            Console.WriteLine("Digite S a qualquer momento para interromper");

            var threadPingger = new Thread(ExecutePing);
            threadPingger.Start();
            executePing = true;

            var comandoSair = "S";
            var comando = string.Empty;

            //while (!comandoSair.Equals(comando))
            //{
            //    comando = Console.ReadLine();
            //}

            executePing = false;

            while (threadPingger.IsAlive)
            {
                Console.WriteLine("Esperando finalizar...");

                threadPingger.Join();
            }

            Console.WriteLine("Thread finalizada.");
        }

        public void ExecutePing()
        {
            while (countPing < 4)
            {
                Ping pingger = new Ping();

                var pingResponse = pingger.Send(endereco);

                Console.WriteLine($"Ping {countPing}: {endereco} | Status: {pingResponse.Status} - {pingResponse.RoundtripTime}ms");
                countPing++;

                //espera alguns segundos
                Thread.Sleep(1000);
            }
        }
    }
}