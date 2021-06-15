using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCube : MonoBehaviour
{
    public GameObject sphere;
    float rand;
    Vector3 initialPos;
    // Start is called before the first frame update
    void Start()
    {
        initialPos = sphere.transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
       
        transform.Rotate(new Vector3(0, Random.Range(50,100), 0)*Time.deltaTime);
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.Equals(sphere))
        {
            sphere.transform.position = initialPos;
        }
    }
}
