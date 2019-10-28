using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Stat
{
   //allows me to set the stat of a unit to how i see fit
    [SerializeField]
    private int baseValue = 20;

    public int GetValue()
    {
        return baseValue;
    }

 

}
