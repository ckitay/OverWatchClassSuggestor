/*
 * Author: Cory Kitay
 * Date: 07-Aug-2016
 * Purpose: Defines Class for Overwatch Character Object.
 * Used to keep track of which character is strong/neutral/weak against other characters
 * 
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using OverWatchClassSuggestor;

public class Character
{

    private string name ;    // Name of the character, e.g. "Mei"
    private string group; // e.g. Offense, Defense, Tank, Support 
    //public BadImageFormatException image; // Need an image of the character to show.
    private string[] strong;  // List of other characters that this character is strong against.
    private string[] neutral; // List of other characters that this character is neutral against.
    private string[] weak;   // List of other characters that this character is weak against.
    private int recommendation; // Rank Recommendation # based off what enemy team is composed of

    public Character(string name, string group, 
        string[] strong, 
        string[] weak, 
        string[] neutral)        
    {
        this.name = name;
        this.group = group;
        this.strong = strong;
        this.neutral = neutral;
        this.weak = weak;
    }
    /*(
    public Character(string name, string group)
    {
        this.name = name;
        this.group = group;
    }

    public addStrongAgainst(string name)
    {
        strong.add
    }*/

    public void setRecommendation(String[] enemyTeam)
    {
        recommendation = 0;

        for (int i=0; i < 6; i++)
        {
            Console.WriteLine(enemyTeam[i]);

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

    public int getRecommendation()
    {
        return recommendation;
    }

}
