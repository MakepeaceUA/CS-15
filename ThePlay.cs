using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class ThePlay : IDisposable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

        private bool disposed = false;

        public ThePlay(string t, string a, string g, int y)
        {
            Title = t;
            Author = a;
            Genre = g;
            Year = y;

        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {Title}, Автор: {Author}, Жанр: {Genre}, Год: {Year} ");
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
        ~ThePlay()
        {
            Dispose(false);
            Console.WriteLine($"Пьесса '{Title}' удалёно из памяти.");
        }
    }
}
