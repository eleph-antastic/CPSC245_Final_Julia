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
    public GameObject StatsController;

    //Toggles between personalities based on the button pressed
    public void TogglePersonality(string NewPersonality)
    {
        //Sees which Job needs to be active and activates it
        if (NewPersonality == "Active")
        {
            StatsController.GetComponent<StatsManager>().PersonalityStats = new int[] { 2, 0, 0, 0, 0, 0 };
        }
        else if (NewPersonality == "Lucky")
        {
            StatsController.GetComponent<StatsManager>().PersonalityStats = new int[] { 0, 2, 0, 0, 0, 0 };
        }
        else if (NewPersonality == "Hasty")
        {
            StatsController.GetComponent<StatsManager>().PersonalityStats = new int[] { 0, 0, 2, 0, 0, 0 };
        }
        else if (NewPersonality == "Intellectual")
        {
            StatsController.GetComponent<StatsManager>().PersonalityStats = new int[] { 0, 0, 0, 2, 0, 0 };
        }
        else if (NewPersonality == "Outgoing")
        {
            StatsController.GetComponent<StatsManager>().PersonalityStats = new int[] { 0, 0, 0, 0, 2, 0 };
        }
        else //if (NewPersonality == "Cautious")
        {
            StatsController.GetComponent<StatsManager>().PersonalityStats = new int[] { 0, 0, 0, 0, 0, 2};
        }
        CurrentPersonality = NewPersonality;
        StatsController.GetComponent<StatsManager>().UpdateDisplays();
    }
}
