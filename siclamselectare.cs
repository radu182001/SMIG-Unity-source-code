using UnityEngine;
using System.Collections;

public class siclamselectare : MonoBehaviour {

    private Animator anim;
    public bool siclslct;

	void Start () {
        anim = GetComponent<Animator>();
	}
	

	void Update () {
        anim.SetBool("sslct", siclslct);
	}
}
