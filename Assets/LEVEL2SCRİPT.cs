using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LEVEL2SCRİPT : MonoBehaviour
{
    float ttime = 1f;

    // Use this for initialization
    void Start()
    {


    }




    // Update is called once per frame
    void Update()
    {

        //      mov();

        ttime = Time.time;

        ttime = ttime % 4;


        if (ttime > 0 && ttime < 1)
        {
            transform.Translate(new Vector3(0, 0, -2) * Time.deltaTime);
            // Debug.Log(ttime);

        }

        else if (ttime > 1 && ttime < 3)
        {
            transform.Translate(new Vector3(0, 0, 2) * Time.deltaTime);

        }
        else if (ttime > 3 && ttime < 4)
        {
            transform.Translate(new Vector3(0, 0, -2) * Time.deltaTime);

        }



    }


}
