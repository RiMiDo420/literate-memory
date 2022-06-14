using System;

namespace Chess_Horse
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                string[] separators = { "x", ",", " " };
                string[] inputAr = input.Split(separators, 6, StringSplitOptions.None);


                for (int i = 0; i < inputAr.Length; i++)
                {
                    inputAr[i] = inputAr[i].Trim('[', ']');
                    inputAr[i] = inputAr[i].Trim();
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
                    if (boardX == 3)
                    {
                        if(knightXPos == 2 && goalXPos == 2 && (goalYPos - knightYPos == 2 || goalYPos - knightYPos == -2))
                        {
                            Console.WriteLine("4");
                            continue;
                        }
                    }
                    if (boardY == 3)
                    {
                        if (knightYPos == 2 && goalYPos == 2 && (goalXPos - knightXPos == 2 || goalXPos - knightXPos == -2))
                        {
                            Console.WriteLine("4");
                            continue;
                        }
                    }
                    if ((knightXPos == 1 && knightYPos == 1 && goalXPos == 2 && goalYPos == 2) || (knightXPos == 2 && knightYPos == 2 && goalXPos == 1 && goalYPos == 1))
                    {
                        if(boardX == 3 && boardY == 3)
                        {
                            Console.WriteLine("Impossible");
                            continue;
                        }
                        Console.WriteLine("4");
                        continue;
                    }
                    if ((knightXPos == 1 && knightYPos == boardY && goalXPos == 2 && goalYPos == boardY-1) || (knightXPos == 2 && knightYPos == boardY-1 && goalXPos == 1 && goalYPos == boardY))
                    {
                        if (boardX == 3 && boardY == 3)
                        {
                            Console.WriteLine("Impossible");
                            continue;
                        }
                        Console.WriteLine("4");
                        continue;
                    }
                    if ((knightXPos == boardX && knightYPos == 1 && goalXPos == boardX-1 && goalYPos == 2) || (knightXPos == boardX-1 && knightYPos == 2 && goalXPos == boardX && goalYPos == 1))
                    {
                        if (boardX == 3 && boardY == 3)
                        {
                            Console.WriteLine("Impossible");
                            continue;
                        }
                        Console.WriteLine("4");
                        continue;
                    }
                    if ((knightXPos == boardX && knightYPos == boardY && goalXPos == boardX - 1 && goalYPos == boardY-1) || (knightXPos == boardX - 1 && knightYPos == boardY-1 && goalXPos == boardX && goalYPos == boardY))
                    {
                        if (boardX == 3 && boardY == 3)
                        {
                            Console.WriteLine("Impossible");
                            continue;
                        }
                        Console.WriteLine("4");
                        continue;
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
            if(distance == 1)
            {
                return 3;
            }
            if (Math.Ceiling(distance / 3.0) > Math.Ceiling(maxpos / 2.0))
            {
                int moves = (int)Math.Ceiling(distance / 3.0);
                if (moves % 2 == distance % 2)
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
}
