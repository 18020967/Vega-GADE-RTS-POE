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
    public int WorldResources = 100000;        
   
    void Start()
    {
     
        
    }
    private void Update()
    {
        WorldText.text = WorldResources.ToString();
    }


    public int redStored = 0;


    public void redRCGenerator(int amount)
    {
        if (WorldResources > 0)
        {
            redStored += amount;
            WorldResources -= amount;
        }
        
        REDtext.text = "Resources stored : "+redStored.ToString();
    }

    public int blueStored = 0;


    public void blueRCGenerator(int amount)
    {
        if (WorldResources > 0)
        {
            blueStored += amount;
            WorldResources -= amount;
        }

        BLUEtext.text = "Resources stored : " + blueStored.ToString();
    }

    public int greenStored = 0;


    public void greenRCGenerator(int amount)
    {
        if (WorldResources > 0)
        {
            greenStored += amount;
            WorldResources -= amount;
        }

        GREENtext.text = "Resources stored : " + greenStored.ToString();
    }



}
