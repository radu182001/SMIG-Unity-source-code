using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DashArrows : MonoBehaviour {

    public static int arrowNumber = 0;
    public float contor = 0;
    public Color transparent;
    public Color transparent2;
    public Color transparent3;
    public Image imagine;
    public Image imagine2;
    public Image imagine3;


    private Cub cub;
    private TouchMenu tm;

	void Start () {
        cub = FindObjectOfType<Cub>();
        tm = FindObjectOfType<TouchMenu>();
	}
	

	void Update () {
        imagine.color = transparent;
        imagine2.color = transparent2;
        imagine3.color = transparent3;

        if (!cub.pierdut)
        {

            contor = tm.contorSePoate;

            if (contor < 50)
            {
                transparent.a += Time.deltaTime;
                transparent2.a = 0;
                transparent3.a = 0;
            }else
            if (contor >= 50 && contor < 100)
            {
                transparent2.a += Time.deltaTime;
            }else
            if (contor >= 100 && contor < 150)
            {
                transparent3.a += Time.deltaTime;
            }
            else
            if(contor == 0)
            {
                transparent.a = 0;
                transparent2.a = 0;
                transparent3.a = 0;
            }


        }

        if (cub.pierdut)
        {
            tm.resetDash();
        }



    }
}
