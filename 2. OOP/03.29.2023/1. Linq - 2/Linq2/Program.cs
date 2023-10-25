using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] ints2 = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            int[] ints3 = { 1, 1, 1, 2, 2, 2, 2, 2 };

            Console.WriteLine(nameof(Enumerable.Max));
            Console.WriteLine(ints1.Max());
            Console.WriteLine();

            Console.WriteLine(nameof(Enumerable.Min));
            Console.WriteLine(ints1.Min());
            Console.WriteLine();

            Console.WriteLine(nameof(Enumerable.Average));
            Console.WriteLine(ints1.Average());
            Console.WriteLine();

            Console.WriteLine(nameof(Enumerable.Count));
            Console.WriteLine(ints1.Count());
            Console.WriteLine();

            Console.WriteLine(nameof(Enumerable.Select));
            Console.WriteLine(string.Join(" ",ints1.Select(i => i.ToString() + 'a')));
            Console.WriteLine();

            Console.WriteLine(nameof(Enumerable.Skip));
            Console.WriteLine(string.Join(" ", ints2.Skip(3).Select(i => i.ToString())));
            Console.WriteLine();

            Console.WriteLine(nameof(Enumerable.First));
            Console.WriteLine(ints2.First().ToString());
            Console.WriteLine();

            Console.WriteLine(nameof(Enumerable.Last));
            Console.WriteLine(ints2.Last().ToString());
            Console.WriteLine();

            Console.WriteLine(nameof(Enumerable.Aggregate));
            Console.WriteLine(ints1.Aggregate((first, second) => first + second));
            Console.WriteLine();

            Console.WriteLine(nameof(Enumerable.Distinct));
            Console.WriteLine(string.Join(" ",ints3.Distinct()));
            Console.WriteLine();

            Console.WriteLine(nameof(Enumerable.GroupBy));
            Console.WriteLine(string.Join("\n", ints3.GroupBy(i => i).Select(group => $"{group.Key} : {group.Count()}")));
            Console.WriteLine();

            Console.WriteLine(nameof(Enumerable.OrderBy));
            Console.WriteLine(string.Join(" ", ints2.OrderBy(i => i)));
            Console.WriteLine();

            Console.WriteLine(nameof(Enumerable.OrderByDescending));
            Console.WriteLine(string.Join(" ", ints2.OrderByDescending(i => i)));
            Console.WriteLine();

            Console.WriteLine(nameof(Enumerable.ThenBy));
            Console.WriteLine(string.Join(" ", ints2.OrderByDescending(i => i % 2).ThenBy(i => i % 3)));
            Console.WriteLine();

            Console.WriteLine(nameof(Enumerable.ThenByDescending));
            Console.WriteLine(string.Join(" ", ints2.OrderBy(i => i % 2).ThenByDescending(i => i % 3)));
            Console.WriteLine();

            Console.WriteLine(nameof(Enumerable.ToLookup));
            Console.WriteLine(string.Join("\n", ints2.ToLookup(i => i % 2).Select(group => $"{group.Key}: {string.Join(" ", group)}")));
            Console.WriteLine();

            Console.WriteLine(nameof(Enumerable.Join));
            Console.WriteLine(string.Join(" ", ints1.Join(ints2, i1 => i1 % 2 == 0, i2 => i2%2 == 0, (i1, i2) => $"{(i1, i2)}")));
            Console.WriteLine();
        }
    }

    static class Linq2
    {
        public static IEnumerable<TResult> Select2<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
        {
            if (source is null) throw new ArgumentNullException(nameof(source));
            if (selector is null) throw new ArgumentNullException(nameof(source));

            foreach (var item in source)
                yield return selector(item);
        }
    }
}
