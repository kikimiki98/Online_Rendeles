namespace ZH2_H41JAK
{
    public class Regeny : Konyv, Rendelheto
    {
        private string TartalmiOsszefoglalo;

        public Regeny(string szerzo, string cim, string tartalmiOsszefoglalo) : base(szerzo, cim)
        {
            this.TartalmiOsszefoglalo = tartalmiOsszefoglalo;
        }

        public override bool DedikalASzerzo()
        {
            return true;
        }

        public void Rendel(int db)
        {
            Console.WriteLine($"Rendelni kell {db} regényt az alábbiból: {base.ToString()}");
        }

        public override string ToString()
        {
            return $"{base.ToString()}, tartalmi összefoglaló: {TartalmiOsszefoglalo}";
        }
    }

}
