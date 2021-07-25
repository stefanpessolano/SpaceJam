using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public float thrust = 50;
    public float maxSpeed = 3.2f;
    public Animator animator;

    bool windOrb = false;
    bool fireOrb = false;
    bool electricOrb = false;
    bool waterOrb = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if(rigidbody2D.velocity.magnitude > 1)
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }

        if (rigidbody2D.velocity.magnitude > maxSpeed)
        {
            rigidbody2D.velocity = rigidbody2D.velocity.normalized * maxSpeed;
        }

        if (Input.GetKey("w") || Input.GetKey("up"))
        {
            rigidbody2D.AddForce(transform.up * thrust);
        }
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rigidbody2D.AddForce(transform.right * -thrust);
        }
        if (Input.GetKey("s") || Input.GetKey("down"))
        {
            rigidbody2D.AddForce(transform.up * -thrust);
        }
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rigidbody2D.AddForce(transform.right * thrust);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "windPedestal")
        {
            windOrb = true;
            Destroy(collision.gameObject, 1f);
        }
        if (collision.gameObject.tag == "electricPedestal")
        {
            electricOrb = true;
            Destroy(collision.gameObject, 1f);
        }
        if (collision.gameObject.tag == "firePedestal")
        {
            fireOrb = true;
            Destroy(collision.gameObject, 1f);
        }
        if (collision.gameObject.tag == "waterPedestal")
        {
            waterOrb = true;
            Destroy(collision.gameObject, 1f);
        }
    }
}
