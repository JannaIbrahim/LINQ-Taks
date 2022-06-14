using System;
using System.Linq;
using static LINQAssignment1.ListGenerators;

namespace LINQAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators
            #region 1
            //1. Find all products that are out of stock.

            //var outOfStock = ProductList.Where(p => p.UnitsInStock == 0);

            //foreach (var p in outOfStock)
            //    Console.WriteLine(p); 
            #endregion

            #region 2
            //2. Find all products that are in stock and cost more than 3.00 per unit.

            //var ProductCG3 = from p in ProductList
            //                 where (p.UnitsInStock != 0 && p.UnitPrice > (decimal)3.00)
            //                 select p;

            //foreach (var p in ProductCG3)
            //    Console.WriteLine(p); 
            #endregion

            #region 3
            //3. Returns digits whose name is shorter than their value.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var digitNameShorterThanValue = Arr.Where((a, i) => a.Length < i);
            //foreach (var item in digitNameShorterThanValue)
            //    Console.WriteLine(item);
            #endregion
            #endregion

            #region LINQ - Element Operators

            #region 1
            //1. Get first Product out of Stock 

            //var firstOutOfStock = ProductList.First(p => p.UnitsInStock == 0);

            //Console.WriteLine(firstOutOfStock);

            #endregion

            #region 2

            //2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //var FirstGT1000 = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);

            //Console.WriteLine(FirstGT1000); 
            #endregion

            //3. Retrieve the second number greater than 5 

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var secondGT5 = Arr.SkipWhile(n => n <= 5);

            //foreach(var i in secondGT5)
            //    Console.WriteLine(i);



            #endregion

            #region LINQ - Ordering Operators

            #region 1
            //1. Sort a list of products by name

            //var sortedProducts = ProductList.OrderBy(p => p.ProductName);
            //foreach (var item in sortedProducts)
            //    Console.WriteLine(item);

            #endregion

            #region 2
            //2. Uses a custom comparer to do a case-insensitive sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var orderedArr = from s in Arr
            //                 orderby s.ToLower()
            //                 select s;

            //foreach (var item in orderedArr)
            //    Console.WriteLine(item); 
            #endregion


            #region 3
            //3. Sort a list of products by units in stock from highest to lowest.

            //var sortedUnitsInStock = from p in ProductList
            //                         orderby p.UnitsInStock descending
            //                         select p;
            //foreach(var item in sortedUnitsInStock)
            //    Console.WriteLine(item);

            #endregion

            #region 4
            //4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var sortedNameLength = from a in Arr
            //                       orderby a.Length
            //                       select a;

            //Console.WriteLine("Array elements sorted by length of their names");
            //foreach(var item in sortedNameLength)
            //    Console.WriteLine(item);


            //var sortedAlphabetically = from a in Arr
            //                           orderby a
            //                           select a;
            //Console.WriteLine("--------------------------------------------------------------");

            //Console.WriteLine("Array elements sorted alphabetically");

            //foreach(var item in sortedAlphabetically)
            //    Console.WriteLine(item);
            #endregion


            #region 5
            //5. Sort first by word length and then by a case-insensitive sort of the words in an array.
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var wordsLengthSort = from w in words
            //                      orderby w.Length
            //                      select w;

            //var wordsCaseSort = from w in words
            //                    orderby w.ToLower()
            //                    select w;

            //Console.WriteLine("Array Sorted By Word Length:");
            //foreach(var item in wordsLengthSort)
            //    Console.WriteLine(item);

            //Console.WriteLine("------------------------------------------------------------");
            //Console.WriteLine("Array Sorted Case-Insensitive:");

            //foreach(var item in wordsCaseSort)
            //    Console.WriteLine(item);

            #endregion

            #region 6
            //6. Sort a list of products, first by category, and then by unit price, from highest to lowest.

            //var pSortedByCategoryTPrice = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);

            //foreach(var item in pSortedByCategoryTPrice)
            //    Console.WriteLine(item);
            #endregion

            #region 7
            ////7. Sort first by word length and then by a case-insensitive descending sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var WordLengthTCaseSorted = Arr.OrderBy(a => a.Length).ThenByDescending(a => a.ToLower());

            //foreach (var item in WordLengthTCaseSorted)
            //    Console.WriteLine(item); 
            #endregion

            #region 8
            //8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Arr2ndi = Arr.Where(a => a[1] == 'i').OrderByDescending((a, i) => i);

            //foreach(var item in Arr2ndi)
            //    Console.WriteLine(item);
            #endregion


            #endregion


            #region LINQ – Transformation Operators


            #region 1
            //1. Return a sequence of just the names of a list of products.

            //var productNames = ProductList.Select(p => p.ProductName);

            //foreach(var item in productNames)
            //    Console.WriteLine(item);

            #endregion

            #region 2
            //2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var wordsCase = words.Select(w => new {upper= w.ToUpper(),lower= w.ToLower() });

            //foreach(var item in wordsCase)
            //    Console.WriteLine(item);


            #endregion

            #region 3
            //3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

            //var productv1 = ProductList.Select(p => new { Name = p.ProductName, ID = p.ProductID, Price = p.UnitPrice });

            //foreach(var item in productv1)
            //    Console.WriteLine(item);
            #endregion

            #region 4
            //4. Determine if the value of ints in an array match their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var ArrValuePosition = Arr.Select((a, i) => $"{a} : {((a == i) ? "True": "False")}");

            //Console.WriteLine("Number: In-place?");
            //foreach(var item in ArrValuePosition)
            //    Console.WriteLine(item);


            #endregion

            #region 5
            //5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };


            #endregion

            #region 6
            //6. Select all orders where the order total is less than 500.00.

            //var ordersLT500 = CustomerList.SelectMany(c=> c.Orders.Where(o=>o.Total<(decimal)500.00));

            //foreach(var item in ordersLT500)
            //    Console.WriteLine(item);

            #endregion

            #region 7

            //7. Select all orders where the order was made in 1998 or later.

            //var ordersS1998 = CustomerList.SelectMany(c=> c.Orders.Where(o=>o.OrderDate.Year>=1998));

            //foreach(var item in ordersS1998)
            //    Console.WriteLine(item);
            #endregion

            #endregion
        }
    }
}
