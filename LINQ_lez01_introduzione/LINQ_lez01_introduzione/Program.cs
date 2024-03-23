namespace LINQ_lez01_introduzione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeri = new List<int> { 1, 4, 6, 8, 10, 3 };

            //Voglio tutti i numeri maggiori a 5

            var risultato = from num in numeri
                            where num > 5
                            select num;

            foreach (int item in risultato)
            {
                Console.WriteLine(item);
            }

        }
    }
}
