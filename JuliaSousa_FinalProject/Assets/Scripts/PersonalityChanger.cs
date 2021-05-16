using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*1.
 * a. Julia Sousa
 * b. 2345424
 * c. jsousa@chapman.edu 
 * d. CPSC245-01
 * e. Final Project - EFPA Customization Screen
 * f. This is my own work. I did not cheat on this assignment.
 * 
 * 2. This script changes the Personality stats based on the job/button clicked.
 * */

public class PersonalityChanger : MonoBehaviour
{
    public string CurrentPersonality;
    public int[] PersonalityStats = new int[] { 0, 0, 0, 0, 0, 0 }; //Order is: Stamina, Luck, Agility, Intelligence, Charisma, and Stealth

    //Toggles between personalities based on the button pressed
    public void TogglePersonality(string NewPersonality)
    {
        //Sees which Job needs to be active and activates it
        if (NewPersonality == "Active")
        {
            PersonalityStats = new int[] { 2, 0, 0, 0, 0, 0 };
        }
        else if (NewPersonality == "Lucky")
        {
            PersonalityStats = new int[] { 0, 2, 0, 0, 0, 0 };
        }
        else if (NewPersonality == "Hasty")
        {
            PersonalityStats = new int[] { 0, 0, 2, 0, 0, 0 };
        }
        else if (NewPersonality == "Intellectual")
        {
            PersonalityStats = new int[] { 0, 0, 0, 2, 0, 0 };
        }
        else if (NewPersonality == "Outgoing")
        {
            PersonalityStats = new int[] { 0, 0, 0, 0, 2, 0 };
        }
        else //if (NewPersonality == "Cautious")
        {
            PersonalityStats = new int[] { 0, 0, 0, 0, 0, 2};
        }
        CurrentPersonality = NewPersonality;
    }
}
