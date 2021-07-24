using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public int thrust = 50;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w") || Input.GetKey("up"))
        {
            rigidbody2D.AddForce(transform.right * thrust);
        }
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rigidbody2D.AddForce(transform.up * thrust);
        }
        if (Input.GetKey("s") || Input.GetKey("down"))
        {
            rigidbody2D.AddForce(transform.right * -thrust);
        }
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rigidbody2D.AddForce(transform.up * -thrust);
        }

    }
}
