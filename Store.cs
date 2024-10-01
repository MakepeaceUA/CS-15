using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public enum StoreType
    {
        Grocery,       
        Household,     
        Clothing,      
        Footwear 
    }

    internal class Store : IDisposable
    {
        public string StoreName { get; set; }
        public string Address { get; set; }
        public StoreType TypeOfStore { get; set; }

        private bool disposed = false; 

        public Store(string s, string a, StoreType st)
        {
            StoreName = s;
            Address = a;
            TypeOfStore = st;
        }
      
        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {StoreName}, Адресс: {Address}, Тип магазина: {TypeOfStore}");
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    Console.WriteLine("Освобождение управляемых ресурсов.");
                }
                Console.WriteLine("Освобождение неуправляемых ресурсов.");
                disposed = true;
            }
        }
        ~Store()
        {
            Dispose(false);
            Console.WriteLine($"Магазин '{StoreName}' удалён из памяти.");
        }
    }
}
