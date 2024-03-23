using LINQ_lez04_join.Classes;

namespace LINQ_lez04_join
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dipartimento> dipartimenti = new List<Dipartimento>
            {
                new Dipartimento { Id = 1, Nome = "Matematica" },
                new Dipartimento { Id = 2, Nome = "Fisica" }
            };

            List<Docente> docenti = new List<Docente>
            {
                new Docente { Nominativo = "Mario Rossi", DipartimentoId = 1 },
                new Docente { Nominativo = "Luigi Bianchi", DipartimentoId = 2 },
                new Docente { Nominativo = "Giulia Verdi", DipartimentoId = 1 }
            };

            //Restituisce tutti i docenti ed i relativi dipartimenti
            var docentiDipartimenti = from doc in docenti
                                      join dip in dipartimenti on doc.DipartimentoId equals dip.Id
                                      select new { doce = doc.Nominativo, dipa = dip.Nome };

            foreach(var item in docentiDipartimenti)
            {
                Console.WriteLine($"{item.doce} - Dipartimento: {item.dipa}");
            }
        }
    }
}
