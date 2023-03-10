using UnityEngine;
using System.Collections;

public class SelectareGalben : MonoBehaviour {

    private Animator anim;
    public bool gslct;

	void Start () {
        anim = GetComponent<Animator>();
	}
	

	void Update () {
        anim.SetBool("GSlct", gslct);
	}
}
