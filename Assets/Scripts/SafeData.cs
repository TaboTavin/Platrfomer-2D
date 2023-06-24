using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// SetInt -- Entero
// SetFloat -- Decimales
// SetString -- Cadenas
// Get Int -- Consultar Entero
// GetFloast -- Consultar Decimal
// GetString -- Consultar Cadena

public class SafeData : MonoBehaviour
{
    public int score = 100;
    public int health = 100;

    public static SafeData sharedInstance;

    private void Awake()
    {
        if (sharedInstance == null)
            sharedInstance = this;
    }
    private void Start()
    {

        PlayerPrefs.SetInt("Score", score);
        PlayerPrefs.SetInt("Health", health);

    }

    private void OnDestroy()
    {
        PlayerPrefs.SetInt("Score", score);
        PlayerPrefs.SetInt("Health", health);

        Debug.Log("Score Final: " + score);
        Debug.Log("Health Final: " + health);
    }
}
