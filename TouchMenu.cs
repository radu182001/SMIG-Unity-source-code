using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TouchMenu : MonoBehaviour {

    public GameObject cubCulori;
    private Colors col;
    private RosuSelectat rslct;
    private Select0 slct0;
    private AlbastruSelectat abstrs;
    private SelectareVerde slctVrd;
    private SelectareGalben slctG;
    private portocaliuselectare prtselect;
    private siclamselectare siclselect;
    private FocAjutor fa;

    public GameObject sonoff;

    private Animator anim;

    public GameObject meniu;

    public GameObject press;

    public GameObject scor;

    public GameObject store;

    public GameObject CanBuy;

    public GameObject credits;

    public GameObject MenuScroll;

    //Solve for bugs
    private bool magazin = false;
    private bool credite = false;


    //Dash
    public float contor = 0;
    private bool isDashing = false;
    private bool cresteViteza = false;
    public float contorSePoate = 0;
    public GameObject camera;
    public GameObject cameraBlur;
    private Scor score;
    public GameObject db;
    public bool apareDash = false;
    private DashArrows dsharr;
    private bool inceputJoc = true;

    //Pentru sunet
    private SoundOnOff soo;
    private MuzicaOnOff moo;

    private mscr ms;

    private Cub cub;
    public bool selected = false;
    public bool incepe = false;

    private GetXFree gxf;


    //Menu scroll objects
    public GameObject albastruM;
    public GameObject negruM;
    public GameObject rosuM;
    public GameObject verdeM;
    public GameObject portocaliuM;
    public GameObject siclamM;
    public GameObject galbenM;
    private bool seScrolleaza;
    public int contorScroll;

    //Items to buy
    public bool blueC = true;
    public bool blackC = false;
    public bool redC = true;
    public bool greenC = true;
    public bool purpleC = true;
    public bool orangeC = true;
    public bool yellowC = true;

    //I want to buy
    public bool blueCWant = false;
    public bool blacKCWant = false;
    public bool redCWant = false;
    public bool greenCWant = false;
    public bool purpleCWant = false;
    public bool orangeCWant = false;
    public bool yellowCWant = false;

    //Buttons for store
    public GameObject blueCButton;
    public GameObject blacKCButton;
    public GameObject redCButton;
    public GameObject greenCButton;
    public GameObject purpleCButton;
    public GameObject orangeCButton;
    public GameObject yellowCButton;

    //Owned buttons
    public GameObject blueOwned;
    public GameObject redOwned;
    public GameObject greenOwned;
    public GameObject purpleOwned;
    public GameObject orangeOwned;
    public GameObject yellowOwned;



    //ints for PlayerPrefs
    public int albastru = 0;
    public int rosu = 0;
    public int verde = 0;
    public int siclam = 0;
    public int portocaliu = 0;
    public int galben = 0;

    void Start () {
        col = FindObjectOfType<Colors>();
        rslct = FindObjectOfType<RosuSelectat>();
        slct0 = FindObjectOfType<Select0>();
        cub = FindObjectOfType<Cub>();
        anim = GetComponent<Animator>();
        ms = FindObjectOfType<mscr>();
        abstrs = FindObjectOfType<AlbastruSelectat>();
        slctVrd = FindObjectOfType<SelectareVerde>();
        slctG = FindObjectOfType<SelectareGalben>();
        prtselect = FindObjectOfType<portocaliuselectare>();
        siclselect = FindObjectOfType<siclamselectare>();
        fa = FindObjectOfType<FocAjutor>();
        soo = FindObjectOfType<SoundOnOff>();
        moo = FindObjectOfType<MuzicaOnOff>();
        score = FindObjectOfType<Scor>();
        gxf = FindObjectOfType<GetXFree>();
        dsharr = FindObjectOfType<DashArrows>();


        blackC = false;

        //PlayerPrefs for store
        if (PlayerPrefs.HasKey("PtrAlbastru"))
        {
            albastru = PlayerPrefs.GetInt("PtrAlbastru");
        }
        if(PlayerPrefs.HasKey("PtrRosu")) rosu = PlayerPrefs.GetInt("PtrRosu");
        if(PlayerPrefs.HasKey("PtrVerde")) verde = PlayerPrefs.GetInt("PtrVerde");
        if(PlayerPrefs.HasKey("PtrSiclam")) siclam = PlayerPrefs.GetInt("PtrSiclam");
        if(PlayerPrefs.HasKey("PtrPortocaliu")) portocaliu = PlayerPrefs.GetInt("PtrPortocaliu");
        if(PlayerPrefs.HasKey("PtrGalben")) galben = PlayerPrefs.GetInt("PtrGalben");
    }

    //Dash

    public void resetDash()
    {
        contorSePoate = 0;
        dsharr.transparent.a = 0;
        dsharr.transparent2.a = 0;
        dsharr.transparent3.a = 0;
    }


    void Update()
    {



        //Dash

        if (inceputJoc)
        {
            db.SetActive(false);
        }
        else if (!inceputJoc) db.SetActive(true);

        if (cub.pierdut)
        {
            apareDash = false;
        }
        else if (!cub.pierdut) apareDash = true;

        if (apareDash)
        {
            if (contorSePoate < 150 && !cub.pierdut)
            {
                contorSePoate++;
            }
            if (Input.GetKey(KeyCode.Return) && contorSePoate == 150)
            {
                resetDash();
                isDashing = true;
            }

            if (isDashing)
            {
                contor++;

                if (contor > 13)
                {

                    if (cub.wave1)
                    {
                        cub.speed = 3.5f;
                    }
                    else if (cub.wave2)
                    {
                        cub.speed = 4f;
                    }
                    else if (cub.wave3)
                    {
                        cub.speed = 4.5f;
                    }
                    else cub.speed = 3;
                    contor = 0;
                    camera.SetActive(true);
                    cameraBlur.SetActive(false);
                    isDashing = false;
                }
                else
                if (isDashing && contor <= 13)
                {
                    cub.speed = 7;
                    camera.SetActive(false);
                    cameraBlur.SetActive(true);
                }
            }
        }


        PlayerPrefs.SetInt("PtrRosu", rosu);
        PlayerPrefs.SetInt("PtrVerde", verde);
        PlayerPrefs.SetInt("PtrSiclam", siclam);
        PlayerPrefs.SetInt("PtrPortocaliu", portocaliu);
        PlayerPrefs.SetInt("PtrGalben", galben);

        if (albastru == 1) blueC = false;
        else if (albastru == 0) blueC = true;

        if (rosu == 1) redC = false;
        else if (rosu == 0) redC = true;

        if (verde == 1) greenC = false;
        else if (verde == 0) greenC = true;

        if (siclam == 1) purpleC = false;
        else if (siclam == 0) purpleC = true;

        if (portocaliu == 1) orangeC = false;
        else if (portocaliu == 0) orangeC = true;

        if (galben == 1) yellowC = false;
        else if (galben == 0) yellowC = true;

        if(!blueC)
        {
            blueCButton.SetActive(false);
            blueOwned.SetActive(true);
        }

        if(!redC)
        {
            redCButton.SetActive(false);
            redOwned.SetActive(true);
        }

        if(!greenC)
        {
            greenCButton.SetActive(false);
            greenOwned.SetActive(true);
        }

        if(!purpleC)
        {
            purpleCButton.SetActive(false);
            purpleOwned.SetActive(true);
        }

        if(!orangeC)
        {
            orangeCButton.SetActive(false);
            orangeOwned.SetActive(true);
        }

        if(!yellowC)
        {
            yellowCButton.SetActive(false);
            yellowOwned.SetActive(true);
        }


        anim.SetBool("seJoaca", incepe);
    }


    public void next()
    {
        if (!magazin)
        {
            cub.pierdut = false;
            apareDash = true;
            inceputJoc = false;
            AdManager.Instance.ShowBanner();
            gxf.incepe = true;
            incepe = true;
            ms.incepe1 = true;
            press.SetActive(false);
            scor.SetActive(true);
            //meniu.SetActive(false);
        }

    }

    public void selectatVerde()
    {
        if(!selected && !greenC)
        {
            slctVrd.slctV = true;
            selected = true;
            cub.green = true;
            FindObjectOfType<AudioManager>().PlaySound("Select");
        }
        if(selected && !greenC)
        {
            slctVrd.slctV = true;
            cub.green = true;
            cub.red = false;
            cub.blue = false;
            cub.purple = false;
            cub.orange = false;
            rslct.select = false;
            slct0.select0 = false;
            abstrs.eAbstru = false;
            slctG.gslct = false;
            cub.yellow = false;
            siclselect.siclslct = false;
            prtselect.prtslct = false;
            FindObjectOfType<AudioManager>().PlaySound("Select");
        }
    }

    public void selectatAlbastru()
    {
        if(!selected && !blueC)
        {
            abstrs.eAbstru = true;
            selected = true;
            cub.blue = true;
            FindObjectOfType<AudioManager>().PlaySound("Select");
        }
        if(selected && !blueC)
        {
            abstrs.eAbstru = true;
            cub.blue = true;
            cub.red = false;
            cub.green = false;
            cub.purple = false;
            cub.orange = false;
            rslct.select = false;
            slct0.select0 = false;
            slctVrd.slctV = false;
            slctG.gslct = false;
            cub.yellow = false;
            siclselect.siclslct = false;
            prtselect.prtslct = false;
            FindObjectOfType<AudioManager>().PlaySound("Select");

        }
    }

    public void selectatRosu()
    {
        if (!selected && !redC)
        {
            rslct.select = true;
            selected = true;
            cub.red = true;
            FindObjectOfType<AudioManager>().PlaySound("Select");
        }
        else if(selected && !redC)
        {
            rslct.select = true;
            slct0.select0 = false;
            cub.red = true;
            abstrs.eAbstru = false;
            cub.purple = false;
            cub.orange = false;
            cub.blue = false;
            cub.green = false;
            slctVrd.slctV = false;
            slctG.gslct = false;
            cub.yellow = false;
            siclselect.siclslct = false;
            prtselect.prtslct = false;
            FindObjectOfType<AudioManager>().PlaySound("Select");
        }
    }

    public void selectat0()
    {
        if (!selected)
        {
            slct0.select0 = true;
            selected = true;
            cub.red = false;
            FindObjectOfType<AudioManager>().PlaySound("Select");
        }
        else if (selected)
        {
            rslct.select = false;
            slct0.select0 = true;
            cub.red = false;
            abstrs.eAbstru = false;
            cub.purple = false;
            cub.orange = false;
            cub.blue = false;
            cub.green = false;
            slctVrd.slctV = false;
            slctG.gslct = false;
            cub.yellow = false;
            siclselect.siclslct = false;
            prtselect.prtslct = false;
            FindObjectOfType<AudioManager>().PlaySound("Select");
        }
    }

    public void selectatGalben()
    {
        if(!selected && !yellowC)
        {
            slctG.gslct = true;
            cub.yellow = true;
            selected = true;
            FindObjectOfType<AudioManager>().PlaySound("Select");
        }
        if(selected && !yellowC)
        {
            slctG.gslct = true;
            cub.yellow = true;
            cub.purple = false;
            cub.orange = false;
            cub.blue = false;
            cub.green = false;
            cub.red = false;
            slctVrd.slctV = false;
            abstrs.eAbstru = false;
            slct0.select0 = false;
            rslct.select = false;
            siclselect.siclslct = false;
            prtselect.prtslct = false;
            FindObjectOfType<AudioManager>().PlaySound("Select");
        }
    }

    public void selectatPortocaliu()
    {

        if (!selected && !orangeC)
        {
            prtselect.prtslct = true;
            cub.orange = true;
            selected = true;
            FindObjectOfType<AudioManager>().PlaySound("Select");
        }

        if (selected && !orangeC)
        {
            FindObjectOfType<AudioManager>().PlaySound("Select");
            cub.orange = true;
            prtselect.prtslct = true;
            siclselect.siclslct = false;
            slctG.gslct = false;
            cub.purple = false;
            cub.yellow = false;
            cub.blue = false;
            cub.green = false;
            cub.red = false;
            slctVrd.slctV = false;
            abstrs.eAbstru = false;
            slct0.select0 = false;
            rslct.select = false;
        }
    }

    public void selectatSiclam()
    {

        if (!selected && !purpleC)
        {
            siclselect.siclslct = true;
            cub.purple = true;
            selected = true;
            FindObjectOfType<AudioManager>().PlaySound("Select");
        }

        if (selected && !purpleC)
        {
            cub.purple = true;
            siclselect.siclslct = true;
            prtselect.prtslct = false;
            slctG.gslct = false;
            cub.orange = false;
            cub.yellow = false;
            cub.blue = false;
            cub.green = false;
            cub.red = false;
            slctVrd.slctV = false;
            abstrs.eAbstru = false;
            slct0.select0 = false;
            rslct.select = false;
            FindObjectOfType<AudioManager>().PlaySound("Select");
        }
    }

    public void openStore()
    {
        magazin = true;
        store.SetActive(true);
        FindObjectOfType<AudioManager>().PlaySound("Select");
    }

    public void closeStore()
    {
        magazin = false;
        store.SetActive(false);
        FindObjectOfType<AudioManager>().PlaySound("Select");
    }

    public void BuyBlue()
    {
        if (blueC)
        {
            
            CanBuy.SetActive(true);
            blueCWant = true;
        }
        if(!blueC)
        {
            CanBuy.SetActive(false);
            blueCWant = false;
        }

    }

    public void BuyRed()
    {
        if (redC)
        {

            CanBuy.SetActive(true);
            redCWant = true;
        }
        if (!redC)
        {
            CanBuy.SetActive(false);
            redCWant = false;
        }

    }

    public void BuyGreen()
    {
        if (greenC)
        {

            CanBuy.SetActive(true);
            greenCWant = true;
        }
        if (!greenC)
        {
            CanBuy.SetActive(false);
            greenCWant = false;
        }

    }

    public void BuyPurple()
    {
        if (purpleC)
        {

            CanBuy.SetActive(true);
            purpleCWant = true;
        }
        if (!purpleC)
        {
            CanBuy.SetActive(false);
            purpleCWant = false;
        }

    }

    public void BuyOrange()
    {
        if (orangeC)
        {

            CanBuy.SetActive(true);
            orangeCWant = true;
        }
        if (!orangeC)
        {
            CanBuy.SetActive(false);
            orangeCWant = false;
        }

    }

    public void BuyYellow()
    {
        if (yellowC)
        {

            CanBuy.SetActive(true);
            yellowCWant = true;
        }
        if (!yellowC)
        {
            CanBuy.SetActive(false);
            yellowCWant = false;
        }

    }

    public void IWantToBuy()
    {
        
        if (blueCWant && fa.focuriSTOREperGame >= 50)
        {
            blueC = false;
            blueCWant = false;
            fa.focuriSTOREperGame -= 50;
            albastru = 1;
            PlayerPrefs.SetInt("PtrAlbastru", albastru);
            PlayerPrefs.SetInt("FocTotal", fa.focuriSTOREperGame);
            
        }
        else
        if(redCWant && fa.focuriSTOREperGame >= 50)
        {
            redC = false;
            redCWant = false;
            fa.focuriSTOREperGame -= 50;
            rosu = 1;
            PlayerPrefs.SetInt("FocTotal", fa.focuriSTOREperGame);
        } else
        if(greenCWant && fa.focuriSTOREperGame >= 50)
        {
            greenC = false;
            greenCWant = false;
            fa.focuriSTOREperGame -= 50;
            verde = 1;
            PlayerPrefs.SetInt("FocTotal", fa.focuriSTOREperGame);
        } else
        if(purpleCWant && fa.focuriSTOREperGame >= 50)
        {
            purpleC = false;
            purpleCWant = false;
            fa.focuriSTOREperGame -= 50;
            siclam = 1;
            PlayerPrefs.SetInt("FocTotal", fa.focuriSTOREperGame);
        } else
        if(orangeCWant && fa.focuriSTOREperGame >= 50)
        {
            orangeC = false;
            orangeCWant = false;
            fa.focuriSTOREperGame -= 50;
            portocaliu = 1;
            PlayerPrefs.SetInt("FocTotal", fa.focuriSTOREperGame);
        } else
        if(yellowCWant && fa.focuriSTOREperGame >= 50)
        {
            yellowC = false;
            yellowCWant = false;
            fa.focuriSTOREperGame -= 50;
            galben = 1;
            PlayerPrefs.SetInt("FocTotal", fa.focuriSTOREperGame);
        }
        CanBuy.SetActive(false);
        FindObjectOfType<AudioManager>().PlaySound("Pay");
    }

    public void IDontWantToBuy()
    {
        
        blueCWant = false;
        redCWant = false;
        greenCWant = false;
        purpleCWant = false;
        orangeCWant = false;
        yellowCWant = false;
        CanBuy.SetActive(false);
        FindObjectOfType<AudioManager>().PlaySound("Select");
    }

    public void Facebook()
    {
        Application.OpenURL("https://www.facebook.com/KULUtheOwl/");
    }

    public void YouTube()
    {
        Application.OpenURL("https://www.youtube.com/channel/UCvU3OcI3KXxtoZMnRUKkkNA");
    }

    public void openCredits()
    {
        credite = true;
        credits.SetActive(true);
        FindObjectOfType<AudioManager>().PlaySound("Select");
    }

    public void closeCredits()
    {
        credite = false;
        credits.SetActive(false);
        FindObjectOfType<AudioManager>().PlaySound("Select");
    }

    public void Sunet()
    {
        if(!soo.nu)
        {
            soo.nu = true;
        }else
        if(soo.nu)
        {
            soo.nu = false;
        }
    }

    public void Muzica()
    {
        if(!moo.no)
        {
            moo.no = true;
        }else
        if(moo.no)
        {
            moo.no = false;
        }
    }

    public void Dash()
    {
        if (contorSePoate >= 150)
        {
            isDashing = true;
            resetDash();
        }
    }

    public void VreauSaSelectezCuloare()
    {
        seScrolleaza = true;
    }
   




}
