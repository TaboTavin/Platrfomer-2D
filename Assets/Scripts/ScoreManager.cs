using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    int score = 100;
    string playerName = "Chris";

    public void SafeData()
    {
        PlayerPrefs.SetInt("Score", score);
        PlayerPrefs.SetString("PlayerName", playerName);
    }

    public void PrintData()
    {
        int loadedScore = PlayerPrefs.GetInt("Score");
        string loadedPlayerName = PlayerPrefs.GetString("PlayerName");
        Debug.Log("Player Points: " + loadedScore);
        Debug.Log("Name: " + loadedPlayerName);
    }

    public void Start()
    {
        SafeData();
        PrintData();
    }

}
