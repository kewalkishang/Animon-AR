using UnityEngine;
using System.Collections;

public class ChaSel : MonoBehaviour {
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject d;

    // Use this for initialization
    void Start () {
        int ch=PlayerPrefs.GetInt("sco", 0);
        if (ch == 1)
        {
            a.SetActive(true);
        }
        else
              if (ch == 2)
        {
            b.SetActive(true);
        }
        else
              if (ch == 3)
        {
            c.SetActive(true);
        }
        else
              if (ch == 4)
        {
            d.SetActive(true);

        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
