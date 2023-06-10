using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZones : MonoBehaviour
{

    public GameObject Player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Haz Muerto");
            Destroy(Player, 3f);
            
        }
    }
}