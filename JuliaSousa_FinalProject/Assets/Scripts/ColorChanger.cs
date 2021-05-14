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
 * I used the following Unity Question for reference on how to get the Mesh Renderer for an object: https://answers.unity.com/questions/59355/change-the-material-on-an-object-in-a-script.html
 * 
 * 2. This script holds all the different materials to be used for changing the astronaut's suit color and changes them when buttons are clicked.
 * */

public class ColorChanger : MonoBehaviour
{
    //Array of Upper Body Materials (Order is: Default, Red, Orange, Yellow, Green, Blue, Purple, Pink, Black)
    public Material[] UpperBodyMaterials;

    //Array of Lower Body Materials (Order is: Default, Red, Orange, Yellow, Green, Blue, Purple, Pink, Black)
    public Material[] LowerBodyMaterials;

    //Upperbody and Lowerbody of the astronaut to access and change their colors
    public GameObject UpperBody;
    public GameObject LowerBody;

    //When the game starts, it resets the materials of the astronaut to the default suit color
    void Start()
    {
        UpperBody.GetComponent<SkinnedMeshRenderer>().material = UpperBodyMaterials[0];
        LowerBody.GetComponent<SkinnedMeshRenderer>().material = LowerBodyMaterials[0];
    }

    //Changes Color based on the Button pressed (String parameter)
    public void ChangeColor(string Color)
    {
        if(Color == "Default")
        {
            UpperBody.GetComponent<SkinnedMeshRenderer>().material = UpperBodyMaterials[0];
            LowerBody.GetComponent<SkinnedMeshRenderer>().material = LowerBodyMaterials[0];
        }
        else if (Color == "Red")
        {
            UpperBody.GetComponent<SkinnedMeshRenderer>().material = UpperBodyMaterials[1];
            LowerBody.GetComponent<SkinnedMeshRenderer>().material = LowerBodyMaterials[1];
        }
        else if (Color == "Orange")
        {
            UpperBody.GetComponent<SkinnedMeshRenderer>().material = UpperBodyMaterials[2];
            LowerBody.GetComponent<SkinnedMeshRenderer>().material = LowerBodyMaterials[2];
        }
        else if (Color == "Yellow")
        {
            UpperBody.GetComponent<SkinnedMeshRenderer>().material = UpperBodyMaterials[3];
            LowerBody.GetComponent<SkinnedMeshRenderer>().material = LowerBodyMaterials[3];
        }
        else if (Color == "Green")
        {
            UpperBody.GetComponent<SkinnedMeshRenderer>().material = UpperBodyMaterials[4];
            LowerBody.GetComponent<SkinnedMeshRenderer>().material = LowerBodyMaterials[4];
        }
        else if (Color == "Blue")
        {
            UpperBody.GetComponent<SkinnedMeshRenderer>().material = UpperBodyMaterials[5];
            LowerBody.GetComponent<SkinnedMeshRenderer>().material = LowerBodyMaterials[5];
        }
        else if (Color == "Purple")
        {
            UpperBody.GetComponent<SkinnedMeshRenderer>().material = UpperBodyMaterials[6];
            LowerBody.GetComponent<SkinnedMeshRenderer>().material = LowerBodyMaterials[6];
        }
        else if (Color == "Pink")
        {
            UpperBody.GetComponent<SkinnedMeshRenderer>().material = UpperBodyMaterials[7];
            LowerBody.GetComponent<SkinnedMeshRenderer>().material = LowerBodyMaterials[7];
        }
        else //if (Color == "Black")
        {
            UpperBody.GetComponent<SkinnedMeshRenderer>().material = UpperBodyMaterials[8];
            LowerBody.GetComponent<SkinnedMeshRenderer>().material = LowerBodyMaterials[8];
        }
    }
}
