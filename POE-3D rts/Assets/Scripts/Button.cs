using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    void start()

    {
        PlayPause();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void PlayPause()
    {
        if (Time.timeScale != 0.001f)
        {
            Time.timeScale = 0.001f;
        }
        else
        {
            Time.timeScale = 1f;
        }

    }
}
