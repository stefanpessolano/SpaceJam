using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpDestroyer : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(gameObject, 0.5f);
        }
    }

}
