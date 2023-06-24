using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealth : MonoBehaviour
{
    //public int maxHealth = 10;
    private int currentHealth;

    private void Start()
    {
        //currentHealth = maxHealth;
        //Debug.Log(currentHealth);
    }

    public void TakeDamage(int damageAmount)
    {
        //currentHealth -= damageAmount;

        SafeData.sharedInstance.health -= damageAmount;

        //Debug.Log("Haz Muerto");
        //Debug.Log(currentHealth);
        //Comprobar si el personje murio, reproducir sonidos.

       
    }

    public void Heal(int healAmount)
    {
        

        //Limitamos la vida maxima, reproducir sonidos.
        if(currentHealth < 10)
        {
            currentHealth += healAmount;
        }
        

    }

}
