using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossArm : MonoBehaviour
{
    public GameObject player;
    public float angle;
    public float offset;
    void Update()
    {
        angle = Mathf.Atan2(player.transform.position.y - transform.position.y, player.transform.position.x - transform.position.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle + offset));
    }
}
