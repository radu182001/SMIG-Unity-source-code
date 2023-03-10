using UnityEngine;
using System.Collections;

public class mscr : MonoBehaviour {

    public Animator anim;

    public bool incepe1 = false;

	void Start () {
        anim = GetComponent<Animator>();
	}
	

	void Update () {
        anim.SetBool("seJoaca1", incepe1);
	}
}
