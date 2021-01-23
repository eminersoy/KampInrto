using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };

            //PascalCase   //camelCase       classlar PascalCase yazılırken içindeki değişken camelCase (ilk harfi küçük )yazılır. isimlendirme önemlidir
            ProductManager productManager = new ProductManager(); //eşitliğin solu stack sağı heap te referans numarası alma anlamındadır new o yüzden kullanılır
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);


            //int sayi = 100;
            //ProductManager.BiseyYap(sayi);
            //Console.WriteLine(sayi); // burda ProductManager da BiseyYap içinde sayi yi 99 olarak tanımlasak da ekranda burdaki değeri 100 yazar

            //productManager.Topla2(3, 6);
            //int toplamaSonucu = productManager.Topla(3, 6); //bu satırı Topla formülünde return sağlar. yani elde edilen sonuç tekrar kullanılacaksa public int ve return kullanılır
            //Console.WriteLine(toplamaSonucu*2);

            //int, double, bool, ... gibi sayısal olan değişkenler değer tip değişken
            //diziler, class, abstract class, interface, ...  referans tip değişken
            //ref ve out
        }
    }
}
