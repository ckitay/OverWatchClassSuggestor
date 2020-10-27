/*
 * Author: Cory Kitay
 * Start Date: 07-Aug-2016
 * Purpose: Defines Class for Overwatch Character Object.
 * Used to keep track of which character is strong/neutral/weak against other characters
 * 
 * Url for character image changes: https://blzgdapipro-a.akamaihd.net/hero/orisa/icon-portrait.png
 * 
 * Acrynoms:
 * i = index
 * 
 * Recommendation Last Update: 13-Aug-2016
 * 
 * Contributing Source: https://www.furiouspaul.com/overwatch/ 
 * 
 * Competitor Example: http://www.mikerezl.com/overwatch/
 * */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OverWatchClassSuggestor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static FormOverWatchClassSuggestor formOverWatchClassSuggestor = new FormOverWatchClassSuggestor();
        [STAThread]
        static void Main()
        {
            // Testing            
            //OverWatchClasses.enemyTeam[0] = OverWatchClasses.genji;
            //OverWatchClasses.enemyTeam[1] = OverWatchClasses.mei;
            //OverWatchClasses.enemyTeam[2] = OverWatchClasses.genji;
            //OverWatchClasses.enemyTeam[3] = OverWatchClasses.genji;
            //OverWatchClasses.enemyTeam[4] = OverWatchClasses.genji;
            //OverWatchClasses.enemyTeam[5] = OverWatchClasses.genji;

            //OverWatchClasses.refresh();

            Application.EnableVisualStyles();            
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(formOverWatchClassSuggestor);

        }

    }


    public static class OverWatchClasses
    {

          //  public OverWatchClasses()
          //  {
            //    ;
            //}


        // Variable Contstant for character names and groupings

        // Enemy team Character selection
        //string[] enemyTeam = new string[6]; // {"test","","","","",""};

        // Initialize enemyTeam
        public static string[] enemyTeam = new string[6] {" ", " ", " ", " ", " ", " " };

        // Do not add anything to an already filled enemy slot, otherwise add to 1st available slot.
        public static void addEnemy(string enemy)
        {
            for(int i=0; i < 6; i++)
            {
                Console.WriteLine(i);
                if (enemyTeam[i] == " ")
                {                    
                    enemyTeam[i] = enemy;
                    Program.formOverWatchClassSuggestor.setButtonEnemy(i,enemy);
                    refresh();
                    break;
                }
            }     
        }

        // Index refers to enemy button number
        public static void removeEnemy(int i)
        {
            enemyTeam[i-1] = " "; // testing
            Program.formOverWatchClassSuggestor.clearButtonEnemy(i);
            refresh();
        }

        // reset enemy team. Fresh start.
        public static void clearEnemyTeam()
        {
            enemyTeam = new string[6] { " ", " ", " ", " ", " ", " " };

            //for (int i = 0; i < 6; i++ )
             Program.formOverWatchClassSuggestor.clearAllButtonEnemy();
             Program.formOverWatchClassSuggestor.clearAllLabelEnemy();
             refresh();
             Program.formOverWatchClassSuggestor.RefreshRecommendations();
             
        }

        private static void refresh()
        {
            // Check if enemyTeam is full and cancel if it is
            /*
            for (int i=0; i<6; i++)
            {

                if (enemyTeam[i].CompareTo(" ") != 0)
                {
                    break; // break out of loop
                }

                return;
            }*/

            // Reset Character/Object Recommendations
            classDoomfist.setRecommendation(enemyTeam);
            classGenji.setRecommendation(enemyTeam);
            classMcCree.setRecommendation(enemyTeam);
            classPharah.setRecommendation(enemyTeam);
            classReaper.setRecommendation(enemyTeam);
            classSoldier76.setRecommendation(enemyTeam);
            classTracer.setRecommendation(enemyTeam);
            classBastion.setRecommendation(enemyTeam);
            classHanzo.setRecommendation(enemyTeam);
            classJunkrat.setRecommendation(enemyTeam);
            classMei.setRecommendation(enemyTeam);
            classTorbjorn.setRecommendation(enemyTeam);
            classWidowMaker.setRecommendation(enemyTeam);
            classDva.setRecommendation(enemyTeam);
            classReinhardt.setRecommendation(enemyTeam);
            classRoadhog.setRecommendation(enemyTeam);
            classWinston.setRecommendation(enemyTeam);
            classZarya.setRecommendation(enemyTeam);
            classAna.setRecommendation(enemyTeam);
            classLucio.setRecommendation(enemyTeam);
            classMercy.setRecommendation(enemyTeam);
            classSymmetra.setRecommendation(enemyTeam);
            classZenyatta.setRecommendation(enemyTeam);

            // Testing
            /*
            Console.WriteLine(enemyTeam[0]);
            Console.WriteLine(enemyTeam[1]);
            Console.WriteLine(enemyTeam[2]);
            Console.WriteLine(enemyTeam[3]);
            Console.WriteLine(enemyTeam[4]);
            Console.WriteLine(enemyTeam[5]);

            Console.WriteLine(genji + ": " + classGenji.getRecommendation());
            Console.WriteLine(mcCree + ": " + classMcCree.getRecommendation());
            Console.WriteLine(pharah + ": " + classPharah.getRecommendation());
            Console.WriteLine(reaper + ": " + classReaper.getRecommendation());
            Console.WriteLine(soldier76 + ": " + classSoldier76.getRecommendation());
            Console.WriteLine(tracer + ": " + classTracer.getRecommendation());
            Console.WriteLine(bastion + ": " + classBastion.getRecommendation());
            Console.WriteLine(hanzo + ": " + classHanzo.getRecommendation());
            Console.WriteLine(junkrat + ": " + classJunkrat.getRecommendation());
            Console.WriteLine(mei + ": " + classMei.getRecommendation());
            Console.WriteLine(torbjorn + ": " + classTorbjorn.getRecommendation());
            Console.WriteLine(widowMaker + ": " + classWidowMaker.getRecommendation());
            Console.WriteLine(dva + ": " + classDva.getRecommendation());
            Console.WriteLine(reinhardt + ": " + classReinhardt.getRecommendation());
            Console.WriteLine(roadhog + ": " + classRoadhog.getRecommendation());
            Console.WriteLine(winston + ": " + classWinston.getRecommendation());
            Console.WriteLine(zarya + ": " + classZarya.getRecommendation());
            Console.WriteLine(ana + ": " + classAna.getRecommendation());
            Console.WriteLine(lucio + ": " + classLucio.getRecommendation());
            Console.WriteLine(mercy + ": " + classMercy.getRecommendation());
            Console.WriteLine(symmetra + ": " + classSymmetra.getRecommendation());
            Console.WriteLine(zenyatta + ": " + classZenyatta.getRecommendation());
             * */
        }


        public const string offense = "Offense";
        public const string doomfist = "Doomfist";
        public const string genji = "Genji";
        public const string mcCree = "McCree";
        public const string pharah = "Pharah";
        public const string reaper = "Reaper";
        public const string soldier76 = "Soldier76";
        public const string sombra = "Sombra";
        public const string tracer = "Tracer";

        public const string defense = "Defense";
        public const string bastion = "Bastion";
        public const string hanzo = "Hanzo";
        public const string junkrat = "Junkrat";
        public const string mei = "Mei";
        public const string torbjorn = "Torbjorn";
        public const string widowMaker = "Widowmaker";

        public const string tank = "Tank";
        public const string dva = "Dva"; // Should be D.va // Needs "D.va" is not a valid variable name for a button
        public const string orisa = "Orisa";
        public const string reinhardt = "Reinhardt";
        public const string roadhog = "Roadhog";
        public const string winston = "Winston";
        public const string zarya = "Zarya";

        public const string support = "Support";
        public const string ana = "Ana";
        public const string lucio = "Lucio";
        public const string mercy = "Mercy";
        public const string symmetra = "Symmetra";
        public const string zenyatta = "Zenyatta";

        // Instantiat Offense Objects/Characters to see/select
        public static Character classDoomfist = new Character(doomfist, offense,
            new string[] {  }, // Strong Against
            new string[] {  }, // Weak Against
            new string[] {  } // Neutral
            );

        public static Character classGenji = new Character(genji, offense,
            new string[] { widowMaker, bastion, ana, mercy, hanzo}, // Strong Against
            new string[] { pharah, symmetra, mei, tracer, zarya, lucio, winston, dva, torbjorn}, // Weak Against
            new string[] { mcCree, reaper, soldier76, roadhog, zenyatta, reinhardt, junkrat, genji } // Neutral
            );

        public static Character classMcCree = new Character(mcCree, offense,
            new string[] { reaper, reinhardt, pharah,  winston}, // Strong Against
            new string[] { bastion, widowMaker, hanzo,  zarya, torbjorn}, // Weak Against
            new string[] { genji, mei, dva,  lucio, tracer, mercy, symmetra, ana, soldier76, zenyatta, junkrat} // Neutral
            );

        public static Character classPharah = new Character(pharah, offense,
            new string[] { mei, junkrat, reaper, winston, lucio, symmetra, zarya, reinhardt}, // Strong Against
            new string[] { roadhog, widowMaker, soldier76, mcCree, bastion, genji, dva }, // Weak Against
            new string[] { hanzo, torbjorn, ana, pharah, tracer, mercy, zenyatta} // Neutral
            );

        public static Character classReaper = new Character(reaper, offense,
            new string[] { bastion, mercy,  junkrat, widowMaker, winston, symmetra, ana, mei, torbjorn}, // Strong Against
            new string[] { pharah, mcCree, lucio }, // Weak Against
            new string[] { hanzo, dva, zarya, roadhog, genji, tracer, reaper, soldier76, zenyatta, reinhardt} // Neutral
            );

        public static Character classSoldier76 = new Character(soldier76, offense,
            new string[] { pharah, tracer, mercy, zenyatta, roadhog }, // Strong Against
            new string[] { bastion, reinhardt, zarya }, // Weak Against
            new string[] { mcCree, ana, hanzo,  widowMaker, mei, genji, lucio, torbjorn, junkrat, symmetra, winston, dva, reaper, soldier76 } // Neutral
            );

        public static Character classSombra = new Character(sombra, offense,
            new string[] { }, // Strong Against
            new string[] { }, // Weak Against
            new string[] { } // Neutral
            );

        public static Character classTracer = new Character(tracer, offense,
            new string[] { ana, bastion, mercy, widowMaker, torbjorn, reinhardt, genji, zenyatta, hanzo }, // Strong Against
            new string[] { mei, soldier76, junkrat, pharah, reaper, roadhog, winston }, // Weak Against
            new string[] { mcCree, lucio, symmetra, zarya, dva, tracer} // Neutral
            );

        
        // Instantiate Defense Objects/Characters to see/select
        public static Character classBastion = new Character(bastion, defense,
            new string[] { mcCree, soldier76, mercy, zarya, pharah, winston }, // Strong Against
            new string[] { tracer, ana, reaper, symmetra, genji, junkrat, hanzo, widowMaker, mei, dva, zenyatta }, // Weak Against
            new string[] { torbjorn, roadhog, reinhardt, bastion, lucio} // Neutral
            );

        public static Character classHanzo = new Character(hanzo, defense,
            new string[] { bastion, zenyatta, mercy, torbjorn, ana, roadhog}, // Strong Against
            new string[] { reinhardt, winston, genji, tracer, widowMaker  }, // Weak Against
            new string[] { reaper,  pharah, mcCree, mei, soldier76, junkrat, lucio, symmetra, hanzo, zarya, dva} // Neutral
            );

        public static Character classJunkrat = new Character(junkrat, defense,
            new string[] { bastion, mei, roadhog, tracer, reinhardt, torbjorn, symmetra, dva }, // Strong Against
            new string[] { pharah, reaper,  widowMaker, mercy, soldier76 }, // Weak Against
            new string[] { zenyatta, genji, ana, winston, junkrat, lucio, hanzo, zarya, mcCree } // Neutral
            );

        public static Character classMei = new Character(mei, defense,
            new string[] { genji, tracer, dva, winston, bastion, roadhog }, // Strong Against
            new string[] { reaper, junkrat, pharah, zarya, widowMaker, mercy, lucio }, // Weak Against
            new string[] { ana, soldier76, mcCree, mei, hanzo, torbjorn, reinhardt, zenyatta, symmetra } // Neutral
            );

        public static Character classTorbjorn = new Character(torbjorn, defense,
            new string[] { mcCree, roadhog, genji, zenyatta, symmetra }, // Strong Against
            new string[] { reaper, tracer, dva, hanzo, junkrat, winston, reinhardt }, // Weak Against
            new string[] { ana, pharah, bastion, lucio, mercy, soldier76, zarya, widowMaker, torbjorn, mei } // Neutral
            );

        public static Character classWidowMaker = new Character(widowMaker, defense,
            new string[] { zenyatta, ana, pharah, hanzo, mcCree, mercy, junkrat, bastion, mei, zarya }, // Strong Against
            new string[] { tracer, reaper, genji, winston }, // Weak Against
            new string[] { lucio, roadhog, symmetra, dva, reinhardt, soldier76, widowMaker, torbjorn } // Neutral
            );

        // Instantiate Tank Objects/Characters to see/select
        public static Character classDva = new Character(dva, tank,
            new string[] { widowMaker, bastion, torbjorn, genji, mercy, pharah, ana }, // Strong Against
            new string[] { zenyatta, mei, zarya, roadhog, junkrat }, // Weak Against
            new string[] { winston, mcCree, reinhardt, reaper, soldier76, lucio, symmetra, hanzo, dva, tracer } // Neutral
            );

        public static Character classOrisa = new Character(orisa, tank,
            new string[] { }, // Strong Against
            new string[] { }, // Weak Against
            new string[] { } // Neutral
            );

        public static Character classReinhardt = new Character(reinhardt, tank,
            new string[] { soldier76, hanzo, ana, torbjorn, widowMaker }, // Strong Against
            new string[] { pharah, mcCree, junkrat, reaper, zenyatta, symmetra, tracer }, // Weak Against
            new string[] { winston, roadhog, reinhardt, genji, bastion, dva, mei, zarya, mercy, lucio } // Neutral
            );

        public static Character classRoadhog = new Character(roadhog, tank,
            new string[] { pharah, tracer, dva, mercy }, // Strong Against
            new string[] { zenyatta, ana, hanzo, torbjorn, lucio, junkrat, soldier76, mei }, // Weak Against
            new string[] { roadhog, winston, reinhardt, bastion, zarya, genji, reaper, mcCree, widowMaker, symmetra } // Neutral
            );
        public static Character classWinston = new Character(winston, tank,
            new string[] { symmetra, hanzo, genji, widowMaker, mercy, torbjorn, tracer, ana }, // Strong Against
            new string[] { mcCree, pharah, reaper, lucio, zenyatta, mei, reinhardt, zarya, bastion }, // Weak Against
            new string[] { soldier76, winston, roadhog, junkrat, dva  } // Neutral
            );

        public static Character classZarya = new Character(zarya, tank,
            new string[] { winston, genji, mei, lucio, zenyatta, soldier76, dva, symmetra, mcCree }, // Strong Against
            new string[] { pharah, widowMaker, bastion, mercy }, // Weak Against
            new string[] { junkrat, torbjorn, reinhardt, tracer, roadhog, reaper, hanzo, ana, zarya } // Neutral
            );


        // Instantiate Support Objects/Characters to see/select
        public static Character classAna = new Character(ana, support,
            new string[] { zenyatta, bastion, lucio, roadhog, mercy }, // Strong Against
            new string[] { winston, tracer, genji, reinhardt, widowMaker, hanzo, dva, reaper }, // Weak Against
            new string[] { mei, torbjorn, pharah, mcCree, junkrat, zarya, soldier76, symmetra, ana } // Neutral
            );

        public static Character classLucio = new Character(lucio, support,
            new string[] { reaper, winston, genji, mei, roadhog }, // Strong Against
            new string[] { pharah, zarya, ana }, // Weak Against
            new string[] { mercy, soldier76, mcCree, tracer, junkrat, bastion, widowMaker, dva, hanzo, lucio, torbjorn, reinhardt, zenyatta, symmetra  } // Neutral
            );

        public static Character classMercy = new Character(mercy, support,
            new string[] { junkrat, zarya, mei }, // Strong Against
            new string[] { tracer, reaper, ana, widowMaker, roadhog, soldier76, genji, winston, dva, bastion, hanzo }, // Weak Against
            new string[] { lucio, mercy, pharah, torbjorn, reinhardt, mcCree,  symmetra, zenyatta } // Neutral
            );

        public static Character classSymmetra = new Character(symmetra, support,
            new string[] { bastion, reinhardt, genji }, // Strong Against
            new string[] { pharah, junkrat, reaper, winston, zarya, roadhog, torbjorn }, // Weak Against
            new string[] { mcCree, soldier76, hanzo, widowMaker, lucio, ana, mei, symmetra, tracer, mercy, dva, zenyatta } // Neutral
            );

        public static Character classZenyatta = new Character(zenyatta, support,
            new string[] { roadhog, dva, reinhardt, winston }, // Strong Against
            new string[] { widowMaker, ana, hanzo, zarya, torbjorn, tracer, soldier76 }, // Weak Against
            new string[] { mei, genji, zenyatta, mcCree, reaper, mercy, bastion, pharah, junkrat, lucio, symmetra } // Neutral
            );
    
    }

}
