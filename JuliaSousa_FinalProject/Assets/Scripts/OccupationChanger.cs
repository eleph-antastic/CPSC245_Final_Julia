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
 * 2. This script changes the Occupation stats based on the job/button clicked.
 * */

public class OccupationChanger : MonoBehaviour
{
    public string CurrentOccupation;
    public GameObject StatsController;

    //Toggles between jobs based on the button pressed
    public void ToggleOccupation(string NewOccupation)
    {
        //Sees which Job needs to be active and activates it
        if (NewOccupation == "Geologist")
        {
            StatsController.GetComponent<StatsManager>().OccupationStats = new int[] { 0, 0, -1, 0, 0, 2};
        }
        else if (NewOccupation == "Botanist")
        {
            StatsController.GetComponent<StatsManager>().OccupationStats = new int[] { 2, 0, 0, 0, 0, -1 };
        }
        else if (NewOccupation == "Manager")
        {
            StatsController.GetComponent<StatsManager>().OccupationStats = new int[] { 0, -1, 0, 0, 2, 0 };
        }
        else //if (NewOccupation == "Mechanic")
        {
            StatsController.GetComponent<StatsManager>().OccupationStats = new int[] { 0, 0, 0, 2, -1, 0 };
        }
        CurrentOccupation = NewOccupation;
        StatsController.GetComponent<StatsManager>().UpdateDisplays();
    }
}
