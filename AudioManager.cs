using UnityEngine;
using System.Collections;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour {

    public AudioSoundsForGame[] asound;

    private static bool exista;

    void Start()
    {
        if (!exista)
        {
            exista = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else Destroy(gameObject);
    }

	void Awake () {
	    foreach(AudioSoundsForGame s in asound)
        {
            s.source =  gameObject.AddComponent<AudioSource>();
            s.source.clip = s.audioC;
            s.source.volume = s.volume;
            s.source.loop = s.loop;
        }
	}
	
    public void PlaySound(string name)
    {
        AudioSoundsForGame s = Array.Find(asound, sound => sound.soundName == name);
        s.source.Play();
    }

    public void DontPlaySound(string tagul)
    {
        AudioSoundsForGame s = Array.Find(asound, sound => sound.tag == tagul);
        s.source.volume = 0;
    }

    public void HearSound(string tagul)
    {
        AudioSoundsForGame s = Array.Find(asound, sound => sound.tag == tagul);
        s.source.volume = 1;
    }
}
