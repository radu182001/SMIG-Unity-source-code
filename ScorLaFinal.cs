using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScorLaFinal : MonoBehaviour {

    private Scor scor;

    private totceelegatdescor tcelds;

    public Text textScF;

	void Start () {
        scor = FindObjectOfType<Scor>();
        tcelds = FindObjectOfType<totceelegatdescor>();
	}
	

	void Update () {
        textScF.text = "" + tcelds.scor;
	}
}
