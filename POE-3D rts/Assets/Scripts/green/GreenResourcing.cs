using UnityEngine;

public class GreenResourcing : MonoBehaviour
{
    public MainUIScript resourcer;

    private float nextActionTime = 0.0f;
    public float period = 1f;
    void Update()
    {
        //calls the script to generate resources for their team every second
        if (Time.time > nextActionTime)
        {
            nextActionTime = Time.time + period;
            resourcer.greenRCGenerator(20);
        }
    }

}
