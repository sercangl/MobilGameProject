using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ttime_sphere : MonoBehaviour
{
    float ttime = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ttime = Time.time;
        ttime = ttime % 4;

        if (ttime > 0 && ttime < 2)
        {
            transform.Translate(new Vector3(-4, 0, 0) * Time.deltaTime);
            // Debug.Log(ttime);

        }

        else if (ttime > 2 && ttime < 4)
        {
            transform.Translate(new Vector3(4, 0,0) * Time.deltaTime);

        }
    /*    else if (ttime > 3 && ttime < 4)
        {
            transform.Translate(new Vector3(0, 0, -4) * Time.deltaTime);

        }
        */

    }
}
