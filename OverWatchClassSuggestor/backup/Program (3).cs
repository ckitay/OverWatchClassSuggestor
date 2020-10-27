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
            OverWatchClasses.classDoomfist.addStrongAgainst("");
            OverWatchClasses.classDoomfist.addStrongAgainst("–");
            OverWatchClasses.classDoomfist.addStrongAgainst("–");
            OverWatchClasses.classDoomfist.addStrongAgainst("–");
            OverWatchClasses.classDoomfist.addStrongAgainst("–");
            OverWatchClasses.classDoomfist.addStrongAgainst("–");
            OverWatchClasses.classDoomfist.addStrongAgainst("–");
            OverWatchClasses.classDoomfist.addStrongAgainst("–");
            OverWatchClasses.classGenji.addStrongAgainst("Bastion");
            OverWatchClasses.classGenji.addStrongAgainst("Mercy");
            OverWatchClasses.classGenji.addStrongAgainst("Widowmaker");
            OverWatchClasses.classGenji.addStrongAgainst("Hanzo");
            OverWatchClasses.classGenji.addStrongAgainst("Zenyatta");
            OverWatchClasses.classGenji.addStrongAgainst("Soldier76");
            OverWatchClasses.classGenji.addStrongAgainst("");
            OverWatchClasses.classMcCree.addStrongAgainst("Mercy");
            OverWatchClasses.classMcCree.addStrongAgainst("Reaper");
            OverWatchClasses.classMcCree.addStrongAgainst("Tracer");
            OverWatchClasses.classMcCree.addStrongAgainst("Zenyatta");
            OverWatchClasses.classMcCree.addStrongAgainst("Winston");
            OverWatchClasses.classMcCree.addStrongAgainst("Mei");
            OverWatchClasses.classMcCree.addStrongAgainst("–");
            OverWatchClasses.classPharah.addStrongAgainst("Junkrat");
            OverWatchClasses.classPharah.addStrongAgainst("Reaper");
            OverWatchClasses.classPharah.addStrongAgainst("Mei");
            OverWatchClasses.classPharah.addStrongAgainst("Zarya");
            OverWatchClasses.classPharah.addStrongAgainst("Reinhardt");
            OverWatchClasses.classPharah.addStrongAgainst("Torbjorn");
            OverWatchClasses.classPharah.addStrongAgainst("Bastion");
            OverWatchClasses.classPharah.addStrongAgainst("Symmetra");
            OverWatchClasses.classReaper.addStrongAgainst("Winston");
            OverWatchClasses.classReaper.addStrongAgainst("Mercy");
            OverWatchClasses.classReaper.addStrongAgainst("Zenyatta");
            OverWatchClasses.classReaper.addStrongAgainst("Roadhog");
            OverWatchClasses.classReaper.addStrongAgainst("Reinhardt");
            OverWatchClasses.classReaper.addStrongAgainst("Symmetra");
            OverWatchClasses.classReaper.addStrongAgainst("Torbjorn");
            OverWatchClasses.classReaper.addStrongAgainst("Hanzo");
            OverWatchClasses.classReaper.addStrongAgainst("Dva");
            OverWatchClasses.classSoldier76.addStrongAgainst("Torbjorn");
            OverWatchClasses.classSoldier76.addStrongAgainst("Mercy");
            OverWatchClasses.classSoldier76.addStrongAgainst("Bastion");
            OverWatchClasses.classSoldier76.addStrongAgainst("Lucio");
            OverWatchClasses.classSoldier76.addStrongAgainst("Pharah");
            OverWatchClasses.classSoldier76.addStrongAgainst("Tracer");
            OverWatchClasses.classSoldier76.addStrongAgainst("Junkrat");
            OverWatchClasses.classSoldier76.addStrongAgainst("Symmetra");
            OverWatchClasses.classSombra.addStrongAgainst("Bastion");
            OverWatchClasses.classSombra.addStrongAgainst("Lucio");
            OverWatchClasses.classSombra.addStrongAgainst("Widowmaker");
            OverWatchClasses.classSombra.addStrongAgainst("Reinhardt");
            OverWatchClasses.classSombra.addStrongAgainst("Zarya");
            OverWatchClasses.classTracer.addStrongAgainst("Widowmaker");
            OverWatchClasses.classTracer.addStrongAgainst("Mercy");
            OverWatchClasses.classTracer.addStrongAgainst("Bastion");
            OverWatchClasses.classTracer.addStrongAgainst("Hanzo");
            OverWatchClasses.classTracer.addStrongAgainst("Zenyatta");
            OverWatchClasses.classTracer.addStrongAgainst("");
            OverWatchClasses.classBastion.addStrongAgainst("Winston");
            OverWatchClasses.classBastion.addStrongAgainst("Mercy");
            OverWatchClasses.classBastion.addStrongAgainst("Reinhardt");
            OverWatchClasses.classBastion.addStrongAgainst("Lucio");
            OverWatchClasses.classBastion.addStrongAgainst("Torbjorn");
            OverWatchClasses.classBastion.addStrongAgainst("");
            OverWatchClasses.classBastion.addStrongAgainst("");
            OverWatchClasses.classBastion.addStrongAgainst("");
            OverWatchClasses.classBastion.addStrongAgainst("");
            OverWatchClasses.classHanzo.addStrongAgainst("Bastion");
            OverWatchClasses.classHanzo.addStrongAgainst("Mercy");
            OverWatchClasses.classHanzo.addStrongAgainst("Zenyatta");
            OverWatchClasses.classHanzo.addStrongAgainst("Torbjorn");
            OverWatchClasses.classHanzo.addStrongAgainst("Junkrat");
            OverWatchClasses.classHanzo.addStrongAgainst("");
            OverWatchClasses.classHanzo.addStrongAgainst("");
            OverWatchClasses.classJunkrat.addStrongAgainst("Bastion");
            OverWatchClasses.classJunkrat.addStrongAgainst("Mercy");
            OverWatchClasses.classJunkrat.addStrongAgainst("Zenyatta");
            OverWatchClasses.classJunkrat.addStrongAgainst("Torbjorn");
            OverWatchClasses.classJunkrat.addStrongAgainst("Reinhardt");
            OverWatchClasses.classJunkrat.addStrongAgainst("Dva");
            OverWatchClasses.classMei.addStrongAgainst("Genji");
            OverWatchClasses.classMei.addStrongAgainst("Dva");
            OverWatchClasses.classMei.addStrongAgainst("Lucio");
            OverWatchClasses.classMei.addStrongAgainst("Reinhardt");
            OverWatchClasses.classMei.addStrongAgainst("Winston");
            OverWatchClasses.classMei.addStrongAgainst("Mercy");
            OverWatchClasses.classTorbjorn.addStrongAgainst("Zenyatta");
            OverWatchClasses.classTorbjorn.addStrongAgainst("Lucio");
            OverWatchClasses.classTorbjorn.addStrongAgainst("Mercy");
            OverWatchClasses.classTorbjorn.addStrongAgainst("Tracer");
            OverWatchClasses.classTorbjorn.addStrongAgainst("Winston");
            OverWatchClasses.classTorbjorn.addStrongAgainst("");
            OverWatchClasses.classTorbjorn.addStrongAgainst("");
            OverWatchClasses.classWidowMaker.addStrongAgainst("Zenyatta");
            OverWatchClasses.classWidowMaker.addStrongAgainst("Bastion");
            OverWatchClasses.classWidowMaker.addStrongAgainst("Mercy");
            OverWatchClasses.classWidowMaker.addStrongAgainst("Torbjorn");
            OverWatchClasses.classWidowMaker.addStrongAgainst("Pharah");
            OverWatchClasses.classWidowMaker.addStrongAgainst("Hanzo");
            OverWatchClasses.classWidowMaker.addStrongAgainst("McCree");
            OverWatchClasses.classWidowMaker.addStrongAgainst("Junkrat");
            OverWatchClasses.classDva.addStrongAgainst("Widowmaker");
            OverWatchClasses.classDva.addStrongAgainst("Torbjorn");
            OverWatchClasses.classDva.addStrongAgainst("Hanzo");
            OverWatchClasses.classDva.addStrongAgainst("Winston");
            OverWatchClasses.classDva.addStrongAgainst("");
            OverWatchClasses.classDva.addStrongAgainst("");
            OverWatchClasses.classDva.addStrongAgainst("");
            OverWatchClasses.classOrisa.addStrongAgainst("Winston");
            OverWatchClasses.classOrisa.addStrongAgainst("Reinhardt");
            OverWatchClasses.classOrisa.addStrongAgainst("Lucio");
            OverWatchClasses.classOrisa.addStrongAgainst("Torbjorn");
            OverWatchClasses.classOrisa.addStrongAgainst("Mercy");
            OverWatchClasses.classOrisa.addStrongAgainst("Zenyatta");
            OverWatchClasses.classOrisa.addStrongAgainst("");
            OverWatchClasses.classReinhardt.addStrongAgainst("Soldier76");
            OverWatchClasses.classReinhardt.addStrongAgainst("Mercy");
            OverWatchClasses.classReinhardt.addStrongAgainst("Torbjorn");
            OverWatchClasses.classReinhardt.addStrongAgainst("Widowmaker");
            OverWatchClasses.classReinhardt.addStrongAgainst("Hanzo");
            OverWatchClasses.classReinhardt.addStrongAgainst("Dva");
            OverWatchClasses.classReinhardt.addStrongAgainst("Genji");
            OverWatchClasses.classRoadhog.addStrongAgainst("Winston");
            OverWatchClasses.classRoadhog.addStrongAgainst("Mercy");
            OverWatchClasses.classRoadhog.addStrongAgainst("Bastion");
            OverWatchClasses.classRoadhog.addStrongAgainst("Lucio");
            OverWatchClasses.classRoadhog.addStrongAgainst("Pharah");
            OverWatchClasses.classRoadhog.addStrongAgainst("Tracer");
            OverWatchClasses.classRoadhog.addStrongAgainst("Genji");
            OverWatchClasses.classRoadhog.addStrongAgainst("Soldier76");
            OverWatchClasses.classWinston.addStrongAgainst("Genji");
            OverWatchClasses.classWinston.addStrongAgainst("Zenyatta");
            OverWatchClasses.classWinston.addStrongAgainst("Widowmaker");
            OverWatchClasses.classWinston.addStrongAgainst("Symmetra");
            OverWatchClasses.classWinston.addStrongAgainst("Hanzo");
            OverWatchClasses.classWinston.addStrongAgainst("Tracer");
            OverWatchClasses.classWinston.addStrongAgainst("");
            OverWatchClasses.classZarya.addStrongAgainst("Genji");
            OverWatchClasses.classZarya.addStrongAgainst("Zenyatta");
            OverWatchClasses.classZarya.addStrongAgainst("Torbjorn");
            OverWatchClasses.classZarya.addStrongAgainst("Symmetra");
            OverWatchClasses.classZarya.addStrongAgainst("Dva");
            OverWatchClasses.classZarya.addStrongAgainst("Winston");
            OverWatchClasses.classZarya.addStrongAgainst("");
            OverWatchClasses.classAna.addStrongAgainst("Mercy");
            OverWatchClasses.classAna.addStrongAgainst("Lucio");
            OverWatchClasses.classAna.addStrongAgainst("Zenyatta");
            OverWatchClasses.classAna.addStrongAgainst("McCree");
            OverWatchClasses.classAna.addStrongAgainst("Soldier76");
            OverWatchClasses.classLucio.addStrongAgainst("Mercy");
            OverWatchClasses.classLucio.addStrongAgainst("Zarya");
            OverWatchClasses.classLucio.addStrongAgainst("Zenyatta");
            OverWatchClasses.classLucio.addStrongAgainst("Reinhardt");
            OverWatchClasses.classLucio.addStrongAgainst("");
            OverWatchClasses.classLucio.addStrongAgainst("");
            OverWatchClasses.classLucio.addStrongAgainst("");
            OverWatchClasses.classMercy.addStrongAgainst("Symmetra");
            OverWatchClasses.classMercy.addStrongAgainst("");
            OverWatchClasses.classMercy.addStrongAgainst("");
            OverWatchClasses.classMercy.addStrongAgainst("");
            OverWatchClasses.classMercy.addStrongAgainst("");
            OverWatchClasses.classMercy.addStrongAgainst("");
            OverWatchClasses.classSymmetra.addStrongAgainst("Genji");
            OverWatchClasses.classSymmetra.addStrongAgainst("Reinhardt");
            OverWatchClasses.classSymmetra.addStrongAgainst("Mercy");
            OverWatchClasses.classSymmetra.addStrongAgainst("");
            OverWatchClasses.classSymmetra.addStrongAgainst("");
            OverWatchClasses.classSymmetra.addStrongAgainst("");
            OverWatchClasses.classSymmetra.addStrongAgainst("");
            OverWatchClasses.classSymmetra.addStrongAgainst("");
            OverWatchClasses.classZenyatta.addStrongAgainst("Mercy");
            OverWatchClasses.classZenyatta.addStrongAgainst("Lucio");
            OverWatchClasses.classZenyatta.addStrongAgainst("Symmetra");
            OverWatchClasses.classZenyatta.addStrongAgainst("");
            OverWatchClasses.classZenyatta.addStrongAgainst("");
            OverWatchClasses.classZenyatta.addStrongAgainst("");
            OverWatchClasses.classZenyatta.addStrongAgainst("");
            OverWatchClasses.classZenyatta.addStrongAgainst("");
            OverWatchClasses.classZenyatta.addStrongAgainst("");
            OverWatchClasses.classZenyatta.addStrongAgainst("");

            OverWatchClasses.classDoomfist.addWeakAgainst("");
            OverWatchClasses.classDoomfist.addWeakAgainst("Orisa");
            OverWatchClasses.classDoomfist.addWeakAgainst("Sombra");
            OverWatchClasses.classDoomfist.addWeakAgainst("McCree");
            OverWatchClasses.classDoomfist.addWeakAgainst("Widowmaker");
            OverWatchClasses.classDoomfist.addWeakAgainst("Pharah");
            OverWatchClasses.classDoomfist.addWeakAgainst("Mei");
            OverWatchClasses.classDoomfist.addWeakAgainst("Reaper");
            OverWatchClasses.classGenji.addWeakAgainst("Zarya");
            OverWatchClasses.classGenji.addWeakAgainst("Mei");
            OverWatchClasses.classGenji.addWeakAgainst("Winston");
            OverWatchClasses.classGenji.addWeakAgainst("Roadhog");
            OverWatchClasses.classGenji.addWeakAgainst("Pharah");
            OverWatchClasses.classGenji.addWeakAgainst("Symmetra");
            OverWatchClasses.classGenji.addWeakAgainst("Reinhardt");
            OverWatchClasses.classMcCree.addWeakAgainst("Genji");
            //OverWatchClasses.classMcCree.addWeakAgainst("Pharah");
            OverWatchClasses.classMcCree.addWeakAgainst("Widowmaker");
            OverWatchClasses.classMcCree.addWeakAgainst("Bastion");
            OverWatchClasses.classMcCree.addWeakAgainst("Zarya");
            OverWatchClasses.classMcCree.addWeakAgainst("Reinhardt");
            OverWatchClasses.classMcCree.addWeakAgainst("Reaper");
            OverWatchClasses.classPharah.addWeakAgainst("Soldier76");
            OverWatchClasses.classPharah.addWeakAgainst("Roadhog");
            OverWatchClasses.classPharah.addWeakAgainst("Widowmaker");
            OverWatchClasses.classPharah.addWeakAgainst("");
            OverWatchClasses.classPharah.addWeakAgainst("");
            OverWatchClasses.classPharah.addWeakAgainst("");
            OverWatchClasses.classPharah.addWeakAgainst("");
            OverWatchClasses.classPharah.addWeakAgainst("");
            OverWatchClasses.classReaper.addWeakAgainst("McCree");
            OverWatchClasses.classReaper.addWeakAgainst("Pharah");
            OverWatchClasses.classReaper.addWeakAgainst("Genji");
            OverWatchClasses.classReaper.addWeakAgainst("Zarya");
            OverWatchClasses.classReaper.addWeakAgainst("");
            OverWatchClasses.classReaper.addWeakAgainst("");
            OverWatchClasses.classReaper.addWeakAgainst("");
            OverWatchClasses.classReaper.addWeakAgainst("");
            OverWatchClasses.classReaper.addWeakAgainst("");
            OverWatchClasses.classSoldier76.addWeakAgainst("Genji");
            OverWatchClasses.classSoldier76.addWeakAgainst("Reinhardt");
            OverWatchClasses.classSoldier76.addWeakAgainst("Roadhog");
            OverWatchClasses.classSoldier76.addWeakAgainst("Mei");
            OverWatchClasses.classSoldier76.addWeakAgainst("McCree");
            OverWatchClasses.classSoldier76.addWeakAgainst("");
            OverWatchClasses.classSoldier76.addWeakAgainst("");
            OverWatchClasses.classSoldier76.addWeakAgainst("");
            OverWatchClasses.classSombra.addWeakAgainst("Symmetra");
            OverWatchClasses.classSombra.addWeakAgainst("Mei");
            OverWatchClasses.classSombra.addWeakAgainst("Winston");
            OverWatchClasses.classSombra.addWeakAgainst("Roadhog");
            OverWatchClasses.classSombra.addWeakAgainst("Pharah");
            OverWatchClasses.classTracer.addWeakAgainst("McCree");
            OverWatchClasses.classTracer.addWeakAgainst("Roadhog");
            OverWatchClasses.classTracer.addWeakAgainst("Torbjorn");
            OverWatchClasses.classTracer.addWeakAgainst("Mei");
            OverWatchClasses.classTracer.addWeakAgainst("Winston");
            OverWatchClasses.classTracer.addWeakAgainst("Pharah");
            OverWatchClasses.classBastion.addWeakAgainst("Widowmaker");
            OverWatchClasses.classBastion.addWeakAgainst("Genji");
            OverWatchClasses.classBastion.addWeakAgainst("Hanzo");
            OverWatchClasses.classBastion.addWeakAgainst("Junkrat");
            OverWatchClasses.classBastion.addWeakAgainst("Pharah");
            OverWatchClasses.classBastion.addWeakAgainst("Tracer");
            OverWatchClasses.classBastion.addWeakAgainst("Roadhog");
            OverWatchClasses.classBastion.addWeakAgainst("Mei");
            OverWatchClasses.classBastion.addWeakAgainst("Reaper");
            OverWatchClasses.classHanzo.addWeakAgainst("Genji");
            OverWatchClasses.classHanzo.addWeakAgainst("Winston");
            OverWatchClasses.classHanzo.addWeakAgainst("Widowmaker");
            OverWatchClasses.classHanzo.addWeakAgainst("Tracer");
            OverWatchClasses.classHanzo.addWeakAgainst("Reaper");
            OverWatchClasses.classHanzo.addWeakAgainst("Roadhog");
            OverWatchClasses.classHanzo.addWeakAgainst("Dva");
            OverWatchClasses.classJunkrat.addWeakAgainst("Genji");
            OverWatchClasses.classJunkrat.addWeakAgainst("Pharah");
            OverWatchClasses.classJunkrat.addWeakAgainst("Widowmaker");
            OverWatchClasses.classJunkrat.addWeakAgainst("McCree");
            OverWatchClasses.classJunkrat.addWeakAgainst("Reaper");
            OverWatchClasses.classJunkrat.addWeakAgainst("Hanzo");
            OverWatchClasses.classMei.addWeakAgainst("Pharah");
            OverWatchClasses.classMei.addWeakAgainst("McCree");
            OverWatchClasses.classMei.addWeakAgainst("Widowmaker");
            OverWatchClasses.classMei.addWeakAgainst("Bastion");
            OverWatchClasses.classMei.addWeakAgainst("Reaper");
            OverWatchClasses.classMei.addWeakAgainst("");
            OverWatchClasses.classTorbjorn.addWeakAgainst("Pharah");
            OverWatchClasses.classTorbjorn.addWeakAgainst("Hanzo");
            OverWatchClasses.classTorbjorn.addWeakAgainst("Reaper");
            OverWatchClasses.classTorbjorn.addWeakAgainst("Junkrat");
            OverWatchClasses.classTorbjorn.addWeakAgainst("Zarya");
            OverWatchClasses.classTorbjorn.addWeakAgainst("Widowmaker");
            OverWatchClasses.classTorbjorn.addWeakAgainst("Soldier76");
            OverWatchClasses.classWidowMaker.addWeakAgainst("Genji");
            OverWatchClasses.classWidowMaker.addWeakAgainst("Dva");
            OverWatchClasses.classWidowMaker.addWeakAgainst("Reaper");
            OverWatchClasses.classWidowMaker.addWeakAgainst("Winston");
            OverWatchClasses.classWidowMaker.addWeakAgainst("Reinhardt");
            OverWatchClasses.classWidowMaker.addWeakAgainst("");
            OverWatchClasses.classWidowMaker.addWeakAgainst("");
            OverWatchClasses.classWidowMaker.addWeakAgainst("");
            OverWatchClasses.classDva.addWeakAgainst("Zarya");
            OverWatchClasses.classDva.addWeakAgainst("Mei");
            OverWatchClasses.classDva.addWeakAgainst("Junkrat");
            OverWatchClasses.classDva.addWeakAgainst("Reaper");
            OverWatchClasses.classDva.addWeakAgainst("McCree");
            OverWatchClasses.classDva.addWeakAgainst("Genji");
            OverWatchClasses.classDva.addWeakAgainst("Reinhardt");
            OverWatchClasses.classOrisa.addWeakAgainst("Genji");
            OverWatchClasses.classOrisa.addWeakAgainst("Tracer");
            OverWatchClasses.classOrisa.addWeakAgainst("Reaper");
            OverWatchClasses.classOrisa.addWeakAgainst("Sombra");
            OverWatchClasses.classOrisa.addWeakAgainst("Widowmaker");
            OverWatchClasses.classOrisa.addWeakAgainst(" Bastion");
            OverWatchClasses.classOrisa.addWeakAgainst(" Pharah");
            OverWatchClasses.classReinhardt.addWeakAgainst("McCree");
            OverWatchClasses.classReinhardt.addWeakAgainst("Bastion");
            OverWatchClasses.classReinhardt.addWeakAgainst("Pharah");
            OverWatchClasses.classReinhardt.addWeakAgainst("Junkrat");
            OverWatchClasses.classReinhardt.addWeakAgainst("Reaper");
            OverWatchClasses.classReinhardt.addWeakAgainst("Tracer");
            OverWatchClasses.classReinhardt.addWeakAgainst("");
            OverWatchClasses.classRoadhog.addWeakAgainst("Reaper");
            OverWatchClasses.classRoadhog.addWeakAgainst("Mei");
            OverWatchClasses.classRoadhog.addWeakAgainst("Dva");
            OverWatchClasses.classRoadhog.addWeakAgainst("Zarya");
            OverWatchClasses.classRoadhog.addWeakAgainst("McCree");
            OverWatchClasses.classRoadhog.addWeakAgainst("");
            OverWatchClasses.classRoadhog.addWeakAgainst("");
            OverWatchClasses.classRoadhog.addWeakAgainst("");
            OverWatchClasses.classWinston.addWeakAgainst("Bastion");
            OverWatchClasses.classWinston.addWeakAgainst("Reaper");
            OverWatchClasses.classWinston.addWeakAgainst("Roadhog");
            OverWatchClasses.classWinston.addWeakAgainst("McCree");
            OverWatchClasses.classWinston.addWeakAgainst("Mei");
            OverWatchClasses.classWinston.addWeakAgainst("Dva");
            OverWatchClasses.classWinston.addWeakAgainst("Zarya");
            OverWatchClasses.classZarya.addWeakAgainst("Pharah");
            OverWatchClasses.classZarya.addWeakAgainst("Reaper");
            OverWatchClasses.classZarya.addWeakAgainst("Bastion");
            OverWatchClasses.classZarya.addWeakAgainst("Mei");
            OverWatchClasses.classZarya.addWeakAgainst("Reinhardt");
            OverWatchClasses.classZarya.addWeakAgainst("");
            OverWatchClasses.classZarya.addWeakAgainst("");
            OverWatchClasses.classAna.addWeakAgainst("Genji");
            OverWatchClasses.classAna.addWeakAgainst("Reaper");
            OverWatchClasses.classAna.addWeakAgainst("Dva");
            OverWatchClasses.classAna.addWeakAgainst("Winston");
            OverWatchClasses.classAna.addWeakAgainst("");
            OverWatchClasses.classLucio.addWeakAgainst("Mei");
            OverWatchClasses.classLucio.addWeakAgainst("Pharah");
            OverWatchClasses.classLucio.addWeakAgainst("McCree");
            OverWatchClasses.classLucio.addWeakAgainst("Tracer");
            OverWatchClasses.classLucio.addWeakAgainst("Roadhog");
            OverWatchClasses.classLucio.addWeakAgainst("Genji");
            OverWatchClasses.classLucio.addWeakAgainst("");
            OverWatchClasses.classMercy.addWeakAgainst("Tracer");
            OverWatchClasses.classMercy.addWeakAgainst("Roadhog");
            OverWatchClasses.classMercy.addWeakAgainst("Genji");
            OverWatchClasses.classMercy.addWeakAgainst("Reaper");
            OverWatchClasses.classMercy.addWeakAgainst("Soldier76");
            OverWatchClasses.classMercy.addWeakAgainst("McCree");
            OverWatchClasses.classSymmetra.addWeakAgainst("Pharah");
            OverWatchClasses.classSymmetra.addWeakAgainst("Winston");
            OverWatchClasses.classSymmetra.addWeakAgainst("Roadhog");
            OverWatchClasses.classSymmetra.addWeakAgainst("Junkrat");
            OverWatchClasses.classSymmetra.addWeakAgainst("McCree");
            OverWatchClasses.classSymmetra.addWeakAgainst("Widowmaker");
            OverWatchClasses.classSymmetra.addWeakAgainst("Reaper");
            OverWatchClasses.classSymmetra.addWeakAgainst("Soldier76");
            OverWatchClasses.classZenyatta.addWeakAgainst("Widowmaker");
            OverWatchClasses.classZenyatta.addWeakAgainst("Reaper");
            OverWatchClasses.classZenyatta.addWeakAgainst("Tracer");
            OverWatchClasses.classZenyatta.addWeakAgainst("Genji");
            OverWatchClasses.classZenyatta.addWeakAgainst("McCree");
            OverWatchClasses.classZenyatta.addWeakAgainst("Hanzo");
            OverWatchClasses.classZenyatta.addWeakAgainst("Soldier76");
            OverWatchClasses.classZenyatta.addWeakAgainst("Winston");
            OverWatchClasses.classZenyatta.addWeakAgainst("Pharah");
            OverWatchClasses.classZenyatta.addWeakAgainst("Roadhog");

            OverWatchClasses.addMissingStrenthandWeakness();

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

            /*
            if (classDoomfist.getWeakAgainst().Contains("Orisa")
                //&& !classOrisa.getStrongAgainst().Contains("Doomfist")
                )
                classOrisa.addStrongAgainst("Doomfist");*/

            foreach (var hero1 in heroes)
            {
                
                foreach (var hero2 in heroes)
                if (hero1.getWeakAgainst().Contains(hero2.getName())
                    && !hero2.getStrongAgainst().Contains(hero1.getName())
                    )
                    hero2.addStrongAgainst(hero1.getName());
               
                /*
                if (classDoomfist.getWeakAgainst().Contains(hero1.getName())
                    && !hero1.getStrongAgainst().Contains("Doomfist")
                    )
                    hero1.addStrongAgainst("Doomfist");*/
            }


            /*
            IEnumerator eHeroes = heroes.GetEnumerator();
            while (eHeroes.MoveNext())
            {
                if (classDoomfist.getWeakAgainst().Contains(eHeroes.Current.getName())
                    && eHeroes.Current.getStrongAgainst().Contains("Doomfist")
                    )
                    eHeroes.Current.addStrongAgainst("Doomfist");
            } */           
        }

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
            classSombra.setRecommendation(enemyTeam);
            classTracer.setRecommendation(enemyTeam);
            classBastion.setRecommendation(enemyTeam);
            classHanzo.setRecommendation(enemyTeam);
            classJunkrat.setRecommendation(enemyTeam);
            classMei.setRecommendation(enemyTeam);
            classTorbjorn.setRecommendation(enemyTeam);
            classWidowMaker.setRecommendation(enemyTeam);
            classDva.setRecommendation(enemyTeam);
            classOrisa.setRecommendation(enemyTeam);
            classReinhardt.setRecommendation(enemyTeam);
            classRoadhog.setRecommendation(enemyTeam);
            classWinston.setRecommendation(enemyTeam);
            classZarya.setRecommendation(enemyTeam);
            classAna.setRecommendation(enemyTeam);
            classLucio.setRecommendation(enemyTeam);
            classMercy.setRecommendation(enemyTeam); classMercy.addRecommendation(+2); // Adding +2 for since not supporting selection of team members and because mercy is only strong against symmetra
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
