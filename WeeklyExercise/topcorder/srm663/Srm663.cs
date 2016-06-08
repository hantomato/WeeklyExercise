using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// https://community.topcoder.com/stat?c=problem_statement&pm=13917
/// </summary>
namespace WeeklyExercise.topcorder.srm663
{

    class ChessFloor
    {

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


            for (int i=0; i<temp.Length; ++i)
            {
                for (int m=0; m<temp[i].Length; ++m)
                {
                    if ((i+ m)%2 ==0)
                    {
                        black.Add(temp[i][m]);
                    }
                    else
                    {
                        white.Add(temp[i][m]);
                    }
                }
            }

            int[] blackCR = getMostRepeatChar(black);
            int[] whiteCR = getMostRepeatChar(white);
            int blackMostCR = getIndexOfMostRepeat(blackCR);
            int whiteMostCR = getIndexOfMostRepeat(whiteCR);

            int finalResult = 0;
            if (blackMostCR >= whiteMostCR)
            {
                finalResult = black.Count - blackMostCR;
                finalResult += white.Count - whiteMostCR;
            } else
            {
                ;
            }

            return finalResult;
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
            for (int i=0; i<input.Count(); ++i)
            {
                ret[input[i] - 'a']++;
            }
            return ret;
        }

        char[][] changeToCharArray(String[] input)
        {
            char[][] ret = new char[input.Length][];
            for (int i=0; i<input.Length; ++i)
                ret[i] = input[i].ToCharArray();
            return ret;
        }
        
        

        public void doing()
        {
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
