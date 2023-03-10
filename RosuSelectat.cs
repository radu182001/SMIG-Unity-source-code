using UnityEngine;
using System.Collections;

public class RosuSelectat : MonoBehaviour {

    private Animator anim;
    public bool select;

	void Start () {
        anim = GetComponent<Animator>();
	}
	

	void Update () {
        anim.SetBool("Selectat", select);
	}
}
