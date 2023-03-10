using UnityEngine;
using System.Collections;

public class TouchCondition : MonoBehaviour {

    public GameObject sus;
    public GameObject jos;

    private Cub cub;

	void Start () {
        cub = FindObjectOfType<Cub>();
    }
	

	void Update () {
	    if(cub.seTrans)
        {
            sus.gameObject.SetActive(false);
            jos.gameObject.SetActive(true);
        }

        if (!cub.seTrans)
        {
            jos.gameObject.SetActive(false);
            sus.gameObject.SetActive(true);
        }


    }
}
