using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
 
     public Transform firePoint;
     public GameObject BulletPrefab;
     public float cooldown = 0.5f;
     private int fireRate = 3;
 
     public float bulletForce = 10f;
  
     void Update()
     {
         if (Input.GetButtonDown("Fire1") && cooldown <= 0)
         {
             Shoot();
             fireRate--;
             if(fireRate == 0){
             	cooldown = 0.5f;
             	fireRate = 3;
             }
             
         }
         cooldown -= Time.deltaTime;
     }
 	
     void Shoot()
     {
     
         GameObject bullet = Instantiate(BulletPrefab, firePoint.position, firePoint.rotation);
         Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
         rb.AddForce(firePoint.right * bulletForce, ForceMode2D.Impulse);
         Destroy(bullet, 3f);
         
     }
 }