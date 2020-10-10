using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed = 4;
    public bool action;

    // Use this for initialization
    void Start()
    {
        action = false;
    }
    void FixedUpdate()
    {
        Vector3 move;
        GetComponent<Animator>().SetInteger("Direction", 4);

        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Animator>().SetInteger("Direction", 1);
            move = new Vector2(0, speed * Time.deltaTime);
            action = true;
            transform.position += move;
        }
        if (Input.GetKey(KeyCode.A))
        {

            move = new Vector2(speed * Time.deltaTime, 0);
            action = true;
            transform.position -= move;
        }
        if (Input.GetKey(KeyCode.D))
        {

            move = new Vector2(speed * Time.deltaTime, 0);
            action = true;
            transform.position += move;
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Animator>().SetInteger("Direction", 0);
            move = new Vector2(0, speed * Time.deltaTime);
            Debug.Log(move);
            action = true;
            transform.position -= move;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            action = true;
            GetComponent<Animator>().SetInteger("Direction", 2); //imagine w is eat
        }
    }
}
