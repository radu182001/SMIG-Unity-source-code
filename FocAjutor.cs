using UnityEngine;
using System.Collections;

public class FocAjutor : MonoBehaviour {

    public int focuriSTOREperGame;

    private FocuriLuateInJoc flij;

	void Start () {
        flij = FindObjectOfType<FocuriLuateInJoc>();
        if (PlayerPrefs.HasKey("FocTotal"))
        {
            focuriSTOREperGame = PlayerPrefs.GetInt("FocTotal");
        }
    }
	

	void Update () {

    }
}
