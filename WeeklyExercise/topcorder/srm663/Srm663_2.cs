using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// https://community.topcoder.com/stat?c=problem_statement&pm=13917
/// </summary>
namespace WeeklyExercise.topcorder.srm663_2
{

    class ChessFloor
    {

        //static public String makeLine(int[] ks)
        //{
        //    //return ks
        //    //    .ToObservable()
        //    //    .GroupBy(k => k)
        //    //    .SelectMany(grp => grp.Count())
        //    //    .Max()
        //    //    .Select(m =>
        //    //    {
        //    //        if (((ks.Length + 1) / 2) >= m) return "possible";
        //    //        return "impossible";
        //    //    })
        //    //    .Last();

        //    ks
        //         .ToObservable()
        //         .GroupBy(k => k)
        //         .Select(grp => grp.Count())
        //         .Subscribe(x =>
        //         {
        //             Console.WriteLine(x.Count().First());
        //         });

        //        return "";
        //}

        int minimumChanges(String[] floor)
        {
            // flow
            // 1. String[] -> char[][]
            // 2. char[][] -> black[], white[]
            // 3. make blackCR[], whiteCR[]
            // 4. blackCR, whiteCR 각각에 대해 가장 많이 반복되는 문자 찾기
            // 5. blackMostCR, whiteMostCR

            char[][] temp = changeToCharArray(floor);
            var black = new List<char>();
            var white = new List<char>();

            char[] ttt = new char[] { 'a', 'a', 'z', 'a', 'z', 'k', 'k' };
            ttt.ToObservable()
                .GroupBy(x => x)
                .Select(x =>
               {
                   x.Count().Subscribe(
                       a =>
                       {
                           Console.WriteLine("onNext2:" + a);
                       },
                       error =>
                       {
                           Console.WriteLine("error2:" + error);
                       },
                       () =>
                       {
                           Console.WriteLine("complete2");
                       }
                       );


                   return 0;
               }).Subscribe(x => Console.WriteLine(x));




            //    //.SelectMany(x => x)
            //    //.Select(x =>
            //    //{
            //    //    var vmm = x.ToList();
            //    //    return vmm.First();
            //    //    //var vv = x.Aggregate(new { key = 'a', cnt = 0 }, (acc, src) =>
            //    //    //{

            //    //    //    return new { key = acc.key, cnt = acc.cnt + 1 };
            //    //    //}).First();
            //    //    //return vmm;
            //    //})
            //    .Subscribe(
            //    x =>
            //    {
            //        Console.WriteLine("onNext:" + x);
            //    },
            //    error =>
            //    {
            //        Console.WriteLine("error:" + error);
            //    },
            //    () =>
            //    {
            //        Console.WriteLine("complete");
            //    }
            //    );
            ////ttt.ToObservable()
            ////    .Aggregate(new { key = 'a', cnt = 0 }, (acc, src) =>
            ////    {

            ////        return new { key = acc.key, cnt = acc.cnt + 1 };
            ////    })
            ////    .Subscribe(
            ////    x => Console.WriteLine(x));


            //for (int i = 0; i < temp.Length; ++i)
            //{
            //    for (int m = 0; m < temp[i].Length; ++m)
            //    {
            //        if ((i + m) % 2 == 0)
            //        {
            //            black.Add(temp[i][m]);
            //        }
            //        else
            //        {
            //            white.Add(temp[i][m]);
            //        }
            //    }
            //}

            ///*
            //black.ToObservable()
            //    .GroupBy(x => x)
            //    .Select(x =>
            //    {
            //        return x.Aggregate(new { key = 'a', cnt = 0 }, (acc, src) =>
            //        {

            //            return new { key = acc.key, cnt = acc.cnt + 1 };
            //        }).First();
                    
            //    })
                
            //    //.
            //    //{
                    
            //    //    return x;
            //    //})
            //    .Subscribe(
            //    x =>
            //    {
            //        Console.WriteLine("onNext:" + x);
            //    },
            //    error =>
            //    {
            //        Console.WriteLine("error:" + error);
            //    },
            //    () =>
            //    {
            //        Console.WriteLine("complete");
            //    }
            //    );
            //    */
            ////char[] ttt = new char[] { 'a', 'a', 'a', 'a' };
            ////ttt.ToObservable()
            ////    .Aggregate(new { key = 'a', cnt = 0 }, (acc, src) =>
            ////          {

            ////              return new { key = acc.key, cnt = acc.cnt + 1 };
            ////          })
            ////    .Subscribe(
            ////    x => Console.WriteLine(x));



            //var source = Observable.Interval(TimeSpan.FromSeconds(0.1)).Take(10);
            //var group = source.GroupBy(i => i % 3);
            //group.Subscribe(
            //    grp =>
            //        grp.Min().Subscribe(
            //        minValue =>
            //            Console.WriteLine("{0} min value = {1}", grp.Key, minValue)),
            //() => Console.WriteLine("Completed"));


            ////string[] fruits = { "apple", "mango", "orange", "passionfruit", "grape" };

            ////// Determine whether any string in the array is longer than "banana".
            ////string longestName =
            ////    fruits.Aggregate("banana",
            ////                    (longest, next) =>
            ////                        next.Length > longest.Length ? next : longest,
            ////                    // Return the final result as an upper case string.
            ////                    fruit => fruit.ToUpper());

            ////Console.WriteLine(
            ////    "The fruit with the longest name is {0}.",
            ////    longestName);



            ////black.ToObservable()
            ////    .Count()
            ////    .Subscribe(
            ////    x =>
            ////    {
            ////        Console.WriteLine(x);
            ////    });


            //////getMostRepeatChar(black);
            ////int finalResult = 0;
            ////int[] blackCR = getMostRepeatChar(black);
            ////int[] whiteCR = getMostRepeatChar(white);
            ////int blackMostCR = getIndexOfMostRepeat(blackCR);
            ////int whiteMostCR = getIndexOfMostRepeat(whiteCR);

            ////if (blackMostCR >= whiteMostCR)
            ////{
            ////    finalResult = black.Count - blackMostCR;
            ////    //int[] whiteCR2 = getMostRepeatCharExceptT(white, );
            ////    finalResult += white.Count - whiteMostCR;
            ////} else
            ////{
            ////    int jj;
            ////    jj = 33;
            ////}

            ////return finalResult;
            return 0;
        }
        int getIndexOfMostRepeat(int[] input)
        {
            int mostIdx = 0;
            for (int i = 0; i < input.Length; ++i)
                mostIdx = Math.Max(input[i], mostIdx);
            return mostIdx;
        }

