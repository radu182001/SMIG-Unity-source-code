using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StoreButton : MonoBehaviour {

    public Text sttxt;
    public Color clOnClick;

	void Start () {

	}
	
    public void OnClick()
    {
        sttxt.color = clOnClick;
    }

    public void NotOnClick()
    {
        sttxt.color = Color.white;
    }


}
