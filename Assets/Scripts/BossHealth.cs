using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealth : MonoBehaviour
{
    public int Health = 10;
    public Image healthBar; 
    
    void Update()
    {
    		healthBar.fillAmount = Mathf.Clamp(Health / 10f, 0, 1f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Bullet")
        {
            Health--;
        }
    }
}
