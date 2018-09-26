using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class elep : MonoBehaviour {

    public Sprite red;

    public GameObject pb;

    void Start()
    {
        if (PlayerPrefs.GetInt("ele", 0) > 0)
        {
            gameObject.GetComponent<Image>().sprite = red;
            pb.SetActive(true);
        }


    }

    // Update is called once per frame
    void Update () {
	
	}
}
