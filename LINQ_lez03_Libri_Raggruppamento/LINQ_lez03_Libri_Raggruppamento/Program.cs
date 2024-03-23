using LINQ_lez03_Libri_Raggruppamento.Classes;

namespace LINQ_lez03_Libri_Raggruppamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Libro> libri = new List<Libro>
            {
                new Libro { Titolo = "Libro A", Autore = "Autore 1", Genere = "Fantasy" },
                new Libro { Titolo = "Libro B", Autore = "Autore 2", Genere = "Sci-fi" },
                new Libro { Titolo = "Libro C", Autore = "Autore 1", Genere = "Fantasy" },
                new Libro { Titolo = "Libro D", Autore = "Autore 3", Genere = "Thriller" }
            };































            ////Raggruppa i titoli per genere

            var libriPerGenere = from libro in libri
                                 group libro by libro.Genere into gruppoGenere
                                 select gruppoGenere;

            foreach (var genere in libriPerGenere)
            {
                Console.WriteLine($"Genere: {genere.Key}");

                foreach (Libro lib in genere)
                {
                    Console.WriteLine($"{lib.Genere} {lib.Titolo} {lib.Autore}");
                }
            }

            //Cerca tutti i libri di Autore 1 e ordinali per titolo. Output solo Titolo e Genere
            //var risultato = from libro in libri
            //                where libro.Autore == "Autore 1"
            //                orderby libro.Titolo
            //                select new { libro.Titolo, libro.Genere };

            //foreach ( var item in risultato) {
            //    Console.WriteLine($"{item.Genere} {item.Titolo}");
            //}

            //Se il libro è fantasy festeggia
            //var selezCondizionale = from libro in libri
            //                        where libro != null
            //                        select libro.Genere == "Fantasy" ?
            //                            $"Evviva {libro.Titolo}" : $"Noooo {libro.Titolo} non è fantasy";

            //foreach (var titolo in selezCondizionale)
            //{
            //    if (titolo != null)
            //        Console.WriteLine(titolo);
            //}
        }
    }
}
