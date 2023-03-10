using UnityEngine;
using System.Collections;

public class Colors : MonoBehaviour {

    public bool eRosu = false;
    private RosuSelectat rosuS;
    private Select0 sl0;

    private static bool exista;

    void Start () {

        DontDestroyOnLoad(transform.gameObject);
        rosuS = FindObjectOfType<RosuSelectat>();
        sl0 = FindObjectOfType<Select0>();
    }
	

	void Update () {

    if(rosuS.select)
        {
            eRosu = true;
        }
    else if(!rosuS.select)
        {
            eRosu = false;
        }

    if(sl0.select0)
        {
            eRosu = false;
        }

	}
}
