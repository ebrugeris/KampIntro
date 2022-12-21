namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transportation transportation1= new Transportation();
            transportation1.Colour = "pink";
            transportation1.Brand = "Renoult";
            transportation1.Model = "2016";

            TransportationManager transportationManager1 = new TransportationManager();
            transportationManager1.Sold(transportation1);
        }
    }
}