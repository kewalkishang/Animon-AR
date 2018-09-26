using UnityEngine;
using System.Collections;

public class RotCam : MonoBehaviour {

    private float speedMod = 10.0f;

    void Start()
   {
        Input.gyro.enabled = true;
    }


    void Update()
    {
        transform.Rotate(0, -Input.gyro.rotationRateUnbiased.y, 0);
   
        //transform.Rotate(-Input.gyro.rotationRateUnbiased.x, -Input.gyro.rotationRateUnbiased.y, 0);
    }
    }
