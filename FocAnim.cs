using UnityEngine;
using System.Collections;

public class FocAnim : MonoBehaviour {
    public float speed;
    public float y;
    public float y_;
    public bool schimba;
    public bool sus;
    public bool jos;

    void Start()
    {
        y = gameObject.transform.position.y;
        y_ = y;
        schimba = false;

    }


    void Update()
    {
        y = gameObject.transform.position.y;
        if (!schimba)
        {
            if (y >= y_)
            {
                transform.Translate(0, speed * Time.deltaTime, 0);
            }
            else if (y < y_)
            {
                transform.Translate(0, -speed * Time.deltaTime, 0);
            }

            if (y > y_ + 0.05)
            {
                schimba = true;
            }
        }

        if (schimba)
        {

            if (y > y_ + 0.05)
            {
                jos = true;
                sus = false;
            }
            else if (y < y_ - 0.05)
            {
                jos = false;
                sus = true;
            }

            if (sus)
            {
                transform.Translate(0, speed * Time.deltaTime, 0);
            }
            if (jos)
            {
                transform.Translate(0, -speed * Time.deltaTime, 0);
            }
        }
    }
}
