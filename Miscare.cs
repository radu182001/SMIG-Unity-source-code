using UnityEngine;
using System.Collections;

public class Miscare : MonoBehaviour {

    public float speed;

    public GameObject pctm;
    public GameObject pctM;
	
	void Start () {
	
	}
	
	
	void Update () {
        transform.Translate(speed * Time.deltaTime, 0, 0);
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "punctMic")
        {
            Instantiate(pctm, new Vector3(other.gameObject.transform.position.x + 1f, other.gameObject.transform.position.y - 1f, transform.position.z), transform.rotation);
        }

        if (other.gameObject.tag == "punctMare")
        {
            Instantiate(pctM, new Vector3(other.gameObject.transform.position.x + 1f, other.gameObject.transform.position.y - 0.5f, transform.position.z), transform.rotation);
        }
    }
}
