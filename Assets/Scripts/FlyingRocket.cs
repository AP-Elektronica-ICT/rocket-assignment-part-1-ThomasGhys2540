using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingRocket : MonoBehaviour
{
    public Transform Rocket;
    public float Speed;
    public float Rotation;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Rocket.position += Rocket.up * Speed;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Rocket.Rotate(0, 0, Rotation * Time.deltaTime, Space.Self);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Rocket.Rotate(0, 0, -Rotation * Time.deltaTime, Space.Self);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Rocket.Rotate(Rotation * Time.deltaTime, 0, 0, Space.Self);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Rocket.Rotate(-Rotation * Time.deltaTime, 0, 0, Space.Self);
        }
    }
}
