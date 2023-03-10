using UnityEngine;
using System.Collections;

public class SoundOnOff : MonoBehaviour {

    private Animator anim;
    public bool nu = false;
    private TouchMenu tm;

    private static bool exista;

	void Start () {

        if (!exista)
        {
            exista = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else Destroy(gameObject);

        anim = GetComponent<Animator>();
        tm = FindObjectOfType<TouchMenu>();
	}
	

	void Update () {
        anim.SetBool("nuSunet", nu);


	}
}
