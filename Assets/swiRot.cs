using UnityEngine;
using System.Collections;

public class swiRot : MonoBehaviour {
  
    // Use this for initialization
    void Start()
    {
       
        Screen.orientation = ScreenOrientation.Portrait;
    
    }

    public float speed = 0.1F;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.LoadLevel(2);
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {

            // Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            // transform.Translate(-touchDeltaPosition.x * speed, -touchDeltaPosition.y * speed, 0);
            if (Input.GetTouch(0).deltaPosition.y > 0)
            {
                transform.Rotate(-Vector3.up * Time.deltaTime * 200);
            }
            else
            if (Input.GetTouch(0).deltaPosition.y < 0)
            {
                transform.Rotate(Vector3.up*Time.deltaTime * 200);
            }


        }
        if (Input.touchCount == 2 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {


            if (Input.GetTouch(0).deltaPosition.x > 0)
            {
            //    transform.Translate(Vector3.forward * Time.deltaTime * 10);
            }
            else
            if (Input.GetTouch(0).deltaPosition.x < 0)
            {
            //    transform.Translate(-Vector3.forward * Time.deltaTime * 10);
            }

        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            /* for (int i = 0; i < 5; i++)
           {
                 Destroy(walls[i]); // this , or the next command ?
                                              // arrayPathMarker[i]=null;
             } */


        }


        // transform.Rotate(Vector3.right * Time.deltaTime*10);
    }
}