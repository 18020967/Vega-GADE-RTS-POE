using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Stat
{

    [SerializeField]
    private int baseValue = 20;

    public int GetValue()
    {
        return baseValue;
    }

 

}
