using UnityEngine;
using System.Collections;

public class Volume : MonoBehaviour {

    private static bool exista;

	void Start () {
        if (!exista)
        {
            exista = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else Destroy(gameObject);
    }
	

	void Update () {
	
	}
}
