using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    Animator anima;

    public float moveSpeed = 5;
    public bool shoot = false;
    public float turnSpeed = 50;
    // Start is called before the first frame update
    void Start()
    {
        anima = gameObject.GetComponent<Animator>();
        anima.SetInteger("State", 0);
    }
    // Update is called once per frame
    void Update()
    {
        anima.SetInteger("State", 0);
        bool Shoot_Walk = ((Input.GetKey(KeyCode.UpArrow)||Input.GetKey(KeyCode.DownArrow)) && Input.GetKey(KeyCode.Space));
        bool Shoot_Rotate = ((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)) && Input.GetKey(KeyCode.Space));
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(-Vector3.forward * Time.deltaTime * 10);
            anima.SetInteger("State", 2);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * 10);
            anima.SetInteger("State", 2);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(-Vector3.up * Time.deltaTime * turnSpeed);
            anima.SetInteger("State", 2);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed);
            anima.SetInteger("State", 2);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            anima.SetInteger("State", 1);
        }
        if (Shoot_Walk || Shoot_Rotate)
        {
            anima.SetInteger("State", 3);
        }
      
    }
}
