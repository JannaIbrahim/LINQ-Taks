using System;
using System.IO;
using System.Linq;
using static LINQAssignment2.ListGenerators;

namespace LINQAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {

            #region LINQ - Set Operators

            #region 1
            //1. Find the unique Category names from Product List

            //var distinctCategory = ProductList.Select(p => p.Category).Distinct();
            //foreach (var item in distinctCategory)
            //    Console.WriteLine(item);

            #endregion

            #region 2
            //2. Produce a Sequence containing the unique first letter from both product and customer names.

            //var productFirstLetter = ProductList.Select(p => p.ProductName[0]).Distinct().ToList();
            //var customerFirstLetter = CustomerList.Select(c => c.CompanyName).Distinct().ToList();
            //var FirstLetters = productFirstLetter.Union(customerFirstLetter);

            //foreach(var item in FirstLetters)
            //    Console.WriteLine(item);

            #endregion

            #region 3
            //3. Create one sequence that contains the common first letter from both product and customer names.

            //var productFirstLetter = ProductList.Select(p => p.ProductName[0]).Distinct().ToList();
            //var customerFirstLetter = CustomerList.Select(c => c.CompanyName).Distinct().ToList();
            //var FirstLetters = productFirstLetter.Intersect(customerFirstLetter);

            //foreach(var item in FirstLetters)
            //    Console.WriteLine(item);
            #endregion

            #region 4
            //4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            //var productFirstLetter = ProductList.Select(p => p.ProductName[0]).Distinct().ToList();
            //var customerFirstLetter = CustomerList.Select(c => c.CompanyName).Distinct().ToList();
            //var FirstLetters = productFirstLetter.Except(customerFirstLetter);

            //foreach(var item in FirstLetters)
            //    Console.WriteLine(item);
            #endregion


            #region 5
            //5. Create one sequence that contains the last Three Characters in each names of all customers and products, including any duplicates

            //var productFirstLetter = ProductList.Select(p => p.ProductName[0]).Distinct().ToList();
            //var customerFirstLetter = CustomerList.Select(c => c.CompanyName).Distinct().ToList();
            //var FirstLetters = productFirstLetter.Concat(customerFirstLetter);

            //foreach(var item in FirstLetters)
            //    Console.WriteLine(item); 
            #endregion

            #endregion

            #region LINQ - Aggregate Operators

            #region 1
            //1. Uses Count to get the number of odd numbers in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var odds = Arr.Count(a => a % 2 != 0);

            //Console.WriteLine(odds);

            #endregion


            #region 2
            //2. Return a list of customers and how many orders each has.

            //var customerOrders = CustomerList.Select(c => new { Customer = c, orderCount = c.Orders.Count() });

            //foreach (var item in customerOrders)
            //    Console.WriteLine(item); 
            #endregion

            #region 3
            //3. Return a list of categories and how many products each has

            //var categoryItemsCount = ProductList.Select(p => new { category = p.Category, productsCount = ProductList.Count(c => c.Category == p.Category) }).Distinct();


            //var categories = ProductList.Select(p => p.Category).Distinct();
            //var categoryCounter = categories.Select(c => new { Category = c, ProductNmbers = ProductList.Count(p=> p.Category==c) });

            //foreach(var item in categoryCounter)
            //    Console.WriteLine(item);
            #endregion

            #region 4
            //4. Get the total of the numbers in an array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var sum = Arr.Sum();

            //Console.WriteLine(sum); 
            #endregion

            #region 5
            //5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] EnglishDic = File.ReadAllLines("dictionary_english.txt").ToArray();

            //var totalCharNum = EnglishDic.Sum(w => w.Length);
            //Console.WriteLine(totalCharNum);

            #endregion

            #region 6
            //6. Get the total units in stock for each product category.

            //var unitsInStock = ProductList.Select(p => new { Category = p.Category, inStock = ProductList.Where(w => w.Category == p.Category).Sum(u => u.UnitsInStock) }).Distinct();

            //foreach (var item in unitsInStock)
            //    Console.WriteLine(item); 
            #endregion

            #region 7
            //7. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] EnglishDic = File.ReadAllLines("dictionary_english.txt").ToArray();

            ////var shortestWord = EnglishDic.Where(w => w.Length == EnglishDic.Min(r => r.Length));

            //var shortestWord = from w in EnglishDic
            //                   where w.Length == EnglishDic.Min(r => r.Length)
            //                   select w;

            //Console.WriteLine(shortestWord); 
            #endregion

            #region 8
            //8. Get the cheapest price among each category's products

            //var cheapestPrice = (from p in ProductList
            //                     select new { category = p.Category, chaepest = ProductList.Where(c => c.Category == p.Category).Min(m => m.UnitPrice) }).Distinct();

            //foreach (var item in cheapestPrice)
            //    Console.WriteLine(item);
            #endregion

            #region 9
            //9. Get the products with the cheapest price in each category (Use Let)

            //var cheapest = from p in ProductList
            //               let c = ProductList.Where(c => c.Category == p.Category).Min(m => m.UnitPrice)
            //               select new { Category = p.Category, Cheapest = c }; 
            #endregion

            #region 10
            //10. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] EnglishDic = File.ReadAllLines("dictionary_english.txt").ToArray();

            //var longestWordL = EnglishDic.Max(w => w.Length);

            //Console.WriteLine(longestWordL); 
            #endregion

            #region 11
            //11. Get the most expensive price among each category's products.

            //var mostEcpensive = (from p in ProductList
            //                     select new { Category = p.Category, MostExpencivePrice = ProductList.Where(c => c.Category == p.Category).Max(m => m.UnitPrice) }).Distinct();

            //foreach (var item in mostEcpensive)
            //    Console.WriteLine(item); 
            #endregion

            #region 12
            //12. Get the products with the most expensive price in each category.

            //var mostEcpensive = (from p in ProductList
            //                     select new { Category = p.Category, MostExpencivePrice = ProductList.Where(c => c.Category == p.Category).Max(m => m.UnitPrice) }).Distinct();

            //foreach (var item in mostEcpensive)
            //    Console.WriteLine(item); 
            #endregion

            #region 13
            //13. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string[] EnglishDic = File.ReadAllLines("dictionary_english.txt").ToArray();

            //var avgLength = EnglishDic.Average(w => w.Length);

            //Console.WriteLine(avgLength); 
            #endregion

            #region 14
            //14. Get the average price of each category's products.

            var avgPrice = (from p in ProductList
                                 select new { category = p.Category, Avarage = ProductList.Where(c => c.Category == p.Category).Average(m => m.UnitPrice) }).Distinct();

            foreach (var item in avgPrice)
                Console.WriteLine(item);
            #endregion
            #endregion

        }
    }
}
