using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Lerp(this.transform.position.x, player.transform.position.x, 5 * Time.deltaTime),
                                        Mathf.Lerp(this.transform.position.y, player.transform.position.y, 5 * Time.deltaTime),
                                        player.transform.position.z - 10);
    }
}
