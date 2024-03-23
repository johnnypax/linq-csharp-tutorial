using LINQ_lez02_FiltroOggettiStudente.Classes;

namespace LINQ_lez02_FiltroOggettiStudente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Studente> elenco = new List<Studente>()
            //{
            //    new Studente() { Nominativo = "Giovanni Pace" , Eta = 15, Matricola = "AB12345" },
            //    new Studente() { Nominativo = "Valeria Verdi" , Eta = 16, Matricola = "AB12346" },
            //    new Studente() { Nominativo = "Marika Mariko" , Eta = 14, Matricola = "AB12347" }
            //};

            ////Ordina tutti gli studenti per eta
            //var ordinatiPerEta = from s in elenco
            //                     orderby s.Eta
            //                     select s;

            //foreach (Studente stud in ordinatiPerEta)
            //{
            //    Console.WriteLine($"{stud.Nominativo}, matricola: {stud.Matricola}, eta: {stud.Eta}");
            //}

            ////Calcolare l'età media degli studenti - QUERY DI AGGREGAZIONE
            //var etaMedia = elenco.Average(s => s.Eta);
            //Console.WriteLine(etaMedia);

            //-------------------------------------------------------------------
            List<Studente> elenco = new List<Studente>()
            {
                new Studente() { Nominativo = "Giovanni Pace" , Eta = 15, Matricola = "AB12345" },
                new Studente() { Nominativo = "Valeria Verdi" , Eta = 16, Matricola = "AB12346" },
                new Studente() { Nominativo = "Marika Mariko" , Eta = 14, Matricola = "AB12347" }
            };

            //Ricerca di una specifica matricola
            string matricolaDaCercare = "AB12347";
            var studenteTrovato = elenco.FirstOrDefault(
                s => s.Matricola != null && s.Matricola.Equals(matricolaDaCercare));

            if(studenteTrovato is null) {
                Console.WriteLine("Studente non trovato");
            } else
            {
                Console.WriteLine($"{studenteTrovato.Nominativo}, matricola: {studenteTrovato.Matricola}, eta: {studenteTrovato.Eta}");
            }

        }
    }
}
