using UnityEngine;
using System.Collections;

public class Foc1 : MonoBehaviour {

    private Animator anim;

    private Cub cub;

    private bool luat = false;

    private FocuriLuateInJoc flij;

    private FocScorImg fsi;

    private int contor;

    private FocAjutor fa;

    void Start () {
        anim = GetComponent<Animator>();
        flij = FindObjectOfType<FocuriLuateInJoc>();
        fsi = FindObjectOfType<FocScorImg>();
        cub = FindObjectOfType<Cub>();
        fa = FindObjectOfType<FocAjutor>();
        
    }
	

	void Update () {
        anim.SetBool("eLuat", luat);
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "cub" && !cub.pierdut)
        {
            luat = true;
            flij.afostluatf = true;
            fsi.apare = true; 
            flij.focuri += 1;
            fa.focuriSTOREperGame += 1;
            PlayerPrefs.SetInt("FocTotal", fa.focuriSTOREperGame);
        }
    }
}
