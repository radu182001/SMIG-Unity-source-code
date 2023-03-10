using UnityEngine;
using System.Collections;

public class MuzicaOnOff : MonoBehaviour {

    private Animator anim;
    public bool no = false;

    public GameObject song;

    private static bool exista;

	void Start () {

        if (!exista)
        {
            exista = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else Destroy(gameObject);

        anim = GetComponent<Animator>();
	}
	

	void Update () {



        anim.SetBool("nuMuzica", no);
	}
}
