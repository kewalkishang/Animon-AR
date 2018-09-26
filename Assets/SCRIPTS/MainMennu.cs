using UnityEngine;
using System.Collections;

public class MainMennu : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Screen.orientation = ScreenOrientation.Portrait;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void playsc()
    {
        Application.LoadLevel(1);
    }
    public void anidex()
    {
        Application.LoadLevel(2);
    }
}
