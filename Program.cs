namespace ZH2_H41JAK
{
    class Program
    {
        static List<Konyv> konyvek = new List<Konyv>();
        static List<CD> cd_k = new List<CD>();
        static void Main(string[] args)
        {

            try
            {
                RendelesFelvesz("C:\\Users\\nndda\\Desktop\\eclipse munkak\\visualstudio\\Danu\\ZH2_H41JAK\\ZH2_H41JAK\\rendelesek.txt");
                Rendel();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("A keresett fájl nem található");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Az elérési út gagyi");
            }
            
        }
        static void RendelesFelvesz(string utvonal)
        {
            string[] beolvas = File.ReadAllLines(@utvonal);
            foreach (string elem in beolvas)
            {
                string[] szavak = elem.Split(";");
                switch (szavak[0])
                {
                    case "peldatar":
                        Peldatar pd = new Peldatar(szavak[1], szavak[2], int.Parse(szavak[3]));
                        konyvek.Add(pd);
                        Console.WriteLine(pd.ToString());
                        break;
                    case "regeny":
                        Regeny reg = new Regeny(szavak[1], szavak[2], szavak[3]);
                        konyvek.Add(reg);
                        Console.WriteLine(reg.ToString());
                        break;
                    case "cd":
                        CD cd = new CD(szavak[1], szavak[2]);
                        cd_k.Add(cd);
                        Console.WriteLine(cd.ToString());
                        break;
                    default:
                        Console.WriteLine("Hibás bemeneti adatok: ");
                        break;
                }
            }                                   
        }
        static void Rendel()
        {
            Random rnd = new Random();
            foreach (Konyv konyv in konyvek)
            {
                if (rnd.Next(5, 21) == 10)
                {
                    konyv.Rendel(5);
                }
            }
            foreach (CD cd in cd_k)
            {
                if (rnd.Next(5, 21) == 10)
                {
                    cd.Rendel(5);
                }
            }
        }
    }
}