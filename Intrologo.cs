using UnityEngine;
using System.Collections;

public class Intrologo : MonoBehaviour {

    public int contor;
    public bool gataIntro = false; 

	void Start () {

	}
	

	void Update () {
        contor++;

        if(contor >= 250)
        {
            gataIntro = true;
        }

        if(gataIntro)
        {
            Application.LoadLevel(1);
        }


	}
}
