using UnityEngine;
using System.Collections;

public class totceelegatdescor : MonoBehaviour {

    private Scor scorScr;
    public int scor;

	void Start () {
        scorScr = FindObjectOfType<Scor>();
	}
	

	void Update () {
        scor = scorScr.scor;
	}
}
