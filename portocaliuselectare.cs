using UnityEngine;
using System.Collections;

public class portocaliuselectare : MonoBehaviour {

    private Animator anim;
    public bool prtslct;

	void Start () {
        anim = GetComponent<Animator>();

	}
	

	void Update () {
        anim.SetBool("pslct", prtslct);
	}
}
