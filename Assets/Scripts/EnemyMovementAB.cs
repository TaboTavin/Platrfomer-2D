using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementAB : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;

    public float speed = 5f;
    private Transform targetPoint;

    // Seek Vars
    public Transform target;
    public float speedBetweenPoints = 5f;

    public float seekDistance = 2f;

    private void Start()
    {
        targetPoint = pointA;
    }

    public void Update()
    {
        MoveToPoints();
        Seek();
    }

    void MoveToPoints()
    {
        if (transform.position == targetPoint.position)
        {
            // Si el enemigo llega al punto A cambia al B y viceversa
            targetPoint = (targetPoint == pointA) ? pointB : pointA;
        }

        // Mover al enemigo hacia el punto actual
        float step = speed * Time.deltaTime; 
        transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, step);
    }

    void Seek()
    {
        Vector3 seekVector = target.position - transform.position;
        float distanceToTarget = seekVector.magnitude;



        if (distanceToTarget < seekDistance)
        {
            // DrawRay
            Debug.DrawRay(transform.position, seekVector, Color.magenta);
            Vector3 seekPosition = Vector3.Lerp(transform.position, target.position, Time.deltaTime);
            transform.position = seekPosition;
        }
    }
}
