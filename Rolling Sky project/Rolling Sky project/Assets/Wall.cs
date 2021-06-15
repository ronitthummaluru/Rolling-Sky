using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public GameObject sphere;
    Vector3 initialPos;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        initialPos = transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
        if(sphere.transform.position.z > transform.position.z)
        {
            time += Time.deltaTime;
            if(time > 1 && time < 2)
            {
                transform.Translate(Vector3.down);
               
            }
          
        }
        else
        {
            transform.position = initialPos;
            time = 0;
        }
    }
}
