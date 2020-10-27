/*
 * Author: Cory Kitay
 * Date: 07-Aug-2016
 * Purpose: Defines Class for Overwatch Character Object.
 * Used to keep track of which character is strong/neutral/weak against other characters
 * 
 * */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using OverWatchClassSuggestor;

public class Character
{

    private string name ;    // Name of the character, e.g. "Mei"
    private string group; // e.g. Offense, Defense, Tank, Support 
    private ArrayList strong = new ArrayList();  // List of other characters that this character is strong against.
    private ArrayList neutral = new ArrayList(); // List of other characters that this character is neutral against.
    private ArrayList weak = new ArrayList();   // List of other characters that this character is weak against.
    private int recommendation; // Rank Recommendation # based off what enemy team is composed of
    private ArrayList mapList = new ArrayList(); // List of maps this character is better at playing

    
    public Character(string name, string group)
    {
        this.name = name;
        this.group = group;
    }

    public string getName()
    {
        return name;
    }

    public void addStrongAgainst(string name)
    {
        strong.Add(name);
    }

    public void addWeakAgainst(string name)
    {
        weak.Add(name);
    }

    public ArrayList getStrongAgainst()
    {
        return strong;
    }

    public ArrayList getWeakAgainst()
    {
        return weak;
    }

    public void setRecommendation(String[] enemyTeam)
    {
        recommendation = 0;

        for (int i=0; i < 6; i++)
        {
            //Console.WriteLine(enemyTeam[i]);

            if ( strong.Contains(enemyTeam[i]) )
            {                
                recommendation++;
            }
            else if ( weak.Contains(enemyTeam[i]) )
            {
                recommendation--;
            }
            else if ( neutral.Contains(enemyTeam[i]) )
            {
                ;
            }
            //else //else if ( enemyTeam[i] == " ") // Presume enemYTeam[i] == " "
            //{
            //    recommendation = 0; 
            //}
        }
    }

    public void setRecommendation(String[] enemyTeam, String map)
    {
        recommendation = 0;

        for (int i = 0; i < 6; i++)
        {
            //Console.WriteLine(enemyTeam[i]);

            if (strong.Contains(enemyTeam[i]))
            {
                recommendation++;
            }
            else if (weak.Contains(enemyTeam[i]))
            {
                recommendation--;
            }
            else if (neutral.Contains(enemyTeam[i]))
            {
                ;
            }
        }

        if (mapList.Contains(map))
            recommendation++;
    }

    public void addMap(string map)
    {
        mapList.Add(map);
    }

    public void addRecommendation(int rec)
    {
        recommendation+=rec;
    }

    public int getRecommendation()
    {
        return recommendation;
    }

}
