using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    void Startup()
    {

    }
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        { transform.Translate(Vector3.up * Time.deltaTime * 20); }

        else if (Input.GetKey(KeyCode.DownArrow))
        { transform.Translate(Vector3.down * Time.deltaTime * 20); }

        else if (Input.GetKey(KeyCode.LeftArrow))
        { transform.Translate(Vector3.right * Time.deltaTime * 20); }

        else if (Input.GetKey(KeyCode.RightArrow))
        { transform.Translate(Vector3.left * Time.deltaTime * 20); }
    }
}