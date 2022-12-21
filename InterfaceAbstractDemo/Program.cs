using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;

using InterfaceAbstractDemo.Adapters;

namespace InterfaceAbstractDemo
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer {DateOfBirth = new DateTime(1995, 4, 13), FirstName="FARUK", 
                LastName= "GERİŞ", NationalityId="22210964111"});
            Console.ReadLine();
        }
    }
}