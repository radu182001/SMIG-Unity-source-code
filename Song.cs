using UnityEngine;
using System.Collections;

public class Song : MonoBehaviour {


    private static bool exista;

    private bool isPlaying;

    private MuzicaOnOff moo;

	void Start () {

        moo = FindObjectOfType<MuzicaOnOff>();

        if (!exista)
        {
            exista = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else Destroy(gameObject);
        if (!isPlaying)
        {
            FindObjectOfType<AudioManager>().PlaySound("MainSong");
            isPlaying = true;
        }

    }
	

	void Update () {


    }
}
