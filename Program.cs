namespace ConsoleApp9

{
    internal class Program
    {

        static void Main(string[] args)
        {
            ThePlay obj = new ThePlay("The play","Author","Genre",2000);

            obj.DisplayInfo();
            obj.Dispose();

            Store store = new Store("Store", "Adress", StoreType.Grocery);
            store.DisplayInfo();
            store.Dispose();
        }
    }
}