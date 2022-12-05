namespace urunlerDeneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urunler urun1 = new Urunler();
            urun1.Urunadi = "toka";
            urun1.UrunSirasi = "iyi";

            Urunler urun2 = new Urunler();
            urun2.Urunadi = "çanta";
            urun2.UrunSirasi = "kötü";

            Urunler[] urunlers = new Urunler[] { urun1, urun2 };
            foreach (var urun in urunlers)
            {
                Console.WriteLine( urun.Urunadi+ " : " + urun.UrunSirasi);
            }



            Console.WriteLine("Hello, World!");
        }
        class Urunler
        {
            public string Urunadi { get; set; }

            public string UrunSirasi { get; set; }
        }
    }
}