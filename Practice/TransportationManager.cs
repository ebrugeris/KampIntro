using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class TransportationManager
    {
        public void Sold(Transportation transportation) 
        {
            Console.WriteLine(transportation.Colour + " " + transportation.Model + " " + " " + transportation.Brand + " " +" satıldı.");
        }
    }
}
