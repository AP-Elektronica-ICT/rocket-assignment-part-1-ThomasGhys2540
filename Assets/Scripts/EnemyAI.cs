using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float MoveSpeed;
    public int RotationSpeed;
    public float Range;
    public Transform Target;
    public Transform EnemyTransform;
    public Rigidbody Enemy;

    private void Update()
    {
        EnemyTransform.LookAt(Target);

        if (Vector3.Distance(EnemyTransform.position, Target.position) <= Range)
        {
            EnemyTransform.position += EnemyTransform.forward * MoveSpeed;
        }
    }
}
