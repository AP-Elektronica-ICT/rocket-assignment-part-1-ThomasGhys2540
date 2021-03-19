using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingRocket : MonoBehaviour
{
    public int Speed;
    public Rigidbody Rocket;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Rocket.AddForce(new Vector3(0, Speed * Time.deltaTime, 0));
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Rocket.AddForce(new Vector3(-Speed * Time.deltaTime, 0, 0));
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Rocket.AddForce(new Vector3(Speed * Time.deltaTime, 0, 0));
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Rocket.AddForce(new Vector3(0, 0, Speed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Rocket.AddForce(new Vector3(0, 0, -Speed * Time.deltaTime));
        }
    }
}
