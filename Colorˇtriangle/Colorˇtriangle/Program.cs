using System;

namespace Colorˇtriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(EvaluateTriangle(Console.ReadLine()));
            }
        }

        public static char EvaluateTriangle(string currentRow)
        {
            char[] rowAr = currentRow.ToCharArray();
            string returnString = "";
            if(rowAr.Length == 1)
            {
                return rowAr[0];
            }
            if (rowAr.Length == 0)
            {
                return 'X';
            }
            for (int i = 0; i<(rowAr.Length-1); i++)
            {
                string currentPair = rowAr[i].ToString() + rowAr[i + 1].ToString();
                if(currentPair == "RR" || currentPair == "GB" || currentPair == "BG")
                {
                    returnString += "R";
                }
                else if (currentPair == "GG" || currentPair == "RB" || currentPair == "BR")
                {
                    returnString += "G";
                }
                else if (currentPair == "BB" || currentPair == "GR" || currentPair == "RG")
                {
                    returnString += "B";
                }
            }
            return EvaluateTriangle(returnString);
        }
    }
}
