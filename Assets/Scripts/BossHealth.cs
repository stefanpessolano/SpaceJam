using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI;

public class BossHealth : MonoBehaviour
{
    public int Health = 5000;
    public Image healthBar;
    public Animator animator;
    public GameObject arm1;
    public GameObject arm2;
    public GameObject health1;
    public GameObject health2;
    void Update()
    {
    		healthBar.fillAmount = Mathf.Clamp(Health / 2000f, 0, 1f);
        if (Health <= 0)
        {
            animator.SetBool("death", true);
            arm1.SetActive(false);
            arm2.SetActive(false);
            health1.SetActive(false);
            health2.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Bullet")
        {
            Health -= 10;
        }
    }
}
