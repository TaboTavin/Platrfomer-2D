using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FleeBehavior : MonoBehaviour
{
    public Transform target;
    //public float speed = 5f;
    public float fleeDistance = 5f;

    private void Update()
    {
        Flee();
    }

    private void Flee()
    {
        Vector3 fleeVector = transform.position - target.position;

        if(fleeVector.magnitude < fleeDistance)
        {
            fleeVector = fleeVector.normalized * fleeDistance;
            Vector3 fleePosition = target.position + fleeVector;

            transform.position = fleePosition;

        }
    }
}
