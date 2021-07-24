using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompanionMove : MonoBehaviour
{
    public GameObject player;
    public int moveSpeed = 1;
    public int followDistance = 2;
    void Update()
    {
        //transform.right = player.transform.position - transform.position;

        if (Vector3.Distance(transform.position, player.transform.position) > followDistance)
        {
            //transform.position += transform.right * moveSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, Time.deltaTime * moveSpeed);
        }
    }
}
