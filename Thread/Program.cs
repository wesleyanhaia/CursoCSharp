using System;
using System.Threading;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace Programacao_paralela_sleep_e_threads
{
    internal class Program
    {
        static Thread t1;
        static Thread t2;
        static bool podeFinalizar;
        static UInt16 numeroDaThread;
        static object objLock;
        static Mutex meuMutex;

        static void MinhaThread1()
        {
            try
            {
                while (podeFinalizar == false)
                {
                    /* lock (objLock)
                    {
                        numeroDaThread = 1;
                        Thread.Sleep(1000);
                        Console.WriteLine("THREAD1 - Passou 1 segundo - Numero da thread " + numeroDaThread);
                    }*/

                    meuMutex.WaitOne();
                    numeroDaThread = 1;
                    Thread.Sleep(1000);
                    Console.WriteLine("THREAD1 - Passou 1 segundo - Numero da thread " + numeroDaThread);
                    meuMutex.ReleaseMutex();
                }
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine("THREAD1 EXCEÇÃO: " + e.Message);
            }
            finally
            {
                Console.WriteLine("THREAD1 - Finalizando");
            }
        }
        static void MinhaThread2()
        {
            try
            {
                while (podeFinalizar == false)
                {
                    /*lock (objLock)
                    {
                        numeroDaThread = 2;
                        Thread.Sleep(1000);
                        Console.WriteLine("THREAD2 - Passou 1 segundo - Numero da thread " + numeroDaThread);
                    }*/

                    meuMutex.WaitOne();
                    numeroDaThread = 2;
                    Thread.Sleep(1000);
                    Console.WriteLine("THREAD2 - Passou 1 segundo - Numero da thread " + numeroDaThread);
                    meuMutex.ReleaseMutex();
                }
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine("THREAD2 EXCEÇÃO: " + e.Message);
            }
            finally
            {
                Console.WriteLine("THREAD2 - Finalizando");
            }

        }

        static void Main(string[] args)
        {
           

            objLock = new object();
            meuMutex = new Mutex();

            podeFinalizar = false;

            t1 = new Thread(new ThreadStart(MinhaThread1));
            t1.Priority = ThreadPriority.BelowNormal;

            /*/Quando se trata de threads, elas tem algumas propriedades em relação a prioridades
             * ou seja, algumas podem ser executadas com mais frequencia que outras. No caso dessas duas threads
             * a t2 será executada com mais frequencia pois foi colocada a propriedade ThreadPriority.Highest
             * como comando para ela, enquanto a thread t1 foi colocado ThreadPriority.BelowNormal;/*/

            t2 = new Thread(new ThreadStart(MinhaThread2));
            t2.Priority = ThreadPriority.Highest;

            t1.Start();
            t2.Start();

            Console.ReadKey();

            //podeFinalizar = true; /*/tinha uma hora que eu nao tava entendendo como que as threads iriam
            //pausar, por causa desse podeFinalizar que tinha que ser igual a true pra sair do while, mas oq
            //tava fazendo as threads serem infinitas e não pular direto do t1.start que está logo acima
            // é o Console.ReadKey(); que espera a pessoa pressionar uma tecla para pular para o proximo
            // comando/*/ 


            t1.Abort();
            t2.Abort();

            Console.WriteLine("Pressione qualquer tecla para finalizar");
            Console.ReadKey();
        }
    }
}
