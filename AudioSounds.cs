using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

[System.Serializable]
public class AudioSoundsForGame {

    public string soundName;
    public AudioClip audioC;
    public bool loop;
    public string tag;

    [Range(0f,1f)]
    public float volume;

    [HideInInspector]
    public AudioSource source;

}
