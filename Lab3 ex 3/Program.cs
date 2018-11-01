using System;

namespace Lab3_ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool retourMenu = true;
            while (retourMenu == true)
            {



                int choixModeJeu = 0;

                Console.Clear();
                Console.WriteLine("1-Joueur contre Joueur");
                Console.WriteLine("2-Joueur contre IA");
                choixModeJeu = Convert.ToInt32(Console.ReadLine());

                if (choixModeJeu == 1)
                {

                    char[] tabTic = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                    void AfficherJeuTic()
                    {
                        Console.WriteLine("     |     |     ");
                        Console.WriteLine("  " + tabTic[0] + "  |  " + tabTic[1] + "  |  " + tabTic[2] + "  ");
                        Console.WriteLine("     |     |     ");
                        Console.WriteLine("-----+-----+-----");
                        Console.WriteLine("     |     |     ");
                        Console.WriteLine("  " + tabTic[3] + "  |  " + tabTic[4] + "  |  " + tabTic[5] + "  ");
                        Console.WriteLine("     |     |     ");
                        Console.WriteLine("-----+-----+-----");
                        Console.WriteLine("     |     |     ");
                        Console.WriteLine("  " + tabTic[6] + "  |  " + tabTic[7] + "  |  " + tabTic[8] + "  ");
                        Console.WriteLine("     |     |     ");
                        Console.WriteLine("");

                    }

                    int tour = 0;

                    bool jeuEnCours = true;
                    while (jeuEnCours == true)
                    {


                        Console.Clear();
                        AfficherJeuTic();

                        Console.WriteLine("Au tour du joueur 1");
                        Console.WriteLine("Que voulez vous faire?");

                        int tourJoueur1 = 0;

                        tourJoueur1 = int.Parse(Console.ReadKey().KeyChar.ToString());

                        tabTic[tourJoueur1 - 1] = 'X';




                        //---
                        if (tabTic[0] == 'X' && tabTic[1] == 'X' && tabTic[2] == 'X')
                        {
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Le joueur 1 gagne");
                            Console.ReadLine();
                            jeuEnCours = false;

                        }
                        else if (tabTic[3] == 'X' && tabTic[4] == 'X' && tabTic[5] == 'X')
                        {
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Le joueur 1 gagne");
                            Console.ReadLine();
                            jeuEnCours = false;

                        }
                        else if (tabTic[6] == 'X' && tabTic[7] == 'X' && tabTic[8] == 'X')
                        {
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Le joueur 1 gagne");
                            Console.ReadLine();
                            jeuEnCours = false;

                        }
                        // |
                        else if (tabTic[0] == 'X' && tabTic[3] == 'X' && tabTic[6] == 'X')
                        {
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Le joueur 1 gagne");
                            Console.ReadLine();
                            jeuEnCours = false;
                        }
                        else if (tabTic[1] == 'X' && tabTic[4] == 'X' && tabTic[7] == 'X')
                        {
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Le joueur 1 gagne");
                            Console.ReadLine();
                            jeuEnCours = false;
                        }
                        else if (tabTic[2] == 'X' && tabTic[5] == 'X' && tabTic[8] == 'X')
                        {
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Le joueur 1 gagne");
                            Console.ReadLine();
                            jeuEnCours = false;
                        }
                        // /
                        else if (tabTic[0] == 'X' && tabTic[4] == 'X' && tabTic[8] == 'X')
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Le joueur 1 gagne");
                            Console.ReadLine();
                            jeuEnCours = false;
                        }
                        else if (tabTic[2] == 'X' && tabTic[4] == 'X' && tabTic[6] == 'X')
                        {
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Le joueur 1 gagne");
                            Console.ReadLine();
                            jeuEnCours = false;
                        }

                        tour += 1;

                        if (tour == 9)
                        {
                            Console.Clear();
                            Console.WriteLine("Match Nul");
                            jeuEnCours = false;
                            Console.ReadLine();
                        }


                        if (jeuEnCours)
                        {
                            Console.Clear();
                            AfficherJeuTic();

                            Console.WriteLine("Au tour du joueur 2");
                            Console.WriteLine("Que voulez vous faire?");

                            int tourJoueur2 = 0;

                            tourJoueur2 = int.Parse(Console.ReadKey().KeyChar.ToString());

                            tabTic[tourJoueur2 - 1] = 'O';

                            //---
                            if (tabTic[0] == 'O' && tabTic[1] == 'O' && tabTic[2] == 'O')
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Le joueur 2 gagne");
                                Console.ReadLine();
                                jeuEnCours = false;
                            }
                            else if (tabTic[3] == 'O' && tabTic[4] == 'O' && tabTic[5] == 'O')
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Le joueur 2 gagne");
                                Console.ReadLine();
                                jeuEnCours = false;
                            }
                            else if (tabTic[6] == 'O' && tabTic[7] == 'O' && tabTic[8] == 'O')
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Le joueur 2 gagne");
                                Console.ReadLine();
                                jeuEnCours = false;
                            }
                            // |
                            else if (tabTic[0] == 'O' && tabTic[3] == 'O' && tabTic[6] == 'O')
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Le joueur 2 gagne");
                                Console.ReadLine();
                                jeuEnCours = false;
                            }
                            else if (tabTic[1] == 'O' && tabTic[4] == 'O' && tabTic[7] == 'O')
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Le joueur 2 gagne");
                                Console.ReadLine();
                                jeuEnCours = false;
                            }
                            else if (tabTic[2] == 'O' && tabTic[5] == 'O' && tabTic[8] == 'O')
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Le joueur 2 gagne");
                                Console.ReadLine();
                                jeuEnCours = false;
                            }
                            // /
                            else if (tabTic[0] == 'O' && tabTic[4] == 'O' && tabTic[8] == 'O')
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Le joueur 2 gagne");
                                Console.ReadLine();
                                jeuEnCours = false;
                            }
                            else if (tabTic[2] == 'O' && tabTic[4] == 'O' && tabTic[6] == 'O')
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Le joueur 2 gagne");
                                Console.ReadLine();
                                jeuEnCours = false;
                            }
                        }

                        tour += 1;




                    }




                }
                else if (choixModeJeu == 2)
                {

                    char[] tabTic = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                    void AfficherJeuTic()
                    {
                        Console.WriteLine("     |     |     ");
                        Console.WriteLine("  " + tabTic[0] + "  |  " + tabTic[1] + "  |  " + tabTic[2] + "  ");
                        Console.WriteLine("     |     |     ");
                        Console.WriteLine("-----+-----+-----");
                        Console.WriteLine("     |     |     ");
                        Console.WriteLine("  " + tabTic[3] + "  |  " + tabTic[4] + "  |  " + tabTic[5] + "  ");
                        Console.WriteLine("     |     |     ");
                        Console.WriteLine("-----+-----+-----");
                        Console.WriteLine("     |     |     ");
                        Console.WriteLine("  " + tabTic[6] + "  |  " + tabTic[7] + "  |  " + tabTic[8] + "  ");
                        Console.WriteLine("     |     |     ");
                        Console.WriteLine("");

                    }

                    int tour = 0;

                    bool jeuEnCours = true;
                    while (jeuEnCours == true)
                    {


                        Console.Clear();
                        AfficherJeuTic();

                        Console.WriteLine("Au tour du joueur 1");
                        Console.WriteLine("Que voulez vous faire?");

                        int tourJoueur1 = 0;

                        tourJoueur1 = int.Parse(Console.ReadKey().KeyChar.ToString());

                        tabTic[tourJoueur1 - 1] = 'X';




                        //---
                        if (tabTic[0] == 'X' && tabTic[1] == 'X' && tabTic[2] == 'X')
                        {
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Le joueur 1 gagne");
                            Console.ReadLine();
                            jeuEnCours = false;

                        }
                        else if (tabTic[3] == 'X' && tabTic[4] == 'X' && tabTic[5] == 'X')
                        {
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Le joueur 1 gagne");
                            Console.ReadLine();
                            jeuEnCours = false;

                        }
                        else if (tabTic[6] == 'X' && tabTic[7] == 'X' && tabTic[8] == 'X')
                        {
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Le joueur 1 gagne");
                            Console.ReadLine();
                            jeuEnCours = false;

                        }
                        // |
                        else if (tabTic[0] == 'X' && tabTic[3] == 'X' && tabTic[6] == 'X')
                        {
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Le joueur 1 gagne");
                            Console.ReadLine();
                            jeuEnCours = false;
                        }
                        else if (tabTic[1] == 'X' && tabTic[4] == 'X' && tabTic[7] == 'X')
                        {
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Le joueur 1 gagne");
                            Console.ReadLine();
                            jeuEnCours = false;
                        }
                        else if (tabTic[2] == 'X' && tabTic[5] == 'X' && tabTic[8] == 'X')
                        {
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Le joueur 1 gagne");
                            Console.ReadLine();
                            jeuEnCours = false;
                        }
                        // /
                        else if (tabTic[0] == 'X' && tabTic[4] == 'X' && tabTic[8] == 'X')
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Le joueur 1 gagne");
                            Console.ReadLine();
                            jeuEnCours = false;
                        }
                        else if (tabTic[2] == 'X' && tabTic[4] == 'X' && tabTic[6] == 'X')
                        {
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("Le joueur 1 gagne");
                            Console.ReadLine();
                            jeuEnCours = false;
                        }

                        tour += 1;

                        if (tour == 9)
                        {
                            Console.Clear();
                            Console.WriteLine("Match Nul");
                            jeuEnCours = false;
                            Console.ReadLine();
                        }


                        if (jeuEnCours)
                        {
                            Console.Clear();
                            AfficherJeuTic();

                            int tourJoueurIA = 0;
                            Console.WriteLine("Au tour de l'IA");





                            while (tabTic[tourJoueurIA] == 'X' || tabTic[tourJoueurIA] == 'O')
                            {
                                Random rand = new Random();
                                tourJoueurIA = rand.Next(9);

                            }



                            tabTic[tourJoueurIA] = 'O';

                            //---
                            if (tabTic[0] == 'O' && tabTic[1] == 'O' && tabTic[2] == 'O')
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Le joueur 2 gagne");
                                Console.ReadLine();
                                jeuEnCours = false;
                            }
                            else if (tabTic[3] == 'O' && tabTic[4] == 'O' && tabTic[5] == 'O')
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Le joueur 2 gagne");
                                Console.ReadLine();
                                jeuEnCours = false;
                            }
                            else if (tabTic[6] == 'O' && tabTic[7] == 'O' && tabTic[8] == 'O')
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Le joueur 2 gagne");
                                Console.ReadLine();
                                jeuEnCours = false;
                            }
                            // |
                            else if (tabTic[0] == 'O' && tabTic[3] == 'O' && tabTic[6] == 'O')
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Le joueur 2 gagne");
                                Console.ReadLine();
                                jeuEnCours = false;
                            }
                            else if (tabTic[1] == 'O' && tabTic[4] == 'O' && tabTic[7] == 'O')
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Le joueur 2 gagne");
                                Console.ReadLine();
                                jeuEnCours = false;
                            }
                            else if (tabTic[2] == 'O' && tabTic[5] == 'O' && tabTic[8] == 'O')
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Le joueur 2 gagne");
                                Console.ReadLine();
                                jeuEnCours = false;
                            }
                            // /
                            else if (tabTic[0] == 'O' && tabTic[4] == 'O' && tabTic[8] == 'O')
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Le joueur 2 gagne");
                                Console.ReadLine();
                                jeuEnCours = false;
                            }
                            else if (tabTic[2] == 'O' && tabTic[4] == 'O' && tabTic[6] == 'O')
                            {
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("Le joueur 2 gagne");
                                Console.ReadLine();
                                jeuEnCours = false;
                            }
                        }

                        tour += 1;




                    }


                }







            }
        }
    }
}
