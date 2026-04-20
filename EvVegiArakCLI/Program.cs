


namespace EvVegiArakCLI
{
    public class Program
    {
        public static List<Arak> lista = new List<Arak>();
        static void Main(string[] args)
        {
            Beolvasas();
            Feladat2();
        }

        public static void Feladat2()
        {
            Console.WriteLine($"Az állományban {lista.Count()} db termék található.");
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
