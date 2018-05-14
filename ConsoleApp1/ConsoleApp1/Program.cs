using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        
            static void Main(string[] args)
            {
                //1.uzd.
                Console.WriteLine("Ievadiet skaitli:"); //izvada "Ievadiet skaitli"
                string ievads = Console.ReadLine(); //pieskir cilveka ievadito vertibu mainigajam ievads

                Console.WriteLine(PievienoSkaitli(ievads)); //Apstrada mainigo ievads funkcija PievienoSkaitli un izvada

                string izvade = PievienoSkaitli(ievads); //Otrs variants 13.rindinai
                Console.WriteLine(izvade);

                int skaits = izvade.Length; //sadi parbaudam simbolu skaitu virkne

                Console.WriteLine(skaits);

                //2.uzd
                Console.WriteLine("Ievadiet pirmo skaitli: "); //izvade
                string ievade1 = Console.ReadLine(); //pieskir cilveda ievadito vertibu
                double skaitlis1 = Convert.ToDouble(ievade1); //konverte simbolu virkni uz skaitli ar komatu

                Console.WriteLine("Ievadiet otro skaitli: "); //izvade
                ievade1 = Console.ReadLine(); //pieskir ievadito vertibu
                double skaitlis2 = Convert.ToDouble(ievade1); //konverte simbolu virkni uz skaitli ar komatu

                if (skaitlis1 != skaitlis2) //ja izpildas nosacijums, ka skaitlis1 nav vienads ar skaitli2 iet ieksa seit
                {
                    double output = SkaitluSalidzinasana(skaitlis1, skaitlis2); //izsauc funkciju, kas salidzina skaitlus
                    Console.WriteLine("Lielakais skaitlis ir " + output); //izvada lielako skaitli
                                                                          //vertibu pieskir double mainigajam double output un tas ari tiek izvadits
                }
                else //ja skaitlis1 ir vienads ar skaitli2(else, visi citi gadijumi) iet ieksa seit
                {
                    Console.WriteLine("Abi skaitli ir vienadi!"); //izvade
                }


                //cikli

                // i++      i=i+1;
                // i--      i=i-1;

                for (int i = 1; i < 5; i++) //cikla nosacijumi- for cikls darbosies 4 reizes, izvadis no 1-4
                                            //sakuma pieskiram sakuma vertibu(i=1), lidz kuram ies, attiecigi kamer i bus mazaks par 5, un i++ 
                                            //pieskir katras iteracijas sakuma, ka i=i+1
                {
                    i++;
                    Console.WriteLine(i);
                }

                int skaititajs = 0;
                while (skaititajs != 5) //cikls iet kamer skaititajs nav 5
                {
                    Console.WriteLine(skaititajs);
                    skaititajs++; //maina vertibu. Ja si rindina nav butu bezgaligais cikls
                }
                string izvele = "iziet";
                double result = 0;
                while (izvele != "iziet") //ies kamer simbolu virkne nebus "iziet"
                {
                    Console.WriteLine("Vai gribat saskaitit vai iziet?");
                    izvele = Console.ReadLine(); //ja seit ievadis iziet, tad cikls nakamo reizi cauri neies

                    if (izvele == "saskaitit")
                    {
                        Console.WriteLine("Ievadiet pirmo skaitli: ");
                        ievade1 = Console.ReadLine();
                        double a = Convert.ToDouble(ievade1);

                        Console.WriteLine("Ievadiet otro skaitli: ");
                        ievade1 = Console.ReadLine();
                        double b = Convert.ToDouble(ievade1);

                        result = Calculate(skaitlis1, skaitlis2);
                        Console.WriteLine("Rezultats= " + result);
                    }
                }

                do //tas pats, kas ar while, tikai nosacijumu parbauda iteracijas beigas, nevis sakuma
                {
                    Console.WriteLine("test");
                    Console.ReadLine();
                } while (izvele != "iziet");
                Console.ReadLine();
            }

            static string PievienoSkaitli(string skaitlis)
            {
                string rezultats = "Mans skaitlis ir " + skaitlis;
                return rezultats;
            }

            static double SkaitluSalidzinasana(double skaitlis1, double skaitlis2)
            {
                double rezultats;

                if (skaitlis1 < skaitlis2)
                {
                    rezultats = skaitlis2;
                }
                else
                {
                    rezultats = skaitlis1;
                }
                return rezultats;
            }

            static double Calculate(double skaitlis1, double skaitlis2)
            {
                return skaitlis1 + skaitlis2;
            }
        }
    }

    

