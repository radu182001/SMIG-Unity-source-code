using UnityEngine;
using System.Collections;


public class Random : MonoBehaviour {

    public int number;

    public GameObject unu;
    public GameObject doi;
    public GameObject trei;
    public GameObject patru;
    public GameObject cinci;

    private SpawnControl spc;

	void Start () {

        spc = FindObjectOfType<SpawnControl>();

        number = UnityEngine.Random.Range(0,9);
        while(number == spc.nrTrecut)
            {
                number = UnityEngine.Random.Range(0, 9);
            }
        spc.nrTrecut = number;

        if(number == 0 || number == 5)
            Instantiate(unu, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);

        if (number == 1 || number == 6)
            Instantiate(doi, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);

        if (number == 2 || number == 7)
            Instantiate(trei, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);

        if (number == 3 || number == 8)
            Instantiate(patru, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);

        if (number == 4 || number == 9)
            Instantiate(cinci, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
    }
	
	void Update () {
	    
	}
}
