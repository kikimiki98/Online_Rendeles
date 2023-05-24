namespace ZH2_H41JAK
{
    public class CD : Rendelheto
    {
        private string EloadoNeve;
        private string AlbumCime;
        public CD(string eloadoNeve, string albumCime)
        {
            this.EloadoNeve = eloadoNeve;
            this.AlbumCime = albumCime;
        }
        public void Rendel(int db)
        {
            Console.WriteLine($"Rendelni kell {db} CD-t az alábbiból: {EloadoNeve}-{AlbumCime}");
        }
        public override string ToString()
        {
            return $"{EloadoNeve} - {AlbumCime}";
        }
    }
}
