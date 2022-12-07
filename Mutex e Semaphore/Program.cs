using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; /*/Pra usar mutex e semaphore tem que usar essa biblioteca ao lado/*/

namespace Mutex_e_Semaphore
{
    internal class Program
    {
        static Mutex mutexTask;
        static Semaphore sempahoreTask;

        static void MostraMensagem(int numeroTask)
        {
            //mutexTask.WaitOne(); /*/ o mutex vai meio que travar a execução de todas as threads ou tasks
            //que estejam sendo executadas ao mesmo tempo, e vai fazer com que execute uma de cada vez/*/

            sempahoreTask.WaitOne(); 
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Número da task " + numeroTask + " . Número contador: " + i);
                Thread.Sleep(500);
            }
            sempahoreTask.Release();
            //mutexTask.ReleaseMutex();
        }

        static void Main(string[] args)
        {
            mutexTask = new Mutex();
            sempahoreTask = new Semaphore(2, 2); /*/O semaphore escolhe quantas threads ou tasks serão executados 
                                                  * de uma vez só, e aqui ele escolheu 2 e no maximo 2, 
                                                  * então o comando escolhe aleatoriamente qual dos
                                                  * códigos vai executar tipo, ele pode escolher o t1 e o t3/*/

            Task t1 = Task.Run(() => MostraMensagem(1));
            Task t2 = Task.Run(() => MostraMensagem(2));
            Task t3 = Task.Run(() => MostraMensagem(3));
            Task t4 = Task.Run(() => MostraMensagem(4));

            Console.ReadKey();
        }
    }
}
