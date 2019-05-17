using UnityEngine;
using System.Collections;

public class tTime : MonoBehaviour {
   
   
	// Use this for initialization
	void Start () {

        
    }


    

    // Update is called once per frame
    void Update () {

        
        float ttime = 0f;

        
       // ttime = Time.time - ttime;

        ttime = Time.time;

        ttime = ttime % 4;
        

        if (ttime > 0 && ttime < 1)
        {
            transform.Translate(new Vector3(-5, 0, 0) * Time.deltaTime);


        }

        else if (ttime > 1 && ttime < 3)
        {
            transform.Translate(new Vector3(5, 0, 0) * Time.deltaTime);

        }
        else if (ttime > 3 && ttime < 4)
        {
            transform.Translate(new Vector3(-5, 0, 0) * Time.deltaTime);

        }



    }



}
