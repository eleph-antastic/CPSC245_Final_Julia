﻿using System.Collections;
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
 * 2. This script holds all the different helmet objects and changes them when buttons are clicked.
 * */

public class HelmetChanger : MonoBehaviour
{

    //Cameras for Menus (Order is: Basic, Bounty Hunter, Chief, Sturdy)
    public GameObject[] Helmets;

    public string CurrentHelmet;

    //Toggles between helmets based on the button pressed
    public void ToggleHelmets(string NewHelmet)
    {
        //Deactivate all Helmets
        for (int i = 0; i < Helmets.Length; i++)
        {
            Helmets[i].SetActive(false);
        }

        //Sees which Menu needs to be active and activates it
        if (NewHelmet == "Basic")
        {
            Helmets[0].SetActive(true);
        }
        else if (NewHelmet == "Bounty")
        {
            Helmets[1].SetActive(true);
        }
        else if (NewHelmet == "Chief")
        {
            Helmets[2].SetActive(true);
        }
        else if (NewHelmet == "Sturdy")
        {
            Helmets[3].SetActive(true);
        }
        else
        {
            //PlaceHolder for the new Menus to be added
        }
        CurrentHelmet = NewHelmet;
    }
}
