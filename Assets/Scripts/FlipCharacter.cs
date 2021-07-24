using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipCharacter : MonoBehaviour
{
    private Vector3 startScale;

    void Start()
    {
         startScale = transform.localScale;

    }

    void Update()
    {
        Vector3 scale = transform.localScale;
        if(transform.position.x < (Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position)).x){
            scale.x = startScale.x;
        }
        else
        {
            scale.x = -startScale.x;
        }

        transform.localScale = scale;
    }
}
