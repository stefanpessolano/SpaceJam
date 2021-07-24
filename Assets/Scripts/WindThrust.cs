using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindThrust : MonoBehaviour
{
    public int windThrust = 150;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wind")
        {
            GetComponent<Rigidbody2D>().AddForce(collision.gameObject.transform.up * windThrust);
        }
    }
}
