using UnityEngine;
using System.Collections;

public class red : MonoBehaviour
{

    private Cub cub;


    void Start()
    {
        cub = FindObjectOfType<Cub>();

        cub.red = true;
    }


    void Update()
    {

        cub.red = true;

    }
}

