using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int Health = 100;
    public Image healthBar;

    private float fireTimeDelay = 0;
    private float waterTimeDelay = 0;
    private float enemyTimeDelay = 0;

    void Update()
    {
        if (fireTimeDelay > 0)
        {
            fireTimeDelay -= Time.deltaTime;
        }
        if(fireTimeDelay < 0)
        {
            fireTimeDelay = 0;
        }

        if (waterTimeDelay > 0)
        {
            waterTimeDelay -= Time.deltaTime;
        }
        if (waterTimeDelay < 0)
        {
            waterTimeDelay = 0;
        }

        if (enemyTimeDelay > 0)
        {
            enemyTimeDelay -= Time.deltaTime;
        }
        if (enemyTimeDelay < 0)
        {
            enemyTimeDelay = 0;
        }

        healthBar.fillAmount = Mathf.Clamp(Health / 100f, 0, 1f);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Fire" && fireTimeDelay <= .01f)
        {
            fireTimeDelay = 1;
            Health -= 35;
        }

        if (collision.gameObject.tag == "Water" && waterTimeDelay <= .01f)
        {
            waterTimeDelay = .5f;
            Health -= 5;
        }

        if (collision.gameObject.tag == "Enemy" && enemyTimeDelay <= .01f)
        {
            enemyTimeDelay = .5f;
            Health -= 25;
        }
        if (collision.gameObject.tag == "Electric")
        {
            Health -= 100;
        }
        if (collision.gameObject.tag == "BossBullet" ){
        	Health -= 30;
        }
    }
}
