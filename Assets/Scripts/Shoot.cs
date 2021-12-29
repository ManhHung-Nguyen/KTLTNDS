using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public bool shoot = false;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        shoot = false;
        if (Input.GetKey(KeyCode.Space))
        {
            shoot = true;
        }
        if (shoot)
        {
            if (!gameObject.GetComponent<ParticleSystem>().isPlaying)
            {
                gameObject.GetComponent<ParticleSystem>().Play();
            }
        }
        else
        {
            if (gameObject.GetComponent<ParticleSystem>().isPlaying)
            {
                gameObject.GetComponent<ParticleSystem>().Stop();
            }
        }

    }
}
