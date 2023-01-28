using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq.Expressions;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Uppdrag4_slutuppdrag_
{
    internal class Program
    {
        static void Main(string[] args)
        { // Start up gather user data.
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 60;
            Console.WindowWidth = 100;

            //Program start and name input/storage.
            Console.WriteLine("Hej!\nVälkommen till Matematikspelet.\nBörja med att skriva ditt namn och avsluta med enter.\n");
            Console.Write("Namn:");
            string name = Console.ReadLine();
            Console.Clear();


       
            //Menu Array
            string[] MenuOption = new string[] { "Addition", "Subtraktion", "Multiplikation", "Omvandling", "Avsluta" };
            int MenuSelect = 0;

            //Menu Choice
            while (true)
            {
            
                Console.Clear();
            //Addition
                if (MenuSelect == 0)
                {
                    Console.WriteLine($"Välkommen {name}.\nVad vill du öva på idag?\n");

                    Console.WriteLine(MenuOption[0] + " " + "<3");
                    Console.WriteLine(MenuOption[1]);
                    Console.WriteLine(MenuOption[2]);
                    Console.WriteLine(MenuOption[3]);
                    Console.WriteLine(MenuOption[4]);






                }
                //Subtraction
                else if (MenuSelect == 1)
                {
                    Console.WriteLine($"Välkommen {name}.\nVad vill du öva på idag?\n");

                    Console.WriteLine(MenuOption[0]);
                    Console.WriteLine(MenuOption[1] + " " + "<3");
                    Console.WriteLine(MenuOption[2]);
                    Console.WriteLine(MenuOption[3]);
                    Console.WriteLine(MenuOption[4]);






                }
                //Multiplication
                else if (MenuSelect == 2)
                {
                    Console.WriteLine($"Välkommen {name}.\nVad vill du öva på idag?\n");

                    Console.WriteLine(MenuOption[0]);
                    Console.WriteLine(MenuOption[1]);
                    Console.WriteLine(MenuOption[2] + " " + "<3");
                    Console.WriteLine(MenuOption[3]);
                    Console.WriteLine(MenuOption[4]);






                }
                // Conversion
                else if (MenuSelect == 3)
                {
                    Console.WriteLine($"Välkommen {name}.\nVad vill du öva på idag?\n");

                    Console.WriteLine(MenuOption[0]);
                    Console.WriteLine(MenuOption[1]);
                    Console.WriteLine(MenuOption[2]);
                    Console.WriteLine(MenuOption[3] + " " + "<3");
                    Console.WriteLine(MenuOption[4]);
                }
                //Exit

                else if (MenuSelect == 4)
                {
                    Console.WriteLine($"Välkommen {name}.\nVad vill du öva på idag?\n");

                    Console.WriteLine(MenuOption[0]);
                    Console.WriteLine(MenuOption[1]);
                    Console.WriteLine(MenuOption[2]);
                    Console.WriteLine(MenuOption[3]);
                    Console.WriteLine(MenuOption[4]+ "<3");
                }
                
                // Arrow Key Codde
                var KeyPressed = Console.ReadKey();

                if (KeyPressed.Key == ConsoleKey.DownArrow && MenuSelect != MenuOption.Length - 1)
                {
                    MenuSelect++;
                }
                else if (KeyPressed.Key == ConsoleKey.UpArrow && MenuSelect >= 1)
                {
                    MenuSelect--;
                }
                else if (KeyPressed.Key == ConsoleKey.Enter)
                {      
                    // Menu Select 1-5 and exception handling.
                    switch (MenuSelect)
                    {
                        case 0:
                           try { 
                            StartAddition();
                            }
                            catch
                            {
                                Console.WriteLine("Aj då, skriv siffra, inte bokstav, tryck på enter för att pröva igen!");
                                Console.ReadKey();
                            }
                            break;

                        case 1:
                            try
                            {
                                StartSubtraktion();
                            }
                            catch
                            {
                                Console.WriteLine("Aj då, skriv siffra, inte bokstav, tryck på enter för att pröva igen!");
                                Console.ReadKey();

                            }
                            break;

                        
                        case 2:
                            try { 
                            StartMultiplikation();
                            }
                            catch
                            {
                                Console.WriteLine("Aj då, skriv siffra, inte bokstav, tryck på enter för att pröva igen!");
                                Console.ReadKey();

                            }
                            break;

                        
                        case 3:
                            try { 
                            StartOmvandling();
                            }
                            catch
                            {
                                Console.WriteLine("Använd dig av heltal eller decimaltal! Inte bokstäver!");
                                Console.ReadKey();
                            }
                            break;
                            
                       // Exit
                        case 4:
                            return;

                    }
                }



            } //Exit Loop



        }


        // Method menuchoice 1 Addition dificculty. Addition numbers
        public static void StartAddition()

        {
            string[] Difficulty = new string[] { "Lätt", "Svår", "Gå tillbaka till huvudmenyn" };
            int MenuSelect2 = 0;
            Console.Clear();

            while (true)
            {
                Console.Clear();

                if (MenuSelect2 == 0)
                {
                    Console.WriteLine("Välj din svårighetsgrad!\n");
                    Console.WriteLine(Difficulty[0] + "<3");
                    Console.WriteLine(Difficulty[1]);
                    Console.WriteLine(Difficulty[2]);
                }

                else if (MenuSelect2 == 1)
                {
                    Console.WriteLine("Välj din svårighetsgrad!\n");
                    Console.WriteLine(Difficulty[0]);
                    Console.WriteLine(Difficulty[1] + "<3");
                    Console.WriteLine(Difficulty[2]);
                }

                else if (MenuSelect2 == 2)
                {
                    Console.WriteLine("Välj din svårighetsgrad!\n");
                    Console.WriteLine(Difficulty[0]);
                    Console.WriteLine(Difficulty[1]);
                    Console.WriteLine(Difficulty[2] + "<3");
                }

              
                //Arrowkey code
                var KeyPressed = Console.ReadKey();

                if (KeyPressed.Key == ConsoleKey.DownArrow && MenuSelect2 != Difficulty.Length - 1)
                {
                    MenuSelect2++;
                }
                else if (KeyPressed.Key == ConsoleKey.UpArrow && MenuSelect2 >= 1)
                {
                    MenuSelect2--;
                }
                else if (KeyPressed.Key == ConsoleKey.Enter)
                {
                    if (MenuSelect2 == 0)
                    {
                       
                      
                         //Addition game start
                        Console.Clear();
                       
                        Random rnd = new Random();
                        Random rnd2 = new Random();
                        int tal1 = rnd.Next(1,10);
                        int tal2 = rnd2.Next(1,10);
                        int sum = tal2 + tal1;
                       Console.WriteLine( tal1 + "+" + tal2 + "=" );
                        Console.Write("Svar:");
                        int summa = Convert.ToInt32(Console.ReadLine());

                       if (summa == sum) 
                        {
                            Console.WriteLine("Bra! Tryck på enter för att testa ett nytt tal!");
                            Console.ReadKey();
                        }
                        
                       else
                        {
                            Console.WriteLine($"Aj då, rätt svar är {sum}. Tryck på enter för att testa ett nytt tal!");
                            Console.ReadKey();
                        }
                        Console.Clear();

                        Random rnd3 = new Random();
                        Random rnd4 = new Random();
                        int tal3 = rnd3.Next(1, 10);
                        int tal4 = rnd4.Next(1, 10);
                        int sum1 = tal3 + tal4;
                        Console.WriteLine(tal3 + "+" + tal4 + "=");
                        
                        Console.Write("Svar:");
                        int summa1 = Convert.ToInt32(Console.ReadLine());

                        if (summa1 == sum1)
                        {
                            Console.WriteLine("Bra! Tryck på enter för komma tillbaka till menyn!!");
                            Console.ReadKey();
                        }

                        else
                        {
                            Console.WriteLine($"Aj då, rätt svar är {sum1}. Tryck på enter för att komma tillbaka till menyn.");
                            Console.ReadKey();
                        }
                        
                      
                         }

                    else if (MenuSelect2 == 1)
                    {
                        Console.Clear();

                        Random rnd = new Random();
                        Random rnd2 = new Random();
                        int tal1 = rnd.Next(10, 100);
                        int tal2 = rnd2.Next(10, 100);
                        int sum = tal2 + tal1;
                        Console.WriteLine(tal1 + "+" + tal2 + "=");

                        Console.Write("Svar:");
                        int summa = Convert.ToInt32(Console.ReadLine());

                        if (summa == sum)
                        {
                            Console.WriteLine("Bra! Tryck på enter för att testa ett nytt tal!");
                            Console.ReadKey();
                        }

                        else
                        {
                            Console.WriteLine($"Aj då, rätt svar är {sum}. Tryck på enter för att testa ett nytt tal!");
                            Console.ReadKey();
                        }
                        Console.Clear();

                        Random rnd3 = new Random();
                        Random rnd4 = new Random();
                        int tal3 = rnd3.Next(10, 100);
                        int tal4 = rnd4.Next(10, 100);
                        int sum1 = tal3 + tal4;
                        Console.WriteLine(tal3 + "+" + tal4 + "=");
                        
                        Console.Write("Svar:");
                        int summa1 = Convert.ToInt32(Console.ReadLine());

                        if (summa1 == sum1)
                        {
                            Console.WriteLine("Bra! Tryck på enter för komma tillbaka till menyn!!");
                            Console.ReadKey();
                        }

                        else
                        {
                            Console.WriteLine($"Aj då, rätt svar är {sum1}. Tryck på enter för att komma tillbaka till menyn.");
                            Console.ReadKey();
                        }


                    }
                    // Back to maim menu
                    else if (MenuSelect2 == 2)
                    {
                        return;
                    }





                }

            }

        }
        // Method menuchoice 2. Subtraction dificculty. Subtract numbers.
        public static void StartSubtraktion()

        {
            string[] Difficulty = new string[] { "Lätt", "Svår", "Gå tillbaka till huvudmenyn" };
            int MenuSelect2 = 0;
            Console.Clear();

            while (true)
            {
                Console.Clear();

                if (MenuSelect2 == 0)
                {
                    Console.WriteLine("Välj din svårighetsgrad!\n");
                    Console.WriteLine(Difficulty[0] + "<3");
                    Console.WriteLine(Difficulty[1]);
                    Console.WriteLine(Difficulty[2]);
                }

                else if (MenuSelect2 == 1)
                {
                    Console.WriteLine("Välj din svårighetsgrad!\n");
                    Console.WriteLine(Difficulty[0]);
                    Console.WriteLine(Difficulty[1] + "<3");
                    Console.WriteLine(Difficulty[2]);
                }

                else if (MenuSelect2 == 2)
                {
                    Console.WriteLine("Välj din svårighetsgrad!\n");
                    Console.WriteLine(Difficulty[0]);
                    Console.WriteLine(Difficulty[1]);
                    Console.WriteLine(Difficulty[2] + "<3");
                }


                // Arrow key code
                var KeyPressed = Console.ReadKey();

                if (KeyPressed.Key == ConsoleKey.DownArrow && MenuSelect2 != Difficulty.Length - 1)
                {
                    MenuSelect2++;
                }
                else if (KeyPressed.Key == ConsoleKey.UpArrow && MenuSelect2 >= 1)
                {
                    MenuSelect2--;
                }
                else if (KeyPressed.Key == ConsoleKey.Enter)
                {
                    // Subtraction game start
                    if (MenuSelect2 == 0)
                    {
                        Console.Clear();

                        Random rnd = new Random();
                        Random rnd2 = new Random();
                        int tal1 = rnd.Next(1, 10);
                        int tal2 = rnd2.Next(1, 10);
                        int sum = tal2 - tal1;
                        Console.WriteLine(tal1 + "-" + tal2 + "=");
                        
                        
                        Console.Write("Svar:");
                        int summa = Convert.ToInt32(Console.ReadLine());

                        if (summa == sum)
                        {
                            Console.WriteLine("Bra! Tryck på enter för att testa ett nytt tal!");
                            Console.ReadKey();
                        }

                        else
                        {
                            Console.WriteLine($"Aj då, rätt svar är {sum}. Tryck på enter för att testa ett nytt tal!");
                            Console.ReadKey();
                        }
                        Console.Clear();

                        Random rnd3 = new Random();
                        Random rnd4 = new Random();
                        int tal3 = rnd3.Next(1, 10);
                        int tal4 = rnd4.Next(1, 10);
                        int sum1 = tal3 - tal4;
                        Console.WriteLine(tal3 + "-" + tal4 + "=");
                        
                        Console.Write("Svar:");
                        int summa1 = Convert.ToInt32(Console.ReadLine());

                        if (summa1 == sum1)
                        {
                            Console.WriteLine("Bra! Tryck på enter för komma tillbaka till menyn!!");
                            Console.ReadKey();
                        }

                        else
                        {
                            Console.WriteLine($"Aj då, rätt svar är {sum1}. Tryck på enter för att komma tillbaka till menyn.");
                            Console.ReadKey();
                        }


                    }

                    else if (MenuSelect2 == 1)
                    {
                        Console.Clear();

                        Random rnd = new Random();
                        Random rnd2 = new Random();
                        int tal1 = rnd.Next(10, 100);
                        int tal2 = rnd2.Next(10, 100);
                        int sum = tal2 + tal1;
                        Console.WriteLine(tal1 + "+" + tal2 + "=");

                        Console.Write("Svar:");
                        int summa = Convert.ToInt32(Console.ReadLine());

                        if (summa == sum)
                        {
                            Console.WriteLine("Bra! Tryck på enter för att testa ett nytt tal!");
                            Console.ReadKey();
                        }

                        else
                        {
                            Console.WriteLine($"Aj då, rätt svar är {sum}. Tryck på enter för att testa ett nytt tal!");
                            Console.ReadKey();
                        }
                        Console.Clear();

                        Random rnd3 = new Random();
                        Random rnd4 = new Random();
                        int tal3 = rnd3.Next(10, 100);
                        int tal4 = rnd4.Next(10, 100);
                        int sum1 = tal3 - tal4;
                        Console.WriteLine(tal3 + "+" + tal4 + "=");
                        
                        Console.Write("Svar:");
                        int summa1 = Convert.ToInt32(Console.ReadLine());

                        if (summa1 == sum1)
                        {
                            Console.WriteLine("Bra! Tryck på enter för komma tillbaka till menyn!!");
                            Console.ReadKey();
                        }

                        else
                        {
                            Console.WriteLine($"Aj då, rätt svar är {sum1}. Tryck på enter för att komma tillbaka till menyn.");
                            Console.ReadKey();
                        }


                    }
                    // Back to maim menu
                    else if (MenuSelect2 == 2)
                    {
                        return;
                    }





                }

            }

        }
        //  // Method menuchoice 3. Multiplication dificculty. Multiply numbers
        public static void StartMultiplikation()

        {
            string[] Difficulty = new string[] { "Lätt", "Svår", "Gå tillbaka till huvudmenyn" };
            int MenuSelect2 = 0;
            Console.Clear();

            while (true)
            {
                Console.Clear();

                if (MenuSelect2 == 0)
                {
                    Console.WriteLine("Välj din svårighetsgrad!\n");
                    Console.WriteLine(Difficulty[0] + "<3");
                    Console.WriteLine(Difficulty[1]);
                    Console.WriteLine(Difficulty[2]);
                }

                else if (MenuSelect2 == 1)
                {
                    Console.WriteLine("Välj din svårighetsgrad!\n");
                    Console.WriteLine(Difficulty[0]);
                    Console.WriteLine(Difficulty[1] + "<3");
                    Console.WriteLine(Difficulty[2]);
                }

                else if (MenuSelect2 == 2)
                {
                    Console.WriteLine("Välj din svårighetsgrad!\n");
                    Console.WriteLine(Difficulty[0]);
                    Console.WriteLine(Difficulty[1]);
                    Console.WriteLine(Difficulty[2] + "<3");
                }


                //Arrow key code
                var KeyPressed = Console.ReadKey();

                if (KeyPressed.Key == ConsoleKey.DownArrow && MenuSelect2 != Difficulty.Length - 1)
                {
                    MenuSelect2++;
                }
                else if (KeyPressed.Key == ConsoleKey.UpArrow && MenuSelect2 >= 1)
                {
                    MenuSelect2--;
                }
                else if (KeyPressed.Key == ConsoleKey.Enter)
                {
                    if (MenuSelect2 == 0)
                    {
                        Console.Clear();

                        Random rnd = new Random();
                        Random rnd2 = new Random();
                        int tal1 = rnd.Next(1, 5);
                        int tal2 = rnd2.Next(1, 5);
                        int sum = tal2 * tal1;
                        Console.WriteLine(tal1 + "x" + tal2 + "=");

                        Console.Write("Svar:");
                        int summa = Convert.ToInt32(Console.ReadLine());

                        if (summa == sum)
                        {
                            Console.WriteLine("Bra! Tryck på enter för att testa ett nytt tal!");
                            Console.ReadKey();
                        }

                        else
                        {
                            Console.WriteLine($"Aj då, rätt svar är {sum}. Tryck på enter för att testa ett nytt tal!");
                            Console.ReadKey();
                        }

                        Console.Clear();

                        Random rnd3 = new Random();
                        Random rnd4 = new Random();
                        int tal3 = rnd3.Next(1, 5);
                        int tal4 = rnd4.Next(1, 5);
                        int sum1 = tal3 * tal4;
                        Console.WriteLine(tal3 + "x" + tal4 + "=");

                        Console.Write("Svar:");
                        int summa1 = Convert.ToInt32(Console.ReadLine());

                        if (summa1 == sum1)
                        {
                            Console.WriteLine("Bra! Tryck på enter för att testa ett nytt tal!");
                            Console.ReadKey();
                        }

                        else
                        {
                            Console.WriteLine($"Aj då, rätt svar är {sum1}. Tryck på enter för att komma till menyn!");
                            Console.ReadKey();
                        }


                    }

                    else if (MenuSelect2 == 1)
                    {
                        Console.Clear();

                        Random rnd = new Random();
                        Random rnd2 = new Random();
                        int tal1 = rnd.Next(6, 10);
                        int tal2 = rnd2.Next(6, 10);
                        int sum = tal2 * tal1;
                        Console.WriteLine(tal1 + "x" + tal2 + "=");

                        Console.Write("Svar:");
                        int summa = Convert.ToInt32(Console.ReadLine());

                        if (summa == sum)
                        {
                            Console.WriteLine("Bra! Tryck på enter för att testa ett nytt tal!");
                            Console.ReadKey();
                        }

                        else
                        {
                            Console.WriteLine($"Aj då, rätt svar är {sum}. Tryck på enter för att testa ett nytt tal!");
                            Console.ReadKey();
                        }

                        Console.Clear();

                        Random rnd3 = new Random();
                        Random rnd4 = new Random();
                        int tal3 = rnd3.Next(6, 10);
                        int tal4 = rnd4.Next(6, 10);
                        int sum1 = tal3 * tal4;
                        Console.WriteLine(tal3 + "x" + tal4 + "=");

                        Console.Write("Svar:");
                        int summa1 = Convert.ToInt32(Console.ReadLine());

                        if (summa1 == sum)
                        {
                            Console.WriteLine("Bra! Du kan ju det här! Tryck på enter för att komma till menyn!");
                            Console.ReadKey();
                        }

                        else
                        {
                            Console.WriteLine($"Aj då, rätt svar är {sum1}. Tryck på enter för att testa att komma tillbaka till menyn!");
                            Console.ReadKey();
                        }


                    }

                    // Back to maim menu
                    else if (MenuSelect2 == 2)
                    {
                        return;
                    }





                }

            }

        }
        //  // Method menuchoice 4. Conversion dificculty. Convert Unit of measure.
        public static void StartOmvandling()

        {
            string[] Difficulty = new string[] { "Lätt", "Svår", "Gå tillbaka till huvudmenyn" };
            int MenuSelect2 = 0;
            Console.Clear();

           while (true) {
                Console.Clear();

                if (MenuSelect2 == 0)
                {
                    Console.WriteLine("Välj din svårighetsgrad!\n");
                    Console.WriteLine(Difficulty[0] + "<3");
                    Console.WriteLine(Difficulty[1]);
                    Console.WriteLine(Difficulty[2]);
                }

                else if (MenuSelect2 == 1)
                {
                    Console.WriteLine("Välj din svårighetsgrad!\n");
                    Console.WriteLine(Difficulty[0]);
                    Console.WriteLine(Difficulty[1] + "<3");
                    Console.WriteLine(Difficulty[2]);
                }

                else if (MenuSelect2 == 2)
                {
                    Console.WriteLine("Välj din svårighetsgrad!\n");
                    Console.WriteLine(Difficulty[0]);
                    Console.WriteLine(Difficulty[1]);
                    Console.WriteLine(Difficulty[2] + "<3");
                }

                // Arrow key code

                var KeyPressed = Console.ReadKey();

                if (KeyPressed.Key == ConsoleKey.DownArrow && MenuSelect2 != Difficulty.Length - 1)
                {
                    MenuSelect2++;
                }
                else if (KeyPressed.Key == ConsoleKey.UpArrow && MenuSelect2 >= 1)
                {
                    MenuSelect2--;
                }
                else if (KeyPressed.Key == ConsoleKey.Enter)
                {


                // Conversion game  start
                if (MenuSelect2 == 0)
                {


                    Console.Clear();
                    int q1 = 1;

                    Console.WriteLine("Hur många meter är 100CM");
                    Console.Write("Svar i meter:");
                    q1 = Convert.ToInt32(Console.ReadLine());

                    if (q1 == 1)
                    {
                        Console.WriteLine("Bra jobbat!");
                    }
                    else
                    {
                        Console.WriteLine($"Aj då, rätt svar är {q1}M, tryck på enter för att komma till nästa ett annat omvandingstal.");
                    }
                    Console.ReadKey();

                    Console.Clear();

                    int q2 = 100;
                    Console.WriteLine("Hur många CM är 1M");
                    Console.Write("Svar i CM:");
                    q2 = Convert.ToInt32(Console.ReadLine());
                    if (q2 == 100)
                    {
                        Console.WriteLine($"Bra jobbat! Du kan ju det här!");
                    }
                    else
                    {
                        Console.WriteLine($"Aj då, rätt svar är {q2}CM, tryck på enter för att pröva igen!");
                    }
                    Console.ReadKey();
                    Console.Clear();
                }


                else if (MenuSelect2 == 1)
                {
                    Console.Clear();
                     decimal q3 = 13.5M;
                    
                    Console.WriteLine("Hur många CM är 135MM?");
                    Console.Write("Svar i CM:");
                    q3 = Convert.ToDecimal(Console.ReadLine());  


                    if (q3 == 13.5M )
                    {
                            Console.Clear();  
                        Console.WriteLine("Grymt jobbat! Tryck på enter för att komma till nästa omvandlingstal");
                        Console.ReadKey();
                    }
                   
                   else
                    {
                        Console.WriteLine($"Tyvärr rätt svar är {q3}MM, tryck på enter för att pröva nästa omvandlingstal.");
                        Console.ReadKey();
                    }
                    
                    Console.Clear();
                        decimal q4 = 50.37M;
                        Console.WriteLine("Hur många CM är 503,7MM");
                        Console.Write("Svar i CM:");
                        q4 = Convert.ToDecimal(Console.ReadLine());

                        if (q4 == 50.37M)
                        {
                            Console.Clear() ;
                            Console.WriteLine("Bra! Du kan ju det här!\nTryck på enter för att komma tillbaka till menyn");
                            Console.ReadKey();
                        }
                        
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"Synd svaret är {q4}CM, tryck på enter för att komma till menyn!");
                            Console.ReadKey();
                            Console.Clear();


                        }
                }

                else if (MenuSelect2 == 2)
                {
                    return;
                }

                // Back to maim menu



                }

            }

        }

    }
}



