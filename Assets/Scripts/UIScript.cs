using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class UIScript : MonoBehaviour
{

    public Text scoreNum;
    static int score;
    private object losePanel;



    // Use this for initialization

    void Start()
    {

    }



    public static void updateScore(int amount)

    {
        score += amount;
    }



    // Update is called once per frame

    void Update()

    {
        scoreNum.text = score + "";





        if (shipControl.IsDead)

        {
            losePanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}