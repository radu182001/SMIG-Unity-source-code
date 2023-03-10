using UnityEngine;
using System.Collections;

public class FocScorImg : MonoBehaviour {

    private Animator anim;

    public bool apare = false;
    private int contor;

	void Start () {
        anim = GetComponent<Animator>();
	}
	

	void Update () {
        anim.SetBool("aFostLuat", apare);
        if (apare == true)
        {
            contor++;
            if (contor == 100)
            {
                apare = false;
                contor = 0;
            }
        }
    }
}
