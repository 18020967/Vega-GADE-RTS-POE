using UnityEngine;


public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    void start()

    {
        PlayPause();
    }
        
    public void PlayPause()
    {
        //this function playes and pauses the game but it actualy makes time go very very slow
        if (Time.timeScale != 0.0001f)
        {
            Time.timeScale = 0.0001f;
        }
        else
        {
            Time.timeScale = 1f;
        }

    }
}
