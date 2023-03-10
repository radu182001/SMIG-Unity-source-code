using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class GetXFree : MonoBehaviour {

    private Animator anim;
    public bool itIsTime;

    private int contor;

    public Color normal;
    public Color apasat;

    public Image img;

    public int reperRand;

    private FocAjutor fa;
    public bool incepe;
    

	void Start () {
        anim = GetComponent<Animator>();
        fa = FindObjectOfType<FocAjutor>();
        Advertisement.Initialize("512a1027-a145-48fd-a7a7-4f0087137f7c");
	}
	

	void Update () {

        contor++;
        if(contor >= UnityEngine. Random.Range(300,500))
        {
            itIsTime = true;
            reperRand++;
            if(reperRand >= 5)
            {
                itIsTime = false;
                reperRand = 0;
                contor = 0;
            }

        }

        anim.SetBool("aInceput", incepe);
        anim.SetBool("isTime", itIsTime);
	}

    public void apasatPeEl()
    {
        img.color = apasat;
    }

    public void nuApasatPeEl()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show("rewardedVideo", new ShowOptions(){resultCallback = ADVazutSauNu});
        }
        img.color = normal;
        PlayerPrefs.SetInt("FocTotal", fa.focuriSTOREperGame);
    }

    private void ADVazutSauNu(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                fa.focuriSTOREperGame += 15;
                PlayerPrefs.SetInt("FocTotal", fa.focuriSTOREperGame);
                break;
        }
    }

}
