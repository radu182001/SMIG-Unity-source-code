using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FocuriLaFinal : MonoBehaviour {

    public Text luateF;

    private FocuriLuateInJoc flij;

	void Start () {
        flij = FindObjectOfType<FocuriLuateInJoc>();
	}
	

	void Update () {
        luateF.text = "" + flij.focuri;
	}
}
