using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    float speed = 100f;
    private void Update()
    {
        //movement of the camera to get a better view on the scene
        //right
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
        //left
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }
        //backwords
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
        }
        //forwords
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
        }
        //up and down / zoom
        if (Input.GetAxis("Mouse ScrollWheel")>0f)
        {
            transform.Translate(new Vector3(0, 0, (speed * 3) * Time.deltaTime));
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            transform.Translate(new Vector3(0, 0, -(speed * 3) * Time.deltaTime));
        }

    }
}
