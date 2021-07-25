using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
 
     public Transform firePoint;
     public GameObject BulletPrefab;
     public float cooldown = 0.5f;
     private int fireRate = 3;
    public bool heavy = false;
     public float bulletForce = 10f;
    public GameObject gun;
    public GameObject heavyGun;
  
     void Update()
     {
        //if (Input.GetKeyDown("1"))
       // {
       //     heavy = !heavy;
        //}
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

        if (heavy)
        {
            gun.GetComponent<SpriteRenderer>().enabled = false;
            heavyGun.GetComponent<SpriteRenderer>().enabled = true;

            gun.GetComponent<Shooting>().enabled = false;
            heavyGun.GetComponent<Shooting>().enabled = true;
        }
        else
        {
            gun.GetComponent<SpriteRenderer>().enabled = true;
            heavyGun.GetComponent<SpriteRenderer>().enabled = false;

            gun.GetComponent<Shooting>().enabled = true;
            heavyGun.GetComponent<Shooting>().enabled = false;
        }
     }
 	
     void Shoot()
     {
     
         GameObject bullet = Instantiate(BulletPrefab, firePoint.position, firePoint.rotation);
         Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        if (!heavy)
        {
            rb.AddForce(firePoint.right * bulletForce, ForceMode2D.Impulse);
        }
        else
        {
            rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        }
         Destroy(bullet, 5f);
     }
 }