using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipNonPlayer : MonoBehaviour
{
    private Vector3 startScale;
    public GameObject Player;

    void Start()
    {
        startScale = transform.localScale;

    }

    void Update()
    {
        Vector3 scale = transform.localScale;
        if (transform.position.x < Player.transform.position.x)
        {
            scale.x = startScale.x;
        }
        else
        {
            scale.x = -startScale.x;
        }

        transform.localScale = scale;
    }
}
