using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// https://community.topcoder.com/stat?c=problem_statement&pm=13880
/// </summary>
namespace WeeklyExercise.topcorder.srm662
{

    class Hexspeak
    {

        String decode(long ciphertext)
        {
            String hexaString = String.Format("{0:X}", ciphertext);
            foreach (char c in hexaString.ToCharArray())
            {
                if (!isValid(c))
                    return "Error!";
            }
            hexaString = hexaString.Replace('0', 'O');
            hexaString = hexaString.Replace('1', 'I');
            return hexaString;
        }

        bool isValid(char c)
        {
            if ((c >= 'A' && c <= 'F') ||
                (c == '0' || c == '1'))
                return true;
            return false;
        }

        //public convert

        public void doing()
        {

            Console.WriteLine("IOI, "       + decode(257));
            Console.WriteLine("Error!, "    + decode(258));
            Console.WriteLine("CAFEBABE, "  + decode(3405691582));
            Console.WriteLine("ABCDEFOI, "  + decode(2882400001));
            Console.WriteLine("DEOBIFFFFFFFFFF, " + decode(999994830345994239));
            Console.WriteLine("Error!, "    + decode(1000000000000000000));

        }
    }

}
