using UnityEngine;
using System.Collections;

public class touchStore : MonoBehaviour {

    private pachetgri pchtg;

	void Start () {
        pchtg = FindObjectOfType<pachetgri>();
	}
	
    public void selectiePachet()
    {
        pchtg.eSelectatP = true;
    }

    public void neselectiePachet()
    {
        pchtg.eSelectatP = false;
    }
}
