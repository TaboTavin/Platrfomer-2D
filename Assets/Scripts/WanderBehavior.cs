using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderBehavior : MonoBehaviour
{
    public float range = 5f;
    public float speed = 5f;

    private Vector3 targetPosition;

    private void Start()
    {
        SetRandomTargetPosition();
    }

    void SetRandomTargetPosition()
    {
        targetPosition = transform.position + Random.insideUnitSphere * range;
        targetPosition.y = transform.position.y;
        targetPosition.z = transform.position.z;
    }

    private void Update()
    {
        Wander();
    }

    void Wander()
    {
        if (Vector3.Distance(transform.position, targetPosition) <= 0.1f)
            SetRandomTargetPosition();

        else
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }
}
