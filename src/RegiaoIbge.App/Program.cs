using System;
using System.Linq;
using System.Threading;

namespace RegiaoIbge.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var _context = new IbgeContext();
            var cidades = _context.Cidades.ToList().FindAll(x => string.IsNullOrEmpty(x.Mesorregiao));
            var service = new IbgeService();

            Console.WriteLine($"Iniciando procedimento.\n{cidades.Count} cidades para atualizar.");

            foreach (var cidade in cidades)
            {
                try
                {
                    service.GetIgbe(cidade.CodigoMunicipio);
                    cidade.Mesorregiao = service.GetMesorregiao();
                    cidade.Uf = service.GetUf();
                    _context.Cidades.Update(cidade);
                    _context.SaveChanges();
                    Console.WriteLine($"A cidade {cidade.NomeMunicipio} atualizou a mesorregiao para {cidade.Mesorregiao}");
                    //Thread.Sleep(1000);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Não foi possível atualizar mesorregiao para a cidade {cidade.NomeMunicipio}. Erro: {e.Message}");
                }
            }

            var cidades_naoatualizadas = _context.Cidades.ToList().FindAll(x => string.IsNullOrEmpty(x.Mesorregiao)).Count;
            var cidades_atualizadas = _context.Cidades.ToList().FindAll(x => !string.IsNullOrEmpty(x.Mesorregiao)).Count;

            Console.WriteLine("----------");
            Console.WriteLine($"Processo finalizado.\nCidades Atualizadas: {cidades_atualizadas}\nCidades Não-Atualizadas: {cidades_naoatualizadas}");

            Console.ReadKey();

        }
    }
}
