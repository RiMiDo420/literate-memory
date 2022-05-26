// See https://aka.ms/new-console-template for more information
public class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string input = Console.ReadLine();
            string[] separators = {"x", ","," " };
            string[] inputAr = input.Split(separators, 6, StringSplitOptions.TrimEntries);
            for(int i = 0; i<inputAr.Length; i++)
            {
                inputAr[i] = inputAr[i].Trim('[', ']');
            }
            int boardX = int.Parse(inputAr[0]);
            int boardY = int.Parse(inputAr[1]);
            int knightXPos = int.Parse(inputAr[2]);
            int knightYPos = int.Parse(inputAr[3]);
            int goalXPos = int.Parse(inputAr[4]);
            int goalYPos = int.Parse(inputAr[5]);
            if (knightXPos <= boardX && goalXPos <= boardX && knightYPos <= boardY && goalYPos <= boardY)
            {
                if (boardX < 2 || boardY < 2)
                {
                    Console.WriteLine("Impossible");
                    continue;
                }
                if (boardX == 2)
                {
                    if ((knightYPos % 4 == goalYPos % 4 && knightXPos == goalXPos) || ((knightYPos + 2) % 4 == goalYPos % 4 && knightXPos != goalXPos))
                    {

                    }
                    else
                    {
                        Console.WriteLine("Impossible");
                        continue;
                    }
                }
                if (boardY == 2)
                {
                    if ((knightXPos % 4 == goalXPos % 4 && knightYPos == goalYPos) || ((knightXPos + 2) % 4 == goalXPos % 4 && knightYPos != goalYPos))
                    {

                    }
                    else
                    {
                        Console.WriteLine("Impossible");
                        continue;
                    }
                }
                Console.WriteLine(GetMoves(knightXPos, knightYPos, goalXPos, goalYPos));
            }
            else
            {
                Console.WriteLine("Invalid Position");
            }
        }

        }


    public static int GetMoves(int knightXPos, int knightYPos, int goalXPos, int goalYPos)
    {
        int maxpos = 0;
        int xDist = Math.Abs(goalXPos - knightXPos);
        int yDist = Math.Abs(goalYPos - knightYPos);
        int distance = xDist + yDist;
        if (xDist > yDist)
        {
            maxpos = xDist;
        }
        else
        {
            maxpos = yDist;
        }
        if (Math.Ceiling(distance / 3.0) > Math.Ceiling(maxpos / 2.0))
        {
            int moves = (int)Math.Ceiling(distance / 3.0);
            if(moves%2 == distance % 2)
            {
                return moves;
            }
            return moves + 1;
        }
        else
        {
            int moves = (int)Math.Ceiling(maxpos / 2.0);
            if (moves % 2 == distance % 2)
            {
                return moves;
            }
            return moves + 1;
        }
    }
}