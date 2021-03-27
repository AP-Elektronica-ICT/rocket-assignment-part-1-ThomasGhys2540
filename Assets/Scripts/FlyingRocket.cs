using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingRocket : MonoBehaviour
{
    public Rigidbody Rocket;
    public float Speed;
    public float Rotation;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Rocket.AddRelativeForce(new Vector3(0, Speed * Time.deltaTime, 0));
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Rocket.transform.Rotate(0, 0, Rotation * Time.deltaTime, Space.Self);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Rocket.transform.Rotate(0, 0, -Rotation * Time.deltaTime, Space.Self);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Rocket.transform.Rotate(Rotation * Time.deltaTime, 0, 0, Space.Self);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Rocket.transform.Rotate(-Rotation * Time.deltaTime, 0, 0, Space.Self);
        }
    }
}
