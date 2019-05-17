using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour {
    private Vector3 initialpos;
    public int health = 3;
    
    public float moveSpeed;

    


    void Start ()
    {
        moveSpeed = 5f;
	}


    private void Awake()
    {
        initialpos = transform.position;

    }
    // Update is called once per frame
    void Update () 
    {
        transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
  
         
}

    public void OnTriggerEnter(Collider other)
    {

        transform.position = initialpos;
        health--;

        if (other.gameObject.CompareTag("final"))
        {
            SceneManager.LoadScene(3);
            
        }
        if (other.gameObject.CompareTag("final2"))
        {
            SceneManager.LoadScene(6);

        }

        if (health == 0)
        {
            SceneManager.LoadScene(5);
        }
        if (other.gameObject.CompareTag("Space"))
        {
            SceneManager.LoadScene(5);

        }
    }
}
