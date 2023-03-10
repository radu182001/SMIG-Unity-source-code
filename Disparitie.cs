using UnityEngine;
using System.Collections;

public class Disparitie : MonoBehaviour {

    public float contorD;

    private Cub cub;

    private Spawn spawn;



    private bool sePoate = false;

	void Start () {
        cub = FindObjectOfType<Cub>();
        spawn = FindObjectOfType<Spawn>();

    }
	
	void Update () {

        if(gameObject.transform.position.x < cub.pozitieCub - 10)
        {
            sePoate = true;
        }

        if (!cub.pierdut)
        {
            contorD += Time.deltaTime;
            if (spawn.constanta > 2 && sePoate)
            {
                spawn.constanta -= 1;
                Destroy(gameObject);
            }
        }
	}
}
