using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    //Camera to move between menus
    public GameObject MainCamera;

    //Canvas Menus (Order is: Physical Main Menu, Helmet, Tool, Color, Personal Main Menu, Personality, Occupation)
    public GameObject[] CanvasMenus;

    public string CurrentMenu;

    //Accesses the tool toggler game object so it can turn off the objects and toggle the icon
    public GameObject ToolToggleSystem;

    //Camera locations to toggle between - didn't make an array of these because had some issues with it
    public Vector3 PhysicalMenuLocation;
    public Vector3 HelmetCameraLocation;
    public Vector3 ToolCameraLocation;
    public Vector3 ColorCameraLocation;
    public Vector3 PersonalMenuLocation;
    public Vector3 PersonalityCameraLocation;
    public Vector3 FinalMenuCameraLocation;

    //Astronaut

    //Toggles between Menus based on button clicked
    public void ToggleMenu(string NewMenu)
    {

        //Deactivate all Canvas Menus
        for (int i = 0; i < CanvasMenus.Length; i++)
        {
            CanvasMenus[i].SetActive(false);
        }

        CurrentMenu = NewMenu;

        //Sees which Menu needs to be active and activates it
        if (NewMenu == "Tools")
        {
            MainCamera.transform.position = ToolCameraLocation;
            CanvasMenus[2].SetActive(true);
        }
        else
        {
            //If we are changing FROM the tools menu (not TO), then we need to hide the tools and display the icon instead
            ToolToggleSystem.GetComponent<ToolChanger>().HideTools();
        }
        if (NewMenu == "PhysicalMain")
        {
            MainCamera.transform.position = PhysicalMenuLocation;
            CanvasMenus[0].SetActive(true);
        }
        else if(NewMenu == "Helmet")
        {
            MainCamera.transform.position = HelmetCameraLocation;
            CanvasMenus[1].SetActive(true);
        }
        else if(NewMenu == "Color")
        {
            MainCamera.transform.position = ColorCameraLocation;
            CanvasMenus[3].SetActive(true);
        }
        else if(NewMenu == "PersonalMain")
        {
            MainCamera.transform.position = PersonalMenuLocation;
            CanvasMenus[4].SetActive(true);
        }
        else if (NewMenu == "Personality")
        {
            MainCamera.transform.position = PersonalityCameraLocation;
            CanvasMenus[5].SetActive(true);
        }
        else if (NewMenu == "Occupation")
        {
            MainCamera.transform.position = PersonalityCameraLocation; //same camera location as personality menu
            CanvasMenus[6].SetActive(true);
        }
        else if (NewMenu == "EndMenu")
        {
            MainCamera.transform.position = FinalMenuCameraLocation;
            CanvasMenus[7].SetActive(true);
        }
    }

    //closes game
    public void QuitGame()
    {
        Application.Quit();
    }
    //Restarts the customization process
    public void ResetGame()
    {
        SceneManager.LoadScene("CustomizationScreen");
    }
}