        int[] getMostRepeatChar(List<char> input)
        {
            int[] ret = new int[('z' - 'a') + 1];
            for (int i = 0; i < input.Count(); ++i)
            {
                ret[input[i] - 'a']++;
            }
            return ret;
        }

        int[] getMostRepeatCharExceptT(List<char> input, char except)
        {
            int[] ret = new int[('z' - 'a') + 1];
            for (int i = 0; i < input.Count(); ++i)
            {
                if (input[i] == except)
                    ret[input[i] - 'a'] = 0;
                else
                    ret[input[i] - 'a']++;
            }
            return ret;
        }

        char[][] changeToCharArray(String[] input)
        {
            char[][] ret = new char[input.Length][];
            for (int i = 0; i < input.Length; ++i)
                ret[i] = input[i].ToCharArray();
            return ret;
        }



        public void doing()
        {


            //Console.WriteLine("p {0}", makeLine(new int[] { 1, 1, 2, 2, 3, 3, 4, 4 }));

            Console.WriteLine("1, " + minimumChanges(new String[] {
                "aba",
                "bbb",
                "aba"}));

            Console.WriteLine("0, " + minimumChanges(new String[]
                {"wbwbwbwb",
                 "bwbwbwbw",
                 "wbwbwbwb",
                 "bwbwbwbw",
                 "wbwbwbwb",
                 "bwbwbwbw",
                 "wbwbwbwb",
                 "bwbwbwbw"}));

            Console.WriteLine("2, " + minimumChanges(new String[]   {
                "zz",
                "zz"}));

            Console.WriteLine("56, " + minimumChanges(new String[]
                {"helloand",
                 "welcomet",
                 "osingler",
                 "oundmatc",
                 "hsixhund",
                 "redandsi",
                 "xtythree",
                 "goodluck"}));

            Console.WriteLine("376, " + minimumChanges(new String[]   {
                "jecjxsengslsmeijrmcx",
                "tcfyhumjcvgkafhhffed",
                "icmgxrlalmhnwwdhqerc",
                "xzrhzbgjgabanfxgabed",
                "fpcooilmwqixfagfojjq",
                "xzrzztidmchxrvrsszii",
                "swnwnrchxujxsknuqdkg",
                "rnvzvcxrukeidojlakcy",
                "kbagitjdrxawtnykrivw",
                "towgkjctgelhpomvywyb",
                "ucgqrhqntqvncargnhhv",
                "mhvwsgvfqgfxktzobetn",
                "fabxcmzbbyblxxmjcaib",
                "wpiwnrdqdixharhjeqwt",
                "xfgulejzvfgvkkuyngdn",
                "kedsalkounuaudmyqggb",
                "gvleogefcsxfkyiraabn",
                "tssjsmhzozbcsqqbebqw",
                "ksbfjoirwlmnoyyqpbvm",
                "phzsdodppzfjjmzocnge"}));

        }
    }

}
