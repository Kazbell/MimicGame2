using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed = 1;
    // Use this for initialization
    void Start()
    {

    }
    void Update()
    {
        Vector3 move;
        GetComponent<Animator>().SetInteger("Direction", 4);

        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Animator>().SetInteger("Direction", 1);
            move = new Vector2(0, speed * Time.deltaTime);

            transform.position += move;
        }
        if (Input.GetKey(KeyCode.A))
        {

            move = new Vector2(speed * Time.deltaTime, 0);

            transform.position -= move;
        }
        if (Input.GetKey(KeyCode.D))
        {

            move = new Vector2(speed * Time.deltaTime, 0);

            transform.position += move;
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Animator>().SetInteger("Direction", 0);
            move = new Vector2(0, speed * Time.deltaTime);
            Debug.Log(move);

            transform.position -= move;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Animator>().SetInteger("Direction", 2); //imagine w is eat
        }
    }
}
