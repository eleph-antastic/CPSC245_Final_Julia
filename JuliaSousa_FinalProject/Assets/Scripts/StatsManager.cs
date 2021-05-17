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
 * 2. This script handles all the stats and displaying of stats on-screen.
 * */

public class StatsManager : MonoBehaviour
{
    //ORDER FOR STATS IS ALWAYS AS FOLLOWS: Stamina, Luck, Agility, Intelligence, Charisma, Stealth

    //Stat Arrays from the different togglers
    public int[] HelmetStats = new int[] { 0, 0, 0, 0, 0, 0 }; 
    public int[] ToolStats = new int[] { 0, 0, 0, 0, 0, 0 };
    public int[] PersonalityStats = new int[] { 0, 0, 0, 0, 0, 0 };
    public int[] OccupationStats = new int[] { 0, 0, 0, 0, 0, 0 };

    //Base stats that do not get modified
    private int[] baseStats = new int[] { 3, 3, 3, 3, 3, 3 };

    //Stats arrays that get displayed
    private int[] currentStats = new int[] { 3, 3, 3, 3, 3, 3 }; //total stats

    //Stats Displays to the UI
    public GameObject StatsDisplayRight;
    public GameObject StatsDisplayBottomLeft;
    public GameObject StatsDisplayLeft;

    //Stats Text Arrays for each stat in each display
    public GameObject[] StaminaTexts;
    public GameObject[] LuckTexts;
    public GameObject[] AgilityTexts;
    public GameObject[] IntelligenceTexts;
    public GameObject[] CharismaTexts;
    public GameObject[] StealthTexts;

    //Sets all Displays texts to default
    private void Start()
    {
        UpdateDisplays();
    }

    //Updates every UI Stat text with the current stats
    public void UpdateDisplays()
    {
        UpdateCurrentStats();
        for (int i = 0; i < StaminaTexts.Length; i++)
        {
            StaminaTexts[i].GetComponent<Text>().text = currentStats[0].ToString();
        }
        for (int i = 0; i < LuckTexts.Length; i++)
        {
            LuckTexts[i].GetComponent<Text>().text = currentStats[1].ToString();
        }
        for (int i = 0; i < AgilityTexts.Length; i++)
        {
            AgilityTexts[i].GetComponent<Text>().text = currentStats[2].ToString();
        }
        for (int i = 0; i < IntelligenceTexts.Length; i++)
        {
            IntelligenceTexts[i].GetComponent<Text>().text = currentStats[3].ToString();
        }
        for (int i = 0; i < CharismaTexts.Length; i++)
        {
            CharismaTexts[i].GetComponent<Text>().text = currentStats[4].ToString();
        }
        for (int i = 0; i < StealthTexts.Length; i++)
        {
            StealthTexts[i].GetComponent<Text>().text = currentStats[5].ToString();
        }

    }

    //Adds all stat arrays to update the current stats
    public void UpdateCurrentStats()
    {
        for (int i = 0; i < currentStats.Length; i++)
        {
            currentStats[i] = baseStats[i] + HelmetStats[i] + ToolStats[i] + PersonalityStats[i] + OccupationStats[i];
        }
    }
}
