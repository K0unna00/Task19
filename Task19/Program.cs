using System;
using ClassLibrary;

namespace Task19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            notebook.RAM = 16;
            notebook.Name = "Lenova";
            notebook.Price = 222;
            Phone phone = new Phone();
            phone.Name = "cavid";
            Phone phone1 = new Phone();
            phone1.Name = "nigga";

            Store store = new Store();
            store.NotebookLimit = 2;
            store.PhoneLimit = 2;
            store.AddProduct(notebook);
            store.AddProduct(phone);
            store.AddProduct(phone1);
            Console.WriteLine(store.FindByNo(2).Name);


        }
    }
}
