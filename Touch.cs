using UnityEngine;
using System.Collections;

public class Touch : MonoBehaviour {

    private Cub cub;
    public GameObject playB;
    public GameObject pauseB;
    public GameObject colorsChange;
    public GameObject scor;

    private SoundOnOff soo;

    public GameObject menuCanv;

	void Start () {
        cub = FindObjectOfType<Cub>();
        soo = FindObjectOfType<SoundOnOff>();
	}
	
    void Update()
    {
        if (cub.pierdut)
        {
            pauseB.SetActive(false);
        }
        else if (!cub.pierdut) pauseB.SetActive(true);
    }


    public void eMare()
    {
        if (!cub.pierdut)
        {
            cub.Mare();
        }
    }

    public void eMic()
    {
        if (!cub.pierdut)
        {
            cub.Mic();
        }
    }

    public void restart()
    {
        Application.LoadLevel(Application.loadedLevel);

            FindObjectOfType<AudioManager>().PlaySound("Select");


    }

    public void menu()
    {
       
        Application.LoadLevel(Application.loadedLevel);
        AdManager.Instance.DestroyBanner();

            FindObjectOfType<AudioManager>().PlaySound("Select");


    }

    public void pauza()
    {
        cub.pierdut = true;
        playB.SetActive(true);
        pauseB.SetActive(false);
        FindObjectOfType<AudioManager>().PlaySound("Select");
    }

    public void continua()
    {
        cub.pierdut = false;
        playB.SetActive(false);
        pauseB.SetActive(true);
        scor.SetActive(true);
        FindObjectOfType<AudioManager>().PlaySound("Select");
    }

}
