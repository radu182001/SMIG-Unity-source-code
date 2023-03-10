using UnityEngine;
using System.Collections;

public class Cub : MonoBehaviour {

    private Animator anim;
    public  bool seTrans;

    private Rigidbody2D myRigidbody;
    public float jumpSpeed;
    public bool isGrounded;

    public float speed;

    public GameObject pctm;
    public GameObject pctM;

    public GameObject chenar;

    public GameObject pauza;

    private Scor scor;
    public bool wave1 = false;
    public bool wave2 = false;
    public bool wave3 = false;

    public float pozitieCub;

    public bool pierdut;

    public bool red = false;

    public bool blue = false;

    public bool green = false;

    public bool yellow = false;

    public bool orange = false;

    public bool purple = false;

    private Colors col;

    public GameObject pauseB;
    public GameObject scorAfisat;

    public GameObject camera;
    private Vector3 shakePos;
    private bool dead = false;

    //Invincibilitate
    public GameObject acesta;
    private int contor;
    private int altContor;
    private bool seVede = false;
    private int i;
    private BoxCollider2D bc2d;
    public float pozitieCubY;
    int ctr;
    bool retine = false;
    int a2aOaraNu = 0;


    //Viata in plus
    private InimaCareBate icb;
    public bool aiPierdutDAR = true;
    public GameObject inima;
    public bool eInvincibil = false;

    void Start () {
        anim = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();
        scor = FindObjectOfType<Scor>();
        bc2d = GetComponent<BoxCollider2D>();
        col = FindObjectOfType<Colors>();
        pierdut = true;




    }


    void Update()
    {

        if(dead)
        {
            FindObjectOfType<AudioManager>().PlaySound("Hit");
            dead = false;
        }

        shakePos = new Vector3(camera.transform.position.x, camera.transform.position.y, camera.transform.position.z);
        camera.transform.position = shakePos;

        //Retine pozitia y
        if (!retine)
        {
            ctr++;
        }

        if (ctr >= 100)
        {
            pozitieCubY = gameObject.transform.position.y;
            ctr = 0;
            retine = true;
        }


        pozitieCub = gameObject.transform.position.x;


        if (!aiPierdutDAR && pierdut)
        {
            chenar.SetActive(true);
        }


        //Invincibilitate
        if (eInvincibil && i <=3)
        {

            Vector3 ultimaPozitie = new Vector3(pozitieCub, pozitieCubY, transform.position.z);
            transform.position = ultimaPozitie;

            contor++;
            myRigidbody.gravityScale = 0;
            bc2d.enabled = false;
            ;
            if (contor >= 20)
            {
                if (gameObject.GetComponent<Renderer>() != null)
                {
                    gameObject.GetComponent<Renderer>().enabled = false;
                    seVede = false;
                    altContor++;
                }
                if (altContor >= 20)
                {
                    seVede = true;
                    gameObject.GetComponent<Renderer>().enabled = true;
                    i++;
                    altContor = 0;
                    contor = 0;
                }
            }
        }
        if(i > 3)
        {
            myRigidbody.gravityScale = 6;
            bc2d.enabled = true;
            eInvincibil = false;
            a2aOaraNu = 1;
        }

        //Waves
        if (!pierdut)
        {

            scorAfisat.SetActive(true);
            pauseB.SetActive(true);


            transform.Translate(speed * Time.deltaTime, 0, 0);
            if(scor.scor == 20 && wave1 == false)
            {
                speed = speed + 0.5f;
                wave1 = true;
            }

            if (scor.scor == 60 && wave2 == false)
            {
                speed = speed + 0.5f;
                wave2 = true;
                wave1 = false;
            }

            if (scor.scor == 130 && wave3 == false)
            {
                speed = speed + 0.5f;
                wave3 = true;
                wave2 = false;
            }

            //Keyboard Input
            if (Input.GetKey("down"))
            {
                Mic();
            }

            if (Input.GetKey("up"))
            {
                Mare();

            }

       
        }

      

        anim.SetBool("Transf", seTrans);
        anim.SetBool("Rosu", red);
        anim.SetBool("Albastru", blue);
        anim.SetBool("Verde", green);
        anim.SetBool("Galben", yellow);
        anim.SetBool("Portocaliu", orange);
        anim.SetBool("Siclam", purple);
    }

    public void Mare()
    {
        seTrans = true;
    }

    public void Mic()
    {
        seTrans = false;
    }

    public void CameraShake()
    {
       // for(int k = 0; k <= 7; k++ )
        
            shakePos = new Vector3(UnityEngine.Random.Range(-1, 1), UnityEngine.Random.Range(-1, 1), camera.transform.position.z);
        
    }


    public void DEAD()
    {
        //camera.GetComponent<Camera>().fieldOfView += Time.deltaTime * 4;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!eInvincibil)
        {
            if (other.gameObject.tag == "punctMic" && seTrans == false)
            {
                Instantiate(pctm, new Vector3(other.gameObject.transform.position.x + 1f, other.gameObject.transform.position.y - 1f, transform.position.z), transform.rotation);
                FindObjectOfType<AudioManager>().PlaySound("FormaMica");
            }
            else if (other.gameObject.tag == "punctMic" && seTrans == true)
            {
                //Application.LoadLevel(Application.loadedLevel);
                //CameraShake();
                dead = true;
                inima.SetActive(true);
                pierdut = true;
                pauza.SetActive(false);
            }

            if (other.gameObject.tag == "punctMare" && seTrans == true)
            {
                Instantiate(pctM, new Vector3(other.gameObject.transform.position.x + 1f, other.gameObject.transform.position.y - 0.5f, transform.position.z), transform.rotation);
                FindObjectOfType<AudioManager>().PlaySound("FormaMare");
            }
            else if (other.gameObject.tag == "punctMare" && seTrans == false)
            {
                //Application.LoadLevel(Application.loadedLevel);
                //CameraShake();
                dead = true;
                inima.SetActive(true);
                pierdut = true;
                pauza.SetActive(false);
            }

            if (other.gameObject.tag == "partejos" || other.gameObject.tag == "partesus" || other.gameObject.tag == "partesusdubla")
            {
                //Application.LoadLevel(Application.loadedLevel);
                //CameraShake();
                dead = true;
                inima.SetActive(true);
                pierdut = true;
                pauza.SetActive(false);
            }
        }

    }
}
