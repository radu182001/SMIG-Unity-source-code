using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InimaCareBate : MonoBehaviour {

    private Animator anim;
    private bool bate = false;
    private float contor;

    public Slider slider;
    private float contor2;

    public GameObject sliderObj;

    public GameObject cubulet;
    private Cub cub;

    private FocAjutor fa;
    private TouchMenu tm;

    private bool suna = false;

	void Start () {
        anim = GetComponent<Animator>();
        cub = FindObjectOfType<Cub>();
        fa = FindObjectOfType<FocAjutor>();
        tm = FindObjectOfType<TouchMenu>();
	}
	

	void Update () {
        contor += Time.deltaTime;
        contor2 += Time.deltaTime;

        if(bate && !suna)
        {
            //FindObjectOfType<AudioManager>().PlaySound("HeartBeat");
            suna = true;
        }

        if (contor > 1.5)
        {
            bate = true;
            suna = false;
            if (contor > 2.15)
            {
                bate = false;
                contor = 0;
            }
        }

        slider.value = contor2;
        if(contor2 >= 5)
        {
            cub.aiPierdutDAR = false;
            gameObject.SetActive(false);
            sliderObj.SetActive(false);
        }

        anim.SetBool("Bate", bate);
	}

    public void vreauViata()
    {
        if (fa.focuriSTOREperGame >= 20)
        {
            fa.focuriSTOREperGame -= 20;
            PlayerPrefs.SetInt("FocTotal", fa.focuriSTOREperGame);
            tm.resetDash();
            cub.eInvincibil = true;
            cub.pierdut = false;
            //tm.apareDash = true;
            FindObjectOfType<AudioManager>().PlaySound("Select");
            cub.aiPierdutDAR = false;
            gameObject.SetActive(false);
            sliderObj.SetActive(false);
        }
    }
}
