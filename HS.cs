using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class HS : MonoBehaviour {

    public Text highS;
    public int hs;
    private Scor scorScr;
    private totceelegatdescor tcelds;


	void Start () {
        if(PlayerPrefs.HasKey("hisc"))
        {
            hs = PlayerPrefs.GetInt("hisc");
        }
        scorScr = FindObjectOfType<Scor>();
        tcelds = FindObjectOfType<totceelegatdescor>();

	}
	

	void Update () {

        if (tcelds.scor > hs)
        {
            hs = tcelds.scor;
            PlayerPrefs.SetInt("hisc", hs);
        }
        highS.text = "Best: " + hs;
    }
}
