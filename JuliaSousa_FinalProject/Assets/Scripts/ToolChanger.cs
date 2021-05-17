using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    public GameObject StatsController;

    public GameObject[] ToolIcons;
    public Sprite HammerIcon;
    public Sprite CrowbarIcon;
    public Sprite WrenchIcon;
    public Sprite PipeIcon;

    //Toggles between helmets based on the button pressed
    public void ToggleTools(string NewTool)
    {
        //Deactivate all Tools
        for (int i = 0; i < Tools.Length; i++)
        {
            Tools[i].SetActive(false);
        }

        //Sees which tool needs to be active and activates it
        if (NewTool == "Crowbar")
        {
            Tools[0].SetActive(true);
            StatsController.GetComponent<StatsManager>().ToolStats = new int[] { 0, 0, 1, 0, 0, 0};
            UpdateToolIcons(CrowbarIcon);
        }
        else if (NewTool == "Hammer")
        {
            Tools[1].SetActive(true);
            StatsController.GetComponent<StatsManager>().ToolStats = new int[] { 1, 0, 0, 0, 0, 0 };
            UpdateToolIcons(HammerIcon);
        }
        else if (NewTool == "Pipe")
        {
            Tools[2].SetActive(true);
            StatsController.GetComponent<StatsManager>().ToolStats = new int[] { 0, 0, 0, 0, 1, 0 };
            UpdateToolIcons(PipeIcon);
        }
        else //if (NewTool == "Wrench")
        {
            Tools[3].SetActive(true);
            StatsController.GetComponent<StatsManager>().ToolStats = new int[] { 0, 0, 0, 1, 0, 0 };
            UpdateToolIcons(WrenchIcon);
        }
        CurrentTool = NewTool;
        StatsController.GetComponent<StatsManager>().UpdateDisplays();
    }

    public void HideTools()
    {
        //Deactivate all Tools
        for (int i = 0; i < Tools.Length; i++)
        {
            Tools[i].SetActive(false);
        }
    }

    public void UpdateToolIcons(Sprite newSprite)
    {
        for (int i = 0; i < ToolIcons.Length; i++)
        {
            ToolIcons[i].GetComponent<Image>().sprite = newSprite;
        }
    }
}
