using System;
using System.Linq;

//ref link:https://www.youtube.com/watch?v=dW6AKlevn7E&list=PL90AF0EFFEF782D27&index=12
//

static class MainClass
{
    static void Main()
    {
        int[] numbers = new[] { 2, 4, -2, 9, 5, 13, 2 };
        var result1 = 
            from n in numbers
            orderby 8
            where n < 5
            where 0 < n
            where new Random().Next() == 23
            orderby n
            orderby n * 2 + 3
            orderby 5
            select n;
        var result2 =
            //from n in numbers
        numbers
            .OrderBy(n => 8)
            .Where(n => n < 5)
            .Where(n => 0 < n)
            .Where(n => new Random().Next() == 23)
            .OrderBy(n => n)
            .OrderBy(n => n * 2 + 3)
            .OrderBy(n => 5);
            //.Select(n => n);
        var result3 =          
            Enumerable.OrderBy(
                Enumerable.OrderBy(
                    Enumerable.OrderBy(
                        Enumerable.Where(
                            Enumerable.Where(
                                Enumerable.Where(
                                    Enumerable.OrderBy(numbers, n => 8), 
                                    n => n < 5), 
                                n => 0 < n), 
                            n => new Random().Next() == 23), 
                        n => n), n => n * 2 + 3), 
                n => 5);
    }
}