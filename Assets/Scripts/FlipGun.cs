using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipGun : MonoBehaviour
{
    private Vector3 startScale;
    public GameObject player;

    void Start()
    {
         startScale = transform.localScale;

    }

    void Update()
    {
        Vector3 scale = transform.localScale;
        if(player.transform.position.x <= (Input.mousePosition - Camera.main.WorldToScreenPoint(player.transform.position)).x){
            scale.x = startScale.x;
            scale.y = startScale.y;
        }
        else
        {
            scale.x = -startScale.x;
            scale.y =  -startScale.y;
        }

        transform.localScale = scale;
    }
}
