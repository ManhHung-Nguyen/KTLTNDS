using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAudio : MonoBehaviour
{
    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.Play(0);
    }

    // Update is called once per frame
    void Update()
    {
        audio.Pause();
        if (Input.GetKey(KeyCode.Space))
        {
            audio.UnPause();
        }

    }
}
