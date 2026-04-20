




namespace EvVegiArakCLI
{
    public class Program
    {
        public static List<Arak> lista = new List<Arak>();
        static void Main(string[] args)
        {
            Beolvasas();
            Feladat2();
            Feladat3();
            Feladat6();
        }

        private static void Feladat6()
        {
            throw new NotImplementedException();
        }

        private static void Feladat3()
        {
            Console.Write("4. feladat:\nKérem adja meg a termék kódját! ");
            int kod = int.Parse(Console.ReadLine());
            var termek = lista.FirstOrDefault(t => t.Kod == kod);
            if ( termek == null)
            {
                Console.WriteLine("Nem található ilyen termék a listában. :(");
            }
            else
            {
                string honap = "";
                switch (termek.MinHonapSorszam())
                {
                    case 9: honap = "szeptember"; break;
                    case 10: honap = "október"; break;
                    case 11: honap = "november"; break;
                    case 12: honap = "december"; break;
                }
                Console.WriteLine($"A(z) {termek.Megnevezes.ToLower()} {honap} hónapban volt a legolcsóbb.");
            }
        }

        public static void Feladat2()
        {
            Console.WriteLine($"1. feladat:\nAz állományban {lista.Count()} db termék található.");
        }

        public static void Beolvasas()
        {
            StreamReader sr = new StreamReader("TermekekArai.txt");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                Arak ar = new Arak(sr.ReadLine());
                lista.Add(ar);
            }
            sr.Close();
        }
    }
}
