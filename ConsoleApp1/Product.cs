namespace ConsoleApp1
{
    // erişim belirteci (opsiyonel) - class - nesnenin ismi
    public class Product
    {
        // Constructor Method
        // Yapıcı Bloklar
        // İçerisinde hiç bir ctor bulunmayan classlarda oto. sıfır argümanlı bir ctor tanımlıdır.


        // string, double, int
        public Product(string name, double price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }
        // Farklı parametre kombinasyonlarında ctor'lar tanımlanabilir
        public Product()
        {

        }
        // Çalışma zamanında birbirinden ayırt edilebilecek imzaları olması.
        public Product(string name, double price)
        {

        }

        public string Name;
        public int Stock;
        public double Price;
    }
}
