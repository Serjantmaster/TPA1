using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPA_lectii
{
    public class ASync
    {
        public async Task<List<int>> RandomNumberGenerator()
        {
            List<int> ListaNumere = new List<int>();

            await Task.Run(() =>
            {
                Random random = new Random();
                for (int i = 0; i < 5; i++)
                {
                    Task.Delay(1000).Wait();
                    ListaNumere.Add(random.Next(1,100));
                }
            });
            return ListaNumere;
        }

        public async Task<List<int>> FiltredList()
        {
            List<int> ListaNumere= await RandomNumberGenerator(); ;
            var ListaNumerePare = await Task.Run(() =>
            {
                return ListaNumere.Where(numar => numar % 2 == 0).ToList();
            });
            return ListaNumerePare;
        }
        public async Task Apelare()
        {
            
            var task =  Task.Run(() => 
            {
                RandomNumberGenerator().Wait();
            });
            var task2 = Task.Run(() =>
            {
                FiltredList().Wait();
            });

            await Task.WhenAll(task,task2);
            var ListaNumere = await Task.Run(() =>
            {
                return FiltredList();
            });
            foreach (var item in ListaNumere)
            {
                Console.WriteLine(item);
            }




        }
    }
}
