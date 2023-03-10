using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

    public int contor;
    public float pozitie = 3f;

    public GameObject punct;
    public GameObject foc;

    private int SJ;
    private int DN;

    private Cub cub;

    private int spawnSpeed;

    public int constanta = 0;

	void Start () {
        cub = FindObjectOfType<Cub>();
        spawnSpeed = 45;

    }
	

	void Update () {
        if (!cub.pierdut)
        {
            contor++;
            if (contor % spawnSpeed == 0)
            {
                Instantiate(punct, new Vector3(pozitie, 0.3f, transform.position.z), transform.rotation);
                constanta += 1;
                DN = UnityEngine.Random.Range(0, 10);
                SJ = UnityEngine.Random.Range(0, 10);
                if (DN == 3)
                {
                    if(SJ <= 5) Instantiate(foc, new Vector3(pozitie - 0.3f, -0.65f, transform.position.z), transform.rotation);
                    if(SJ > 5) Instantiate(foc, new Vector3(pozitie - 0.3f, 0.01f, transform.position.z), transform.rotation);
                }
                pozitie += 2.395f;
            }

            if(cub.wave1 == true)
            {
                spawnSpeed = 35;
            }

            if (cub.wave2 == true)
            {
                spawnSpeed = 23;
            }
            if (cub.wave3 == true)
            {
                spawnSpeed = 14;
            }
        }
	}
}
