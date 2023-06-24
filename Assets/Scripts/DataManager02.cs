using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager02 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int score = PlayerPrefs.GetInt("Score");
        int health = PlayerPrefs.GetInt("Health");

        Debug.Log("Level 02 - Health: " + health);
        Debug.Log("Level 02 - Score: " + score);
    }
}
