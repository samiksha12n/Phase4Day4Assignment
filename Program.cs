// See https://aka.ms/new-console-template for more information
using Phase4Day4Assignment;

List<Product> products = new List<Product>()
{
    new Product(){Id=1,PName="Shampoo",PBrand="Himalaya",PPrice=450.90,MfgDate=new DateTime(day:08,month:1,year:2021),ExpDate=new DateTime(day:08,month:01,year:2022)},
    new Product(){Id=2,PName="Detergent",PBrand="Harpic",PPrice=780.90,MfgDate=new DateTime(day:05,month:8,year:2020),ExpDate=new DateTime(day:05,month:08,year:2021)},
    new Product(){Id=3,PName="Powder",PBrand="Ponds",PPrice=250.90,MfgDate=new DateTime(day:24,month:10,year:2021),ExpDate=new DateTime(day:24,month:10,year:2022)},
    new Product(){Id=4,PName="Brush",PBrand="Oral B",PPrice=150.90,MfgDate=new DateTime(day:15,month:11,year:2022),ExpDate=new DateTime(day:15,month:11,year:2023)},
    new Product(){Id=5,PName="Cream",PBrand="Nivia",PPrice=650.90,MfgDate=new DateTime(day:25,month:04,year:2022),ExpDate=new DateTime(day:25,month:04,year:2023)},

};
Console.WriteLine("ID\t PName \t  PBrand \t  PPrice \tMfgDate \t  ExpDate");
foreach (var product in products)
{
    Console.Write(product.Id+"\t");
    Console.Write(product.PName + "\t");
    Console.Write(product.PBrand +"\t");
    Console.Write(product.PPrice + "\t");
    Console.Write(product.MfgDate.ToLongDateString() + "\t");
    Console.Write(product.ExpDate.ToLongDateString());
    Console.WriteLine("\n");
}