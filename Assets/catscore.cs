using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class catscore : MonoBehaviour {
   public Text txt1;
    public Text txt2;
    public Text txt3;
    public Text txt4;
    public Text count;

    // Use this for initialization
    void Start () {
        int c=0;
        txt1.text = "X " + PlayerPrefs.GetInt("cat");
        txt2.text = "X "+ PlayerPrefs.GetInt("ele");
        txt3.text = "X " + PlayerPrefs.GetInt("rhi");
        txt4.text = "X " + PlayerPrefs.GetInt("spi");
        if ( PlayerPrefs.GetInt("spi")>0){
            c=c+1;
        }

        if (PlayerPrefs.GetInt("ele") > 0)
        {
            c = c + 1;
        }
        if(PlayerPrefs.GetInt("rhi")>0)
        {
            c = c + 1;
                }
        if(PlayerPrefs.GetInt("cat")>0)
        {
            c = c + 1;
        }

        count.text = " "+c;
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.LoadLevel(0);
    }
}
