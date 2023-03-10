using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Scor : MonoBehaviour {

    public Text textScor;
    private int contor = 0;
    public int scor = 0;

    private Cub cub;

    private int scorSpeed;

	void Start () {
        cub = FindObjectOfType<Cub>();
        scorSpeed = 40;
	}
	

	void Update () {

        if (cub.pierdut)
        {
            gameObject.SetActive(false);
        }

        if (!cub.pierdut)
        {

            contor++;
            if (contor % scorSpeed == 0)
            {
                scor += 1;
            }

            if(cub.wave1 == true)
            {
                scorSpeed = 35;
            }

            if (cub.wave2 == true)
            {
                scorSpeed = 30;
            }

            if (cub.wave3 == true)
            {
                scorSpeed = 25;
            }

            textScor.text = "" + scor;
        }
	}
}
