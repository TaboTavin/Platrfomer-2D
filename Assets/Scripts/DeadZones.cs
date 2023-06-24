using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZones : MonoBehaviour
{
    public CharacterHealth characterHealth;
    public int damageAmount = 7;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            characterHealth.TakeDamage(damageAmount);
            Debug.Log("Haz Muerto");
        }
    }
}