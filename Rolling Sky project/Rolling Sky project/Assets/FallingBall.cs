using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBall : MonoBehaviour
{
    public GameObject sphere;
    Rigidbody rb;
    Vector3 initialPos;
    Vector3 intialPos2;
    // Start is called before the first frame update
    void Start()
    {
        initialPos = sphere.transform.position;
        intialPos2 = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log((transform.position.x - sphere.transform.position.x));
        if((transform.position.x - sphere.transform.position.x) < .5f && (transform.position.x/ sphere.transform.position.x) > 0 && (transform.position.z - sphere.transform.position.z) < .5f && (transform.position.z / sphere.transform.position.z) > 0)
        {
            rb.useGravity = true;
           
        }

        if (transform.position.y < -10)
            Destroy(gameObject);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.Equals(sphere))
        {
            sphere.transform.position = initialPos;
        }
    }
}
