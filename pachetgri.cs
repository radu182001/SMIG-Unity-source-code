using UnityEngine;
using System.Collections;

public class pachetgri : MonoBehaviour {

    private Animator anim;
    public bool eSelectatP = false;

	void Start () {
        anim = GetComponent<Animator>();
	}

	void Update () {
        anim.SetBool("selectatP", eSelectatP);
	}
}
