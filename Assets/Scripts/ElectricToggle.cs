using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricToggle : MonoBehaviour
{
    private bool electricOn = false;

    public GameObject onTile;

    private float electricOffDelay = 3;
    private float electricOnDelay = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (electricOffDelay > 0 && !electricOn)
        {
            electricOffDelay -= Time.deltaTime;
        }
        if (electricOffDelay < 0)
        {
            electricOn = true;
            electricOffDelay = 3;
        }

        if (electricOnDelay > 0 && electricOn)
        {
            electricOnDelay -= Time.deltaTime;
        }
        if (electricOnDelay < 0)
        {
            electricOn = false;
            electricOnDelay = 2;
        }

        if (electricOn)
        {
            onTile.SetActive(true);
        }
        else
        {
            onTile.SetActive(false);
        }
    }
}
