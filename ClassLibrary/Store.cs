using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Store
    {
        public Product[] Products= new Product[0];
        public int NotebookLimit { get; set; }
        public int PhoneLimit { get; set; } 

        public void AddProduct(Product product)
        {
            if (product is Notebook && TotalCountNotebook<NotebookLimit)
            {
                Array.Resize(ref Products, Products.Length + 1);
                Products[Products.Length - 1] = product;
                TotalCountNotebook++;
            }
            else if (product is Phone && TotalCountPhone <PhoneLimit)
            {
                Array.Resize(ref Products, Products.Length + 1);
                Products[Products.Length - 1] = product;
                TotalCountNotebook++;
            }
        }
        public static int TotalCountNotebook = 0;
        public static int TotalCountPhone = 0;
        public Product FindByNo(int no)
        {
            foreach (var item in Products)
            {
                if (item is Notebook && Notebook.No == no)
                {
                    return item;
                }
                else if (item is Phone && Phone.No == no)
                {
                    return item;
                }
            }
            return null;
        }
        public double CalcNotebookAvg()
        {
            double temp = 0;
            int count = 0;
            foreach (var item in Products)
            {
                if (item is Notebook)
                {
                    temp += item.Price;
                    count++;
                }
            }
            return temp / (double)count;
        }
        public double CalcPhoneAvg()
        {
            double temp = 0;
            int count = 0;
            foreach (var item in Products)
            {
                if (item is Phone)
                {
                    temp += item.Price;
                    count++;
                }
            }
            return temp / (double)count;
        }
    }
}
