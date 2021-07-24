using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
     public GameObject hitEffect;
     public GameObject bulletClone;
 
     void OnCollisionEnter2D(Collision2D collision)
     {
         GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
  
         Destroy(bulletClone, 10);
         Destroy(gameObject);
     }
 
 }