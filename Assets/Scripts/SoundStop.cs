using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundStop : MonoBehaviour
{
    // Start is called before the first frame update
    public string stop_sound;
    public string start_sound;
    void Start()
    {
        FindObjectOfType<AudioManager>().Stop(stop_sound);
        FindObjectOfType<AudioManager>().Play(start_sound);
    }
}
