using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUIScript : MonoBehaviour
{
    public Text REDtext;
    public Text BLUEtext;
    public Text GREENtext;
    public Text WorldText;
    int WorldResources = 0;        

    //this script is called from each resource generator and adds resources to their team
    // and removes resourcesd from the world and only allows resources if there are available in the world
    //it also sisplays the needed data on the UI
   
    void Start()
    {
        WorldResources = 500000;
    }
    private void Update()
    {
       
    }


    public int redStored = 0;


    public void redRCGenerator(int amount)
    {
        if (WorldResources > 0)
        {
            redStored += amount;
            WorldResources -= 20;            
        }
        
        REDtext.text = "Resources stored : "+redStored.ToString();
    }

    public int blueStored = 0;


    public void blueRCGenerator(int amount)
    {
        if (WorldResources > 0)
        {
            blueStored += amount;
            WorldResources -= 20;            
        }

        BLUEtext.text = "Resources stored : " + blueStored.ToString();
    }

    public int greenStored = 0;


    public void greenRCGenerator(int amount)
    {
        if (WorldResources > 0)
        {
            greenStored += amount;
            WorldResources -= 20;      
        }

        GREENtext.text = "Resources stored : " + greenStored.ToString();
    }

    public void greenUnitSpawned(int amount)
    {       
       greenStored -= amount;
       GREENtext.text = "Resources stored : " + greenStored.ToString();
    }

    public void blueUnitSpawned(int amount)
    {
        blueStored -= amount;
        BLUEtext.text = "Resources stored : " + blueStored.ToString();
    }

    public void redUnitSpawned(int amount)
    {
        redStored -= amount;
        REDtext.text = "Resources stored : " + redStored.ToString();
    }



}
