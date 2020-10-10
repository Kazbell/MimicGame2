using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Sprite Up;
    public Sprite Down;
    public Sprite Right;
    public Sprite Left;
    public float speed = 1;
    // Use this for initialization
    void Start()
    {

      
    }

    public float panSpeed = 20f;

    void Update()
    {
        Vector3 move;

        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<SpriteRenderer>().sprite = Up;
            move = new Vector2(0, speed * Time.deltaTime);

            transform.position += move;
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<SpriteRenderer>().sprite = Left;
            move = new Vector2(speed * Time.deltaTime, 0);

            transform.position -= move;
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<SpriteRenderer>().sprite = Right;
            move = new Vector2(speed * Time.deltaTime, 0);

            transform.position += move;
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<SpriteRenderer>().sprite = Down;
            move = new Vector2(0, speed * Time.deltaTime);

            transform.position -= move;
        }
    }
}
