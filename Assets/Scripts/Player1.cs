using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public float speed;
    public float distance;

    // Update is called once per frame
    void Update()
    {
        playerMove();
    }

    void FixedUpdate()
    {
        AlertPlayer();
    }

    void playerMove()
    {
        //move right, left, up, down
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        //rotate left, right
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * 20f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * 20f * Time.deltaTime);
        }
    }

    void AlertPlayer()
    {
        Ray r = new Ray(transform.position, Vector3.forward);
        if(Physics.Raycast(r, distance))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
