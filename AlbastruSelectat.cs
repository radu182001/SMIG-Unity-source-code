using UnityEngine;
using System.Collections;

public class AlbastruSelectat : MonoBehaviour {

    private Animator anim;
    public bool eAbstru;
    private TouchMenu tm;
    	
	void Start () {
        anim = GetComponent<Animator>();
        tm = FindObjectOfType<TouchMenu>();
	}
	

	void Update () {


        anim.SetBool("BlueS", eAbstru);
	}


}
