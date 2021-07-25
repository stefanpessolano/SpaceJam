using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossArm : MonoBehaviour
{
    public GameObject player;
    public GameObject orb;
    public GameObject barrel;

    public float angle;
    public float offset;

    public float cooldown = 1f;
    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < 24)
        {
            if (cooldown <= 0)
            {
                GameObject bossOrb = Instantiate(orb, barrel.transform.position, barrel.transform.rotation);
                Destroy(bossOrb, 3);
                cooldown = 1f;

            }
            cooldown -= Time.deltaTime;

            angle = Mathf.Atan2(player.transform.position.y - transform.position.y, player.transform.position.x - transform.position.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle + offset));
        }
    }
}
