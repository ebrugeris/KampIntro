namespace Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Products Urun1 = new Products();
            Urun1.Adi = "Çilek";
            Urun1.Adedi = 75;
            Urun1.Fiyati= 3;

            Products Urun2= new Products();
            Urun2.Adi = "Kiraz";
            Urun2.Adedi = 3;

            Products[] prdcts = new Products[] {Urun1, Urun2 };

            foreach (Products item in prdcts)
            {
                Console.WriteLine(item.Adi + ":" + item.Fiyati);
            }

          
    }
    }
}