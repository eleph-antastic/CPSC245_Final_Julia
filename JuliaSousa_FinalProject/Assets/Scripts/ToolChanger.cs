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
 * 2. This script holds all the different tools available and activates them when the correct buttons are clicked.
 * */

public class ToolChanger : MonoBehaviour
{
    //Cameras for Menus (Order is: Crowbar, Hammer, Pipe, Wrench)
    public GameObject[] Tools;

    public string CurrentTool;

    public int[] ToolStats = new int[] { 0, 0, 0, 0, 0, 0 }; //Order is: Stamina, Luck, Agility, Intelligence, Charisma, and Stealth

    //Toggles between helmets based on the button pressed
    public void ToggleTools(string NewTool)
    {
        //Deactivate all Tools
        for (int i = 0; i < Tools.Length; i++)
        {
            Tools[i].SetActive(false);
        }

        //Sees which Menu needs to be active and activates it
        if (NewTool == "Crowbar")
        {
            Tools[0].SetActive(true);
            ToolStats = new int[] { 0, 0, 1, 0, 0, 0};
        }
        else if (NewTool == "Hammer")
        {
            Tools[1].SetActive(true);
            ToolStats = new int[] { 1, 0, 0, 0, 0, 0 };
        }
        else if (NewTool == "Pipe")
        {
            Tools[2].SetActive(true);
            ToolStats = new int[] { 0, 0, 0, 0, 1, 0 };
        }
        else //if (NewTool == "Wrench")
        {
            Tools[3].SetActive(true);
            ToolStats = new int[] { 0, 0, 0, 1, 0, 0 };
        }
        CurrentTool = NewTool;
    }

    public void HideTools()
    {
        //Deactivate all Tools
        for (int i = 0; i < Tools.Length; i++)
        {
            Tools[i].SetActive(false);
        }
    }
}
