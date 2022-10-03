using System;
using System.Collections.Generic;
using System.Linq;
using LinqTutorial.MethodSyntax;

namespace LinqTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //METHOD SYNTAX

            //Any.Run();
            //All.Run();
            //Count.Run();
            //Contains.Run();
            //OrderBy.Run();
            //MinMax.Run();
            //Average.Run();
            //Sum.Run();
            //ElementAt.Run();
            //FirstLast.Run();
            //SingleElement.Run();
            //Where.Run();
            //Take.Run();
            //Skip.Run();
            //OfType.Run();
            //Distinct.Run();
            //PrependAppend.Run();
            //ConcatUnion.Run();
            //TypeSwitching.Run();           
            //Select.Run();
            //SelectMany.Run();
            //GeneratingNewCollection.Run();
            //GroupBy.Run();
            //IntersectExcept.Run();
            //Joins.Run();
            //Aggregate.Run();
            //Zip.Run();

            //QUERY SYNTAX

            //OrderBy.QuerySyntax.Run();
            //Where.QuerySyntax.Run();
            //Select.QuerySyntax.Run();
            //SelectMany.QuerySyntax.Run();
            //GroupBy.QuerySyntax.Run();
            //Joins.QuerySyntax.Run();

            //OTHERS
            //DotNet6Improvements.Run();


            //List<string> words = new List<string>{ "1.AAA", "2.BBB", "invalidWord", "4.DDD" };
            //List<string> words = new List<string> { "1.AAA", "2.BBB", "4.DDD" };
            List<string> words = new List<string> { "aaa", "END ", "ccc", "START" };

            var outstr = words.Where(word => word.Equals("START") || word.Equals("END")).Count() == 2
                ? words.SkipWhile(word => !word.Equals("START"))
                       .TakeWhile(word => !word.Equals("END"))
                       .Skip(1)
                : words.Skip(words.Count());

            Console.WriteLine(string.Join(", ", outstr));

            Console.ReadKey();
        }
    }
}
