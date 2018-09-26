using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class rhino : MonoBehaviour {

    public Sprite red;

    public GameObject pb;

    void Start()
    {
        if (PlayerPrefs.GetInt("rhi", 0) > 0)
        {
            gameObject.GetComponent<Image>().sprite = red;
            pb.SetActive(true);
        }


    }

    // Update is called once per frame
    void Update () {
	
	}
}
