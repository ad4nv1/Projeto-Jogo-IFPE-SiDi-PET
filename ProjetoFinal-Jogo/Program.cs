using System;

namespace ProjetoFinal_Jogo
{
    class Program
    {
        //console.readkey()
        static String[,] matriz = new String[20, 20];

        static void Main(string[] args)
        {
            Acoes acoes = new Acoes();
            acoes.Life = 25;
            acoes.Monster = 1;
            acoes.Boss = 2;
            acoes.Atack = 1;
            acoes.Gun = 2;
            acoes.Score = 25;
            acoes.Porcoes = 6;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    matriz[i, j] = "O";
                }
            }

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("WELCOME THE GAME ");
            Console.WriteLine("---------------------------------------------");


            Boolean y = true;
            int linhaHero = 0;
            int colunaHero = 0;
            matriz[19, 19] = "D";

            matriz[4, 5] = "P";
            matriz[8, 12] = "P";
            matriz[15, 5] = "P";
            matriz[2, 13] = "P";
            matriz[17, 17] = "P";
            matriz[3, 9] = "P";
            matriz[5, 3] = "P";
            matriz[8, 9] = "P";


            Monster[] monster = new Monster[6];
            for (int x = 0; x < 6; x++)
            {
                monster[x] = new Monster(nameMonster: "M", LifeMonster: 5);
            }

            matriz[14, 8] = monster[0].nameMonster;
            matriz[2, 10] = monster[1].nameMonster;
            matriz[16, 14] = monster[2].nameMonster;
            matriz[9, 10] = monster[3].nameMonster;
            matriz[16, 4] = monster[4].nameMonster;
            matriz[2, 2] = monster[5].nameMonster;

            while (y)
            {
                matriz[linhaHero, colunaHero] = "A";
                Console.WriteLine("======================================");
                Console.Write("HERO HP: " + acoes.Life);
                Console.Write(" HERO DAMAGE: " + acoes.Atack);
                Console.WriteLine(" HERO SCORE: " + acoes.Score);

                Console.WriteLine("======================================");
                Console.Write("");


                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 20; j++)
                    {
                        Console.Write(matriz[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("======================================");
                Console.Write("[A] to move left.");
                Console.Write("[D] to move right.");
                Console.WriteLine("");
                Console.Write("[W] to move up.");
                Console.Write("[S] to move down.");
                Console.WriteLine("");
                Console.Write("[SPACE] atck.");
                Console.WriteLine("[ESC] exit.");
                ConsoleKeyInfo op = Console.ReadKey();
                //Console.ReadKey();
                if (op.KeyChar == 'a')
                {
                    if (colunaHero == 0)
                    {
                        colunaHero = 0;
                    }
                    else
                    {
                        matriz[linhaHero, colunaHero] = "O";

                        acoes.Life--;
                        acoes.Score--;

                        if (matriz[linhaHero, colunaHero - 1] == "P")
                        {
                            acoes.Life += 7;
                        }
                        colunaHero--;
                        if (matriz[linhaHero, colunaHero - 1] == "M")
                        {
                            acoes.Life--;
                        }



                    }

                }




                else if (op.KeyChar == 'd')
                {
                    if (colunaHero == 19)
                    {
                        colunaHero = 19;
                    }
                    else
                    {
                        matriz[linhaHero, colunaHero] = "O";

                        acoes.Life--;
                        acoes.Score--;

                        if (matriz[linhaHero, colunaHero + 1] == "P")
                        {
                            acoes.Life += 7;
                        }
                        colunaHero++;
                        if (matriz[linhaHero, colunaHero + 1] == "M")
                        {
                            acoes.Life--;
                        }



                    }


                }

                else if (op.KeyChar == 's')
                {
                    if (linhaHero == 19)
                    {
                        linhaHero = 19;
                    }
                    else
                    {
                        matriz[linhaHero, colunaHero] = "O";

                        acoes.Life--;
                        acoes.Score--;

                        if (matriz[linhaHero + 1, colunaHero] == "P")
                        {
                            acoes.Life += 7;
                        }
                        linhaHero++;
                        if (matriz[linhaHero + 1, colunaHero] == "M")
                        {
                            acoes.Life--;
                        }
                    }

                }





                else if (op.KeyChar == 'w')
                {
                    if (linhaHero == 0)
                    {
                        linhaHero = 0;
                    }

                    else
                    {

                        matriz[linhaHero, colunaHero] = "O";

                        acoes.Life--;
                        acoes.Score--;

                        if (matriz[linhaHero - 1, colunaHero] == "P")
                        {
                            acoes.Life += 7;
                        }
                        linhaHero--;
                        if (matriz[linhaHero - 1, colunaHero] == "M")
                        {
                            acoes.Life--;
                        }

                    }

                }


                else if (op.Key == ConsoleKey.Spacebar)
                {



                    for (int x = 0; x < 6; x++)
                    {
                        if (matriz[linhaHero - 1, colunaHero] == monster[x].nameMonster)
                        {
                            monster[x].LifeMonster--;
                        }
                    }



                    for (int x = 0; x < 6; x++)
                    {
                        if (matriz[linhaHero + 1, colunaHero] == monster[x].nameMonster)
                        {
                            monster[x].LifeMonster--;
                        }
                    }




                    for (int x = 0; x < 6; x++)
                    {
                        if (matriz[linhaHero, colunaHero + 1] == monster[x].nameMonster)
                        {

                            monster[x].LifeMonster--;
                        }
                    }
                    for (int x = 0; x < 6; x++)
                    {
                        if (matriz[linhaHero, colunaHero - 1] == monster[x].nameMonster)
                        {

                            monster[x].LifeMonster--;
                        }
                    }




                }




                else if (op.Key == ConsoleKey.Escape)
                {
                    break;
                }






                for (int x = 0; x < 6; x++)
                {
                    if (monster[x].LifeMonster <= 0)
                    {
                        monster[x].nameMonster = "O";
                    }
                }

                if (matriz[19, 19] == "A")
                {
                    Console.WriteLine("  VOCÊ GANHOU!!!!!!!!!!!!!!!!!!!!");
                    break;
                }
                if (acoes.Life == 0)
                {
                    Console.WriteLine("  VOCÊ PERDEU");
                    break;
                }

                Console.Clear();


            }



        }
    }
}

