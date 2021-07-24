using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int Health = 100;

    private float timeDelay = 0;
    void Update()
    {
        if (timeDelay > 0)
        {
            timeDelay -= Time.deltaTime;
        }
        else
        {
            timeDelay = 0;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Fire" && timeDelay <= 0)
        {
            timeDelay = 1;
            Health -= 5;
        }
    }
}
