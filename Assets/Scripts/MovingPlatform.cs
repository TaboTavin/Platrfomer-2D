using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Transform targetPosition;
    private bool isMoving = false;


    public GameObject Player;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player") && !isMoving)
        {
            isMoving = true;
            Player.transform.SetParent(this.transform, true);
            StartCoroutine(MovePlatform());   
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Player.transform.SetParent(null);
        }
    }

    private IEnumerator MovePlatform()
    {
        Vector3 startPosition = transform.position;
        Vector3 target = targetPosition.position;

        float distance = Vector3.Distance(startPosition, target);
        float currentDistance = 0f;
        float t = 0f;

        while(currentDistance < distance)
        {
            t += Time.deltaTime * moveSpeed / distance;
            transform.position = Vector3.Lerp(startPosition, target, t);
            currentDistance = Vector3.Distance(transform.position, startPosition);

            yield return null;
        }

        isMoving = false;
    }
}
