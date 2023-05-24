namespace ZH2_H41JAK
{
    public class Peldatar : Konyv
    {
        protected int FeladatokSzama;

        public Peldatar(string szerzo, string cim, int feladatokSzama) : base(szerzo, cim)
        {
            this.FeladatokSzama = feladatokSzama;
        }

        public override bool DedikalASzerzo()
        {
            return false;
        }

        public override string ToString()
        {
            return base.ToString()+$", feladatok száma: {FeladatokSzama}";
        }
    }
}