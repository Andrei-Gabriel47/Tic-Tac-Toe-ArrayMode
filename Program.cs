namespace C_._2DArray3TicTacToe
{
    internal class Program
    {
        // the playfield
        static char[,] playField =
        {
            { '1','2','3'}, //row 0
            {'4','5','6' }, 
            {'7','8','9' }
        };
        static void Main(string[] args)
        {
            int player = 2;    //Player 1 starts
            int input = 0;       
            bool inputCorect = true;
            do
            {
                if (player == 2)
                {
                    player = 1;
                }
                else player = 2;

                switch (player)
                {
                    case 1:        //Player 1 turn
                        {
                            switch (input)
                            {
                                    case 1:  playField[0, 0] = 'X';  break;
                                     case 2:playField[0, 1] = 'X'; break;
                                    case 3:  playField[0, 2] = 'X';  break;
                                    case 4:  playField[1, 0] = 'X'; break;
                                     case 5:    playField[1, 1] = 'X'; break;
                                    case 6:    playField[1, 2] = 'X';  break;
                                    case 7:   playField[2, 0] = 'X';  break;
                                    case 8:   playField[2, 1] = 'X'; break;
                                    case 9:   playField[2, 2] = 'X';break;
                            }
                            break;
                            
                        }
                        case 2:     //Player 2 turn
                        {
                            switch (input)   
                            {
                                case 1:playField[0, 0] = '0'; break;
                                case 2: playField[0, 1] = '0'; break;
                                case 3: playField[0, 2] = '0'; break;
                                case 4:playField[1, 0] = '0'; break;
                                case 5: playField[1, 1] = '0'; break;
                                case 6: playField[1, 2] = '0'; break;
                                case 7:playField[2, 0] = '0'; break;
                                case 8:playField[2, 1] = '0'; break;
                                case 9:  playField[2, 2] = '0'; break;
                            }
                            break;
                        }
                }

                SetField();
                CheckWinner();
                //Check if the field is already taken
                do
                {
                    Console.WriteLine("Player {0} choose your field",player);
                    try
                    {
                        input = int.Parse(Console.ReadLine());
                    }
                    catch {
                        Console.WriteLine("Please enter a valid number");
                    }
                    if (input == 1 && playField[0, 0] == '1') inputCorect = true;
                    else if (input == 2 && playField[0, 1] == '2') inputCorect = true;
                    else if (input == 3 && playField[0, 2] == '3') inputCorect = true;
                    else if (input == 4 && playField[1, 0] == '4') inputCorect = true;
                    else if (input == 5 && playField[1, 1] == '5') inputCorect = true;
                    else if (input == 6 && playField[1, 2] == '6') inputCorect = true;
                    else if (input == 7 && playField[2, 0] == '7') inputCorect = true;
                    else if (input == 8 && playField[2, 1] == '8') inputCorect = true;
                    else if (input == 9 && playField[2, 2] == '9') inputCorect = true;
                    else
                    {
                        Console.WriteLine("wrong input!Try another one!");
                        inputCorect = false;
                    }
                } while (inputCorect == false);
            }while(true);
        }
        //creating the field and filling it with the 2DArray
        public static void SetField()
        {
            Console.Clear();
            Console.WriteLine("        |       |       ");
            Console.WriteLine("   {0}    |   {1}   |   {2}  " , playField[0, 0], playField[0, 1], playField[0,2]);
            Console.WriteLine("--------|-------|------");
            Console.WriteLine("        |       |       ");
            Console.WriteLine("   {0}    |   {1}   |   {2}  ", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("--------|-------|------");
            Console.WriteLine("        |       |       ");
            Console.WriteLine("   {0}    |   {1}   |   {2}  ", playField[2, 0], playField[2, 1], playField[2, 2]);
        }
        //checking if we have a winner
        public static void CheckWinner()
        {
            if (playField[0, 0] == playField[0, 1] && playField[0, 1] == playField[0, 2] && playField[0, 2] == 'X') Console.WriteLine("Player 2 has won!"); 
            else if (playField[1, 0] == playField[1, 1] && playField[1, 1] == playField[1, 2] && playField[1, 2] == 'X') Console.WriteLine("Player 2 has won!");
            else if (playField[2, 0] == playField[2, 1] && playField[2, 1] == playField[2, 2] && playField[2, 2] == 'X') Console.WriteLine("Player 2 has won!");
            else if (playField[0, 0] == playField[1,0] && playField[1,0] == playField[2,0] && playField[2,0] == 'X') Console.WriteLine("Player 2 has won!");
            else if (playField[0, 1] == playField[1, 1] && playField[1, 1] == playField[2, 1] && playField[2, 1] == 'X') Console.WriteLine("Player 2 has won!");
            else if (playField[0, 2] == playField[1, 2] && playField[1, 2] == playField[2, 2] && playField[2, 2] == 'X') Console.WriteLine("Player 2 has won!");
            else if (playField[0, 0] == playField[1, 1] && playField[1, 1] == playField[2, 2] && playField[2, 2] == 'X') Console.WriteLine("Player 2 has won!");
            else if (playField[0, 2] == playField[1, 1] && playField[1, 1] == playField[2, 0] && playField[2, 0] == 'X') Console.WriteLine("Player 2 has won!");

            if (playField[0, 0] == playField[0, 1] && playField[0, 1] == playField[0, 2] && playField[0, 2] == '0') Console.WriteLine("Player 1 has won!");
            else if (playField[1, 0] == playField[1, 1] && playField[1, 1] == playField[1, 2] && playField[1, 2] == '0') Console.WriteLine("Player 1 has won!");
            else if (playField[2, 0] == playField[2, 1] && playField[2, 1] == playField[2, 2] && playField[2, 2] == '0') Console.WriteLine("Player 1 has won!");
            else if (playField[0, 0] == playField[1, 0] && playField[1, 0] == playField[2, 0] && playField[2, 0] == '0') Console.WriteLine("Player 1 has won!");
            else if (playField[0, 1] == playField[1, 1] && playField[1, 1] == playField[2, 1] && playField[2, 1] == '0') Console.WriteLine("Player 1 has won!");
            else if (playField[0, 2] == playField[1, 2] && playField[1, 2] == playField[2, 2] && playField[2, 2] == '0') Console.WriteLine("Player 1 has won!");
            else if (playField[0, 0] == playField[1, 1] && playField[1, 1] == playField[2, 2] && playField[2, 2] == '0') Console.WriteLine("Player 1 has won!");
            else if (playField[0, 2] == playField[1, 1] && playField[1, 1] == playField[2, 0] && playField[2, 0] == '0') Console.WriteLine("Player 1 has won!");
        }
    }
}