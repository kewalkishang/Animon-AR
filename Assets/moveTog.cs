using UnityEngine;
using System.Collections;

public class moveTog : MonoBehaviour {
    public GameObject cam;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = cam.transform.position + cam.transform.forward;
	}
}
