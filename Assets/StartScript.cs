using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	

    public void play()
    {
        SceneManager.LoadScene(1);
    }

    public void exit()
    {
        Application.Quit();
        //SceneManager.LoadScene(3);
    }

    public void level1()
    {
        SceneManager.LoadScene(2);
    }


    public void level2()
    {
        SceneManager.LoadScene(3);
    }

    public void level3()
    {
        SceneManager.LoadScene(4);
    }

    public void back()
    {
        SceneManager.LoadScene(0);
    }


    // Update is called once per frame
    void Update () {
		
	}
}
