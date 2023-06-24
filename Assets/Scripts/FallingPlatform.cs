using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    public float fallDelay = 1f;
    private Rigidbody2D platformRigidbody;
    private BoxCollider2D boxCollider;


    private void Start()
    {
        platformRigidbody = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();

        platformRigidbody.isKinematic = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Invoke("Fall", fallDelay);
            
        }
    }

    private void Fall()
    {
        platformRigidbody.isKinematic = false;
        Destroy(boxCollider);
    }
}
