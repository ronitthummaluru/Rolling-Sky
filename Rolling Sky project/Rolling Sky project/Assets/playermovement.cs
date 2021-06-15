using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class playermovement : MonoBehaviour
{
    Rigidbody rig;
    public TextMeshProUGUI text;
    public GameObject obj;
    float moveSpeed = 200f;
    float time = 45f;
    public GameObject platform;
    bool useTorque = true;
    bool win = false;
    Vector3 jump = new Vector3(0.0f, 50,0.0f);
    Vector3 initialPos;

    void Start()
    {
        initialPos = transform.position;
        rig = GetComponent<Rigidbody>();
        text = GameObject.Find("TimerText").GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        if(transform.position.y < -8)
        {
            transform.position = initialPos;
        }
        time -= Time.deltaTime;
        text.SetText("Time Remaining: " + time);
        if(win)
            text.SetText("GAME OVER YOU LOSE");
        else if (time - Time.deltaTime < 0)
        {
           text.SetText("GAME OVER YOU LOSE");
        }

    }

    public void Control()
    {
        if (useTorque) 
        {
            rig.AddTorque(new Vector3(Input.GetAxisRaw("Vertical") * moveSpeed, 0f, -Input.GetAxisRaw("Horizontal")) * moveSpeed);
        }

        if (Input.GetKeyDown("space") && rig.transform.position.y <= 1.5f )
        {
            if (transform.position.z < 52 || transform.position.z > 69)
            {

                Debug.Log("jump");
                rig.AddForce(jump);
            }
           
        }

    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.Equals(platform))
        {
            rig.AddForce(jump);
            Debug.Log("Collide w platform");
        }

        if (collision.gameObject.Equals(obj) && time > 0)
        {
            win = true;
        }

    }
    void FixedUpdate()
    {
        Control();
    }
}
