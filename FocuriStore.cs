using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FocuriStore : MonoBehaviour {

    public Text nrFocuriTotaleTxt;
    public int nrFocuriTotale;
    private FocuriLuateInJoc flij;
    private FocAjutor fa;



	void Start () {
        fa = FindObjectOfType<FocAjutor>();

    }
	

	void Update () {

        nrFocuriTotale = fa.focuriSTOREperGame;

        nrFocuriTotaleTxt.text = "" + nrFocuriTotale;
	}
}
