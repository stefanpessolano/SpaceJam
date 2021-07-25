using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompanionBullet : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Companion" && collision.gameObject.tag != "Bullet")
        {
            Destroy(gameObject);
        }
    }

}