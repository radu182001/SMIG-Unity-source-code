using UnityEngine;
using System.Collections;

public class SelectareVerde : MonoBehaviour {

    public bool slctV;
    private Animator anim; 

	void Start () {
        anim = FindObjectOfType<Animator>();
	}
	

	void Update () {
        anim.SetBool("vslct", slctV);
	}
}
