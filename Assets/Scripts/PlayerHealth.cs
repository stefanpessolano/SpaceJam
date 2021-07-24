using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int Health = 100;
    public Image healthBar;

    private float timeDelay = 0;
    void Update()
    {
        if (timeDelay > 0)
        {
            timeDelay -= Time.deltaTime;
        }
        if(timeDelay < 0)
        {
            print("RAN");
            timeDelay = 0;
        }
        print(timeDelay);
        healthBar.fillAmount = Mathf.Clamp(Health / 100f, 0, 1f);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Fire" && timeDelay <= .01f)
        {
            timeDelay = 1;
            Health -= 15;
        }
    }
}
