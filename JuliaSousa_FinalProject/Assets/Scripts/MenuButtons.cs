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
 * 2. This script holds all the different cameras and Canvas menus and changes them when buttons are clicked.
 * */

public class MenuButtons : MonoBehaviour
{
    //Cameras for Menus (Order is: Physical Main Menu, Helmet, Tool, Color)
    public GameObject[] MenuCameras;

    //Canvas Menus (Order is: Physical Main Menu, Helmet, Tool, Color)
    public GameObject[] CanvasMenus;

    public string CurrentMenu;

    //Accesses the tool toggler game object so it can turn off the objects and toggle the icon
    public GameObject ToolToggleSystem;

    //
    public void ToggleMenu(string NewMenu)
    {
        //Deactivate all Cameras
        for (int i = 0; i < MenuCameras.Length; i++)
        {
            MenuCameras[i].SetActive(false);
        }

        //Deactivate all Canvas Menus
        for (int i = 0; i < CanvasMenus.Length; i++)
        {
            CanvasMenus[i].SetActive(false);
        }

        CurrentMenu = NewMenu;

        //Sees which Menu needs to be active and activates it
        if (NewMenu == "Tools")
        {
            MenuCameras[2].SetActive(true);
            CanvasMenus[2].SetActive(true);
        }
        else
        {
            //If we are changing FROM the tools menu (not TO), then we need to hide the tools and display the icon instead
            ToolToggleSystem.GetComponent<ToolChanger>().HideTools();
        }
        if (NewMenu == "PhysicalMain")
        { 
            MenuCameras[0].SetActive(true);
            CanvasMenus[0].SetActive(true);
        }
        else if(NewMenu == "Helmet")
        {
            MenuCameras[1].SetActive(true);
            CanvasMenus[1].SetActive(true);
        }
        else if(NewMenu == "Color")
        {
            MenuCameras[3].SetActive(true);
            CanvasMenus[3].SetActive(true);
        }
        else //if
        {
            //PlaceHolder for the new Menus to be added
        }
    }
}
