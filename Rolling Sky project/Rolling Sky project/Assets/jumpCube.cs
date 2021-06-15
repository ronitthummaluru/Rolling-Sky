using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpCube : MonoBehaviour
{
    Rigidbody rb;
    public GameObject sphere;
    bool collide = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (collide)
        {
            rb.AddRelativeForce(new Vector3(0.0f, 15f, 0.0f));
            collide = false;

        }

    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.Equals(sphere)) {
            rb.AddForce(new Vector3(0.0f,200f,0.0f));
        }
       
        Debug.Log(collide);
        
    }
}
