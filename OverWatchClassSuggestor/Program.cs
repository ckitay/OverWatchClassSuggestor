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
 * Contributing Source (In order, if character not available, next source was used): 
 * Some modifications applied ( E.g McCree not weak against phara)
 * https://rankedboost.com/overwatch/counters/
 * http://www.metabomb.net/overwatch/gameplay-guides/overwatch-counters-guide-june-2016
 * http://www.dbltap.com/posts/5239602-4-best-heroes-to-combo-with-doomfist
 * 
 * 
 * Previous Contributing Source: https://www.furiouspaul.com/overwatch/ 
 * 
 * Competitor Example: http://www.mikerezl.com/overwatch/
 * */


using System;
using System.Collections;
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
            OverWatchClasses.classDoomfist.addStrongAgainst("Reinhardt");
            OverWatchClasses.classDoomfist.addStrongAgainst("Dva");
            OverWatchClasses.classDoomfist.addStrongAgainst("Torbjorn");
            OverWatchClasses.classDoomfist.addStrongAgainst("Winston");
            OverWatchClasses.classGenji.addStrongAgainst("Bastion");
            OverWatchClasses.classGenji.addStrongAgainst("Ana");
            OverWatchClasses.classGenji.addStrongAgainst("Widowmaker");
            OverWatchClasses.classMcCree.addStrongAgainst("Pharah");
            OverWatchClasses.classMcCree.addStrongAgainst("Reaper");
            OverWatchClasses.classMcCree.addStrongAgainst("Reinhardt");
            OverWatchClasses.classPharah.addStrongAgainst("Mei");
            OverWatchClasses.classPharah.addStrongAgainst("Junkrat");
            OverWatchClasses.classPharah.addStrongAgainst("Reaper");
            OverWatchClasses.classReaper.addStrongAgainst("Bastion");
            OverWatchClasses.classReaper.addStrongAgainst("Mercy");
            OverWatchClasses.classReaper.addStrongAgainst("Junkrat");
            OverWatchClasses.classReaper.addStrongAgainst("Ana");
            OverWatchClasses.classSoldier76.addStrongAgainst("Pharah");
            OverWatchClasses.classSoldier76.addStrongAgainst("Tracer");
            OverWatchClasses.classSoldier76.addStrongAgainst("Mercy");
            OverWatchClasses.classSombra.addStrongAgainst("Bastion");
            OverWatchClasses.classSombra.addStrongAgainst("Lucio");
            OverWatchClasses.classSombra.addStrongAgainst("Doomfist");
            OverWatchClasses.classSombra.addStrongAgainst("Reinhardt");
            OverWatchClasses.classTracer.addStrongAgainst("Ana");
            OverWatchClasses.classTracer.addStrongAgainst("Bastion");
            OverWatchClasses.classTracer.addStrongAgainst("Mercy");
            OverWatchClasses.classBastion.addStrongAgainst("McCree");
            OverWatchClasses.classBastion.addStrongAgainst("Soldier76");
            OverWatchClasses.classBastion.addStrongAgainst("Mercy");
            OverWatchClasses.classBastion.addStrongAgainst("Winston");
            OverWatchClasses.classHanzo.addStrongAgainst("Bastion");
            OverWatchClasses.classHanzo.addStrongAgainst("Zenyatta");
            OverWatchClasses.classHanzo.addStrongAgainst("Mercy");
            OverWatchClasses.classJunkrat.addStrongAgainst("Bastion");
            OverWatchClasses.classJunkrat.addStrongAgainst("Symmetra");
            OverWatchClasses.classJunkrat.addStrongAgainst("Torbjorn");
            OverWatchClasses.classJunkrat.addStrongAgainst("");
            OverWatchClasses.classMei.addStrongAgainst("Genji");
            OverWatchClasses.classMei.addStrongAgainst("Tracer");
            OverWatchClasses.classMei.addStrongAgainst("Dva");
            OverWatchClasses.classTorbjorn.addStrongAgainst("McCree");
            OverWatchClasses.classTorbjorn.addStrongAgainst("Roadhog");
            OverWatchClasses.classTorbjorn.addStrongAgainst("Genji");
            OverWatchClasses.classWidowMaker.addStrongAgainst("Zenyatta");
            OverWatchClasses.classWidowMaker.addStrongAgainst("Ana");
            OverWatchClasses.classWidowMaker.addStrongAgainst("Pharah");
            OverWatchClasses.classWidowMaker.addStrongAgainst("");
            OverWatchClasses.classWidowMaker.addStrongAgainst("");
            OverWatchClasses.classWidowMaker.addStrongAgainst("");
            OverWatchClasses.classDva.addStrongAgainst("Widowmaker");
            OverWatchClasses.classDva.addStrongAgainst("Bastion");
            OverWatchClasses.classDva.addStrongAgainst("Torbjorn");
            OverWatchClasses.classDva.addStrongAgainst("Genji");
            OverWatchClasses.classOrisa.addStrongAgainst("Winston");
            OverWatchClasses.classOrisa.addStrongAgainst("Reinhardt");
            OverWatchClasses.classOrisa.addStrongAgainst("Lucio");
            OverWatchClasses.classOrisa.addStrongAgainst("Torbjorn");
            OverWatchClasses.classReinhardt.addStrongAgainst("Soldier76");
            OverWatchClasses.classReinhardt.addStrongAgainst("Ana");
            OverWatchClasses.classReinhardt.addStrongAgainst("Torbjorn");
            OverWatchClasses.classReinhardt.addStrongAgainst("");
            OverWatchClasses.classReinhardt.addStrongAgainst("");
            OverWatchClasses.classReinhardt.addStrongAgainst("");
            OverWatchClasses.classReinhardt.addStrongAgainst("");
            OverWatchClasses.classRoadhog.addStrongAgainst("Pharah");
            OverWatchClasses.classRoadhog.addStrongAgainst("Dva");
            OverWatchClasses.classRoadhog.addStrongAgainst("Mercy");
            OverWatchClasses.classWinston.addStrongAgainst("Symmetra");
            OverWatchClasses.classWinston.addStrongAgainst("Hanzo");
            OverWatchClasses.classWinston.addStrongAgainst("Genji");
            OverWatchClasses.classWinston.addStrongAgainst("");
            OverWatchClasses.classZarya.addStrongAgainst("Winston");
            OverWatchClasses.classZarya.addStrongAgainst("Dva");
            OverWatchClasses.classZarya.addStrongAgainst("Lucio");
            OverWatchClasses.classZarya.addStrongAgainst("");
            OverWatchClasses.classZarya.addStrongAgainst("");
            OverWatchClasses.classZarya.addStrongAgainst("");
            OverWatchClasses.classZarya.addStrongAgainst("");
            OverWatchClasses.classAna.addStrongAgainst("Zenyatta");
            OverWatchClasses.classAna.addStrongAgainst("Bastion");
            OverWatchClasses.classAna.addStrongAgainst("Lucio");
            OverWatchClasses.classAna.addStrongAgainst("Mercy");
            OverWatchClasses.classLucio.addStrongAgainst("Reaper");
            OverWatchClasses.classLucio.addStrongAgainst("Genji");
            OverWatchClasses.classLucio.addStrongAgainst("Roadhog");
            OverWatchClasses.classLucio.addStrongAgainst("");
            OverWatchClasses.classLucio.addStrongAgainst("");
            OverWatchClasses.classLucio.addStrongAgainst("");
            OverWatchClasses.classLucio.addStrongAgainst("");
            OverWatchClasses.classMercy.addStrongAgainst("Junkrat");
            OverWatchClasses.classMercy.addStrongAgainst("");
            OverWatchClasses.classMercy.addStrongAgainst("");
            OverWatchClasses.classMercy.addStrongAgainst("");
            OverWatchClasses.classSymmetra.addStrongAgainst("Bastion");
            OverWatchClasses.classSymmetra.addStrongAgainst("Reinhardt");
            OverWatchClasses.classSymmetra.addStrongAgainst("Genji");
            OverWatchClasses.classZenyatta.addStrongAgainst("Roadhog");
            OverWatchClasses.classZenyatta.addStrongAgainst("Dva");
            OverWatchClasses.classZenyatta.addStrongAgainst("");
            OverWatchClasses.classZenyatta.addStrongAgainst("");

            OverWatchClasses.classDoomfist.addWeakAgainst("Sombra");
            OverWatchClasses.classDoomfist.addWeakAgainst("McCree");
            OverWatchClasses.classDoomfist.addWeakAgainst("Mei");
            OverWatchClasses.classDoomfist.addWeakAgainst("Orisa");
            OverWatchClasses.classGenji.addWeakAgainst("");
            OverWatchClasses.classGenji.addWeakAgainst("");
            OverWatchClasses.classGenji.addWeakAgainst("");
            OverWatchClasses.classMcCree.addWeakAgainst("");
            OverWatchClasses.classMcCree.addWeakAgainst("");
            OverWatchClasses.classMcCree.addWeakAgainst("");
            OverWatchClasses.classPharah.addWeakAgainst("");
            OverWatchClasses.classPharah.addWeakAgainst("");
            OverWatchClasses.classPharah.addWeakAgainst("");
            OverWatchClasses.classReaper.addWeakAgainst("");
            OverWatchClasses.classReaper.addWeakAgainst("");
            OverWatchClasses.classReaper.addWeakAgainst("");
            OverWatchClasses.classSoldier76.addWeakAgainst("");
            OverWatchClasses.classSoldier76.addWeakAgainst("");
            OverWatchClasses.classSoldier76.addWeakAgainst("");
            OverWatchClasses.classSombra.addWeakAgainst("Symmetra");
            OverWatchClasses.classSombra.addWeakAgainst("Mei");
            OverWatchClasses.classSombra.addWeakAgainst("Winston");
            OverWatchClasses.classSombra.addWeakAgainst("Roadhog");
            OverWatchClasses.classTracer.addWeakAgainst("Pharah");
            OverWatchClasses.classTracer.addWeakAgainst("");
            OverWatchClasses.classTracer.addWeakAgainst("");
            OverWatchClasses.classBastion.addWeakAgainst("");
            OverWatchClasses.classBastion.addWeakAgainst("");
            OverWatchClasses.classBastion.addWeakAgainst("");

            OverWatchClasses.classHanzo.addWeakAgainst("Reinhardt");
            OverWatchClasses.classHanzo.addWeakAgainst("Tracer");
            OverWatchClasses.classHanzo.addWeakAgainst("");
            OverWatchClasses.classJunkrat.addWeakAgainst("");
            OverWatchClasses.classJunkrat.addWeakAgainst("");
            OverWatchClasses.classJunkrat.addWeakAgainst("");
            OverWatchClasses.classJunkrat.addWeakAgainst("");
            OverWatchClasses.classMei.addWeakAgainst("Junkrat");
            OverWatchClasses.classMei.addWeakAgainst("Reaper");
            OverWatchClasses.classMei.addWeakAgainst("");
            OverWatchClasses.classTorbjorn.addWeakAgainst("");
            OverWatchClasses.classTorbjorn.addWeakAgainst("");
            OverWatchClasses.classTorbjorn.addWeakAgainst("");
            OverWatchClasses.classWidowMaker.addWeakAgainst("");
            OverWatchClasses.classWidowMaker.addWeakAgainst("");
            OverWatchClasses.classWidowMaker.addWeakAgainst("");
            OverWatchClasses.classWidowMaker.addWeakAgainst("");
            OverWatchClasses.classWidowMaker.addWeakAgainst("");
            OverWatchClasses.classWidowMaker.addWeakAgainst("");
            OverWatchClasses.classDva.addWeakAgainst("");
            OverWatchClasses.classDva.addWeakAgainst("");
            OverWatchClasses.classDva.addWeakAgainst("");
            OverWatchClasses.classDva.addWeakAgainst("");
            OverWatchClasses.classOrisa.addWeakAgainst("Genji");
            OverWatchClasses.classOrisa.addWeakAgainst("Tracer");
            OverWatchClasses.classOrisa.addWeakAgainst("Reaper");
            OverWatchClasses.classOrisa.addWeakAgainst("Sombra");
            OverWatchClasses.classReinhardt.addWeakAgainst("");
            OverWatchClasses.classReinhardt.addWeakAgainst("");
            OverWatchClasses.classReinhardt.addWeakAgainst("");
            OverWatchClasses.classReinhardt.addWeakAgainst("");
            OverWatchClasses.classReinhardt.addWeakAgainst("");
            OverWatchClasses.classReinhardt.addWeakAgainst("");
            OverWatchClasses.classReinhardt.addWeakAgainst("");
            OverWatchClasses.classRoadhog.addWeakAgainst("");
            OverWatchClasses.classRoadhog.addWeakAgainst("");
            OverWatchClasses.classRoadhog.addWeakAgainst("");
            OverWatchClasses.classWinston.addWeakAgainst("");
            OverWatchClasses.classWinston.addWeakAgainst("");
            OverWatchClasses.classWinston.addWeakAgainst("");
            OverWatchClasses.classWinston.addWeakAgainst("");
            OverWatchClasses.classZarya.addWeakAgainst("Pharah");
            OverWatchClasses.classZarya.addWeakAgainst("Widowmaker");
            OverWatchClasses.classZarya.addWeakAgainst("");
            OverWatchClasses.classZarya.addWeakAgainst("");
            OverWatchClasses.classZarya.addWeakAgainst("");
            OverWatchClasses.classZarya.addWeakAgainst("");
            OverWatchClasses.classZarya.addWeakAgainst("");
            OverWatchClasses.classAna.addWeakAgainst("Winston");
            OverWatchClasses.classAna.addWeakAgainst("Tracer");
            OverWatchClasses.classAna.addWeakAgainst("Genji");
            OverWatchClasses.classAna.addWeakAgainst("");
            OverWatchClasses.classLucio.addWeakAgainst("");
            OverWatchClasses.classLucio.addWeakAgainst("");
            OverWatchClasses.classLucio.addWeakAgainst("");
            OverWatchClasses.classLucio.addWeakAgainst("");
            OverWatchClasses.classLucio.addWeakAgainst("");
            OverWatchClasses.classLucio.addWeakAgainst("");
            OverWatchClasses.classLucio.addWeakAgainst("");
            OverWatchClasses.classMercy.addWeakAgainst("");
            OverWatchClasses.classMercy.addWeakAgainst("");
            OverWatchClasses.classMercy.addWeakAgainst("");
            OverWatchClasses.classMercy.addWeakAgainst("");
            OverWatchClasses.classSymmetra.addWeakAgainst("Pharah");
            OverWatchClasses.classSymmetra.addWeakAgainst("");
            OverWatchClasses.classSymmetra.addWeakAgainst("");
            OverWatchClasses.classZenyatta.addWeakAgainst("");
            OverWatchClasses.classZenyatta.addWeakAgainst("");
            OverWatchClasses.classZenyatta.addWeakAgainst("");
            OverWatchClasses.classZenyatta.addWeakAgainst("");


            OverWatchClasses.addMissingStrenthandWeakness();

            OverWatchClasses.classDoomfist.addMap("");
            OverWatchClasses.classDoomfist.addMap("");
            OverWatchClasses.classDoomfist.addMap("");
            OverWatchClasses.classDoomfist.addMap("");
            OverWatchClasses.classGenji.addMap("PayLoad/Escort Attacking");
            OverWatchClasses.classGenji.addMap("Hybrid Attacking");
            OverWatchClasses.classGenji.addMap("");
            OverWatchClasses.classMcCree.addMap("Control");
            OverWatchClasses.classMcCree.addMap("Hybrid Attacking");
            OverWatchClasses.classMcCree.addMap("");
            OverWatchClasses.classPharah.addMap("Point Capture/Assault Attacking");
            OverWatchClasses.classPharah.addMap("Control");
            OverWatchClasses.classPharah.addMap("");
            OverWatchClasses.classReaper.addMap("Point Capture/Assault Attacking");
            OverWatchClasses.classReaper.addMap("Control");
            OverWatchClasses.classReaper.addMap("");
            OverWatchClasses.classReaper.addMap("");
            OverWatchClasses.classSoldier76.addMap("PayLoad/Escort Attacking");
            OverWatchClasses.classSoldier76.addMap("Point Capture/Assault Attacking");
            OverWatchClasses.classSoldier76.addMap("Control");
            OverWatchClasses.classSombra.addMap("");
            OverWatchClasses.classSombra.addMap("");
            OverWatchClasses.classSombra.addMap("");
            OverWatchClasses.classSombra.addMap("");
            OverWatchClasses.classTracer.addMap("Control");
            OverWatchClasses.classTracer.addMap("");
            OverWatchClasses.classTracer.addMap("");
            OverWatchClasses.classBastion.addMap("PayLoad/Escort Defending");
            OverWatchClasses.classBastion.addMap("Point Capture/Assault Defending");
            OverWatchClasses.classBastion.addMap("Hybrid Defending");
            OverWatchClasses.classBastion.addMap("");
            OverWatchClasses.classHanzo.addMap("PayLoad/Escort Defending");
            OverWatchClasses.classHanzo.addMap("Control");
            OverWatchClasses.classHanzo.addMap("Hybrid Defending");
            OverWatchClasses.classJunkrat.addMap("PayLoad/Escort Defending");
            OverWatchClasses.classJunkrat.addMap("Point Capture/Assault Defending");
            OverWatchClasses.classJunkrat.addMap("Control");
            OverWatchClasses.classJunkrat.addMap("Hybrid Defending");
            OverWatchClasses.classMei.addMap("Point Capture/Assault Defending");
            OverWatchClasses.classMei.addMap("Control");
            OverWatchClasses.classMei.addMap("Hybrid Defending");
            OverWatchClasses.classTorbjorn.addMap("PayLoad/Escort Defending");
            OverWatchClasses.classTorbjorn.addMap("Point Capture/Assault Defending");
            OverWatchClasses.classTorbjorn.addMap("Hybrid Defending");
            OverWatchClasses.classWidowMaker.addMap("PayLoad/Escort Attacking");
            OverWatchClasses.classWidowMaker.addMap("PayLoad/Escort Defending");
            OverWatchClasses.classWidowMaker.addMap("Point Capture/Assault Attacking");
            OverWatchClasses.classWidowMaker.addMap("Point Capture/Assault Defending");
            OverWatchClasses.classWidowMaker.addMap("Hybrid Attacking");
            OverWatchClasses.classWidowMaker.addMap("Hybrid Defending");
            OverWatchClasses.classDva.addMap("PayLoad/Escort Attacking");
            OverWatchClasses.classDva.addMap("Point Capture/Assault Attacking");
            OverWatchClasses.classDva.addMap("Control");
            OverWatchClasses.classDva.addMap("Hybrid Attacking");
            OverWatchClasses.classOrisa.addMap("Control");
            OverWatchClasses.classOrisa.addMap("");
            OverWatchClasses.classOrisa.addMap("");
            OverWatchClasses.classOrisa.addMap("");
            OverWatchClasses.classOrisa.addMap("");
            OverWatchClasses.classReinhardt.addMap("PayLoad/Escort Attacking");
            OverWatchClasses.classReinhardt.addMap("PayLoad/Escort Defending");
            OverWatchClasses.classReinhardt.addMap("Point Capture/Assault Attacking");
            OverWatchClasses.classReinhardt.addMap("Point Capture/Assault Defending");
            OverWatchClasses.classReinhardt.addMap("Control");
            OverWatchClasses.classReinhardt.addMap("Hybrid Attacking");
            OverWatchClasses.classReinhardt.addMap("Hybrid Defending");
            OverWatchClasses.classRoadhog.addMap("Control");
            OverWatchClasses.classRoadhog.addMap("");
            OverWatchClasses.classRoadhog.addMap("");
            OverWatchClasses.classWinston.addMap("PayLoad/Escort Attacking");
            OverWatchClasses.classWinston.addMap("Point Capture/Assault Attacking");
            OverWatchClasses.classWinston.addMap("Control");
            OverWatchClasses.classWinston.addMap("Hybrid Attacking");
            OverWatchClasses.classZarya.addMap("PayLoad/Escort Attacking");
            OverWatchClasses.classZarya.addMap("PayLoad/Escort Defending");
            OverWatchClasses.classZarya.addMap("Point Capture/Assault Attacking");
            OverWatchClasses.classZarya.addMap("Point Capture/Assault Defending");
            OverWatchClasses.classZarya.addMap("Control");
            OverWatchClasses.classZarya.addMap("Hybrid Attacking");
            OverWatchClasses.classZarya.addMap("Hybrid Defending");
            OverWatchClasses.classAna.addMap("Hybrid Defending");
            OverWatchClasses.classAna.addMap("PayLoad/Escort Defending");
            OverWatchClasses.classAna.addMap("");
            OverWatchClasses.classAna.addMap("");
            OverWatchClasses.classLucio.addMap("PayLoad/Escort Attacking");
            OverWatchClasses.classLucio.addMap("PayLoad/Escort Defending");
            OverWatchClasses.classLucio.addMap("Point Capture/Assault Attacking");
            OverWatchClasses.classLucio.addMap("Point Capture/Assault Defending");
            OverWatchClasses.classLucio.addMap("Control");
            OverWatchClasses.classLucio.addMap("Hybrid Attacking");
            OverWatchClasses.classLucio.addMap("Hybrid Defending");
            OverWatchClasses.classMercy.addMap("PayLoad/Escort Defending");
            OverWatchClasses.classMercy.addMap("Point Capture/Assault Defending");
            OverWatchClasses.classMercy.addMap("Hybrid Attacking");
            OverWatchClasses.classMercy.addMap("Hybrid Defending");
            OverWatchClasses.classSymmetra.addMap("PayLoad/Escort Defending");
            OverWatchClasses.classSymmetra.addMap("Point Capture/Assault Defending");
            OverWatchClasses.classSymmetra.addMap("");
            OverWatchClasses.classZenyatta.addMap("PayLoad/Escort Defending");
            OverWatchClasses.classZenyatta.addMap("Point Capture/Assault Attacking");
            OverWatchClasses.classZenyatta.addMap("Point Capture/Assault Defending");
            OverWatchClasses.classZenyatta.addMap("Hybrid Attacking");


            

            Application.EnableVisualStyles();            
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(formOverWatchClassSuggestor);
            //OverWatchClasses.refresh();
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


        // Run only once after all addStrongAgainst and addWeakAgainst are done
        // This will look at other classes and add entries if missing (e.g. If Doomfist is weak against Orisa, then add Orisa is Strong against Doomfist if it's not already in there for Orisa)
        public static void addMissingStrenthandWeakness()
        {

            heroes.Add(classDoomfist);
            heroes.Add(classGenji);
            heroes.Add(classMcCree);
            heroes.Add(classPharah);
            heroes.Add(classReaper);
            heroes.Add(classSoldier76);
            heroes.Add(classSombra );
            heroes.Add(classTracer );
            heroes.Add(classBastion );
            heroes.Add(classHanzo );
            heroes.Add(classJunkrat );
            heroes.Add(classMei );
            heroes.Add(classTorbjorn );
            heroes.Add(classWidowMaker );
            heroes.Add(classDva);
            heroes.Add(classOrisa );
            heroes.Add(classReinhardt );
            heroes.Add(classRoadhog );
            heroes.Add(classWinston );
            heroes.Add(classZarya);
            heroes.Add(classAna);
            heroes.Add(classLucio);
            heroes.Add(classMercy);
            heroes.Add(classSymmetra);
            heroes.Add(classZenyatta);


            foreach (var hero1 in heroes)
            {       
                
                foreach (var hero2 in heroes)
                if (hero1.getWeakAgainst().Contains(hero2.getName())
                    && !hero2.getStrongAgainst().Contains(hero1.getName())
                    )
                    hero2.addStrongAgainst(hero1.getName());

                foreach (var hero2 in heroes)
                    if (hero1.getStrongAgainst().Contains(hero2.getName())
                        && !hero2.getWeakAgainst().Contains(hero1.getName())
                        )
                        hero2.addWeakAgainst(hero1.getName());

                // test - find heroes that are both weak and string (These shouldn't exist!)
                foreach (var hero2 in heroes)
                    if (hero1.getStrongAgainst().Contains(hero2.getName())
                        && hero2.getStrongAgainst().Contains(hero1.getName())
                        )
                    {
                        Console.WriteLine(hero1.getName());//hero1.addRecommendation(-100);
                        Console.WriteLine(hero2.getName()); //hero2.addRecommendation(-100);
                        Console.WriteLine(""); //hero2.addRecommendation(-100);
                    }
                        

            }
        }

        // Do not add anything to an already filled enemy slot, otherwise add to 1st available slot.
        public static void addEnemy(string enemy)
        {
            for(int i=0; i < 6; i++)
            {
                //Console.WriteLine(i);
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

        public static void setMap(string map)
        {
            currentMap = map;
            refresh();
        }

        public static void refresh()
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
            classDoomfist.setRecommendation(enemyTeam, currentMap); //classDoomfist.addRecommendation(+1);
            classGenji.setRecommendation(enemyTeam, currentMap);
            classMcCree.setRecommendation(enemyTeam, currentMap);
            classPharah.setRecommendation(enemyTeam, currentMap);
            classReaper.setRecommendation(enemyTeam, currentMap); //classReaper.addRecommendation(-1);
            classSoldier76.setRecommendation(enemyTeam, currentMap);
            classSombra.setRecommendation(enemyTeam, currentMap);
            classTracer.setRecommendation(enemyTeam, currentMap);
            classBastion.setRecommendation(enemyTeam, currentMap);
            classHanzo.setRecommendation(enemyTeam, currentMap);
            classJunkrat.setRecommendation(enemyTeam, currentMap);
            classMei.setRecommendation(enemyTeam, currentMap);
            classTorbjorn.setRecommendation(enemyTeam, currentMap);
            classWidowMaker.setRecommendation(enemyTeam, currentMap);
            classDva.setRecommendation(enemyTeam, currentMap);
            classOrisa.setRecommendation(enemyTeam, currentMap);
            classReinhardt.setRecommendation(enemyTeam, currentMap);
            classRoadhog.setRecommendation(enemyTeam, currentMap);
            classWinston.setRecommendation(enemyTeam, currentMap);
            classZarya.setRecommendation(enemyTeam, currentMap);
            classAna.setRecommendation(enemyTeam, currentMap);
            classLucio.setRecommendation(enemyTeam, currentMap); classLucio.addRecommendation(+0);
            classMercy.setRecommendation(enemyTeam, currentMap); classMercy.addRecommendation(+1); // Adding +2 for since not supporting selection of team members and because mercy is only strong against symmetra
            classSymmetra.setRecommendation(enemyTeam, currentMap); classSymmetra.addRecommendation(+0);
            classZenyatta.setRecommendation(enemyTeam, currentMap); classZenyatta.addRecommendation(+0);

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

        //public const int heroSize = 25;


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

        public static string currentMap = "";

        public static List<Character> heroes = new List<Character>();

        // Instantiat Offense Objects/Characters to see/select
        public static Character classDoomfist = new Character(doomfist, offense);   
        public static Character classGenji = new Character(genji, offense);
        public static Character classMcCree = new Character(mcCree, offense);
        public static Character classPharah = new Character(pharah, offense);
        public static Character classReaper = new Character(reaper, offense);
        public static Character classSoldier76 = new Character(soldier76, offense);
        public static Character classSombra = new Character(sombra, offense);
        public static Character classTracer = new Character(tracer, offense);
        
        // Instantiate Defense Objects/Characters to see/select
        public static Character classBastion = new Character(bastion, defense);
        public static Character classHanzo = new Character(hanzo, defense);
        public static Character classJunkrat = new Character(junkrat, defense);
        public static Character classMei = new Character(mei, defense);
        public static Character classTorbjorn = new Character(torbjorn, defense);
        public static Character classWidowMaker = new Character(widowMaker, defense);

        // Instantiate Tank Objects/Characters to see/select
        public static Character classDva = new Character(dva, tank);
        public static Character classOrisa = new Character(orisa, tank);
        public static Character classReinhardt = new Character(reinhardt, tank);
        public static Character classRoadhog = new Character(roadhog, tank);
        public static Character classWinston = new Character(winston, tank);
        public static Character classZarya = new Character(zarya, tank);


        // Instantiate Support Objects/Characters to see/select
        public static Character classAna = new Character(ana, support);
        public static Character classLucio = new Character(lucio, support);
        public static Character classMercy = new Character(mercy, support);
        public static Character classSymmetra = new Character(symmetra, support);
        public static Character classZenyatta = new Character(zenyatta, support);

    
    }

}
