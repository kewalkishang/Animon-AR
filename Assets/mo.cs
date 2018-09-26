using UnityEngine;
using System.Collections;

public class mo : MonoBehaviour {
    public GameObject target;

    // Use this for initialization
    void Start () {
      //  transform.position = new Vector3(0, -2, 10);
    }
	
	// Update is called once per frame
	void Update () {
   
        transform.eulerAngles = new Vector3(270, 180, 0);
      // transform.LookAt(target.transform);
    }
}
