using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCube3 : MonoBehaviour
{
    public GameObject sphere;
    public GameObject platform;
    public PlatformCollision platCol;
    
    Vector3 initialPos;
    Vector3 intialPos2;
    // Start is called before the first frame update
    void Start()
    {
        initialPos = sphere.transform.position;
        intialPos2 = gameObject.transform.position;
        platCol = GetComponent<PlatformCollision>();
    }

    // Update is called once per frame
    void Update()
    {
        
        //Debug.Log(platCol.returnHit());
        if (sphere.transform.position.z > 52)
        {
           // Instantiate(gameObject);
            transform.Translate(Vector3.back * .1f, Space.World);
            transform.Rotate(new Vector3(0, 0, -300) * Time.deltaTime);
            if (transform.position.z < 52)
                Destroy(gameObject);
        }
        else
        {
            transform.position = intialPos2;
        }

        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.Equals(sphere))
        {
            sphere.transform.position = initialPos;
        }

        
    }
}
