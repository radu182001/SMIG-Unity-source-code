using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FocuriLuateInJoc : MonoBehaviour {

    public Text textFoc;

    public int focuri = 0;

    public bool afostluatf = false;

    private int contor = 0;

    private Animator anim;




    void Start () {
        anim = GetComponent<Animator>();


    }
	

	void Update () {
        textFoc.text = "x" + focuri;
        
        if(afostluatf == true)
        {
            contor++;
            if(contor == 100)
            {
                afostluatf = false;
                contor = 0;
            }
        }

        anim.SetBool("aFostLuat", afostluatf);
	}
}
