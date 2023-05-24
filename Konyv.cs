using System.Security.Cryptography.X509Certificates;

namespace ZH2_H41JAK
{
    public abstract class Konyv
    {
        protected string Szerzo;
        protected string Cim;

        public Konyv(string szerzo, string cim)
        {
            this.Szerzo = szerzo;
            this.Cim = cim;
        }

        public abstract bool DedikalASzerzo();
        public void Rendel(int db)
        {
            Console.WriteLine($"Rendelni kell {db} regényt az alábbiból: {base.ToString()}");
        }

        public override string ToString()
        {
            return $"{Cim} - {Szerzo}";
        }
    }
}
