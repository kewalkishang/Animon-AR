using UnityEngine;
using System.Collections;

public class showcase : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Screen.orientation = ScreenOrientation.Portrait;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void showcat()
    {
        if (PlayerPrefs.GetInt("cat") > 0)
        {
            PlayerPrefs.SetInt("sco", 1);
            Application.LoadLevel(3);
        }
    }
    public void showrhi()
    {
        if (PlayerPrefs.GetInt("rhi") > 0)
        {
            PlayerPrefs.SetInt("sco", 4);
            Application.LoadLevel(3);

        }
    }
    public void showspid()
    {
        if (PlayerPrefs.GetInt("spi") > 0)
        {
            PlayerPrefs.SetInt("sco", 2);
            Application.LoadLevel(3);

        }
    }
    public void showele()
    {
        if (PlayerPrefs.GetInt("ele") > 0)
        {
            PlayerPrefs.SetInt("sco", 3);

            Application.LoadLevel(3);
        }
    }
}
