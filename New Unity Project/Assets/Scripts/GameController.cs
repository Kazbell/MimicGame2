using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NewBehaviourScript : MonoBehaviour
{
    public Text timeCounter;
    public GameObject gameOverPanel, hudContainer;
    public bool gamePlaying { get; private set; }

    private float startTime, elapsedTime;
    TimeSpan timePlaying;
    private void Start()
    {
        gamePlaying = true;
    }

    private void EndGame()
    {
        gamePlaying = false;
        Invoke("ShowGameOverScreen", 1.25f);
    }

    private void ShowGameOverScreen()
    {
        gameOverPanel.SetActive(true);
        hudContainer.SetActive(false);
    }


}
