﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Betting : MonoBehaviour
{
    public GameObject[] Rows;
    public Text betText;
    public Text balanceText;
    public Text[] winText;
    float increaseBet = 50;
    float initialBet = 0;
    float initialBalance = 500;
    float spinButtonPressTime;
    float spinButtonDelay = 3f;
    float winMutliplier;

    private void Update()
    {
        if (initialBalance < 0)
        {
            initialBalance = 0;
        }   
        betText.text = initialBet.ToString();
        balanceText.text = initialBalance.ToString();
       
    }

    //Increase how much u want to bet 
    public void IncreaseBet()
    {
        if(initialBet < initialBalance)
        initialBet += increaseBet;
    }
    //Decrease how much u want to bet 
    public void DecreaseBet()
    {
        if (initialBet > 0)
            initialBet -= increaseBet;
    }

    //Subtract bet amount from balance
    public void SpinCost()
    {
        if (spinButtonPressTime + spinButtonDelay > Time.unscaledTime || initialBalance < 0)
            return;
        spinButtonPressTime = Time.unscaledTime;
        initialBalance -= initialBet;
    }

    //Change text to win amount and adds that to balance
    public void WinAmount()
    {
        winText[0].text =(winMutliplier * initialBet).ToString();
        initialBalance += float.Parse(winText[0].text);
    }

    //Set active for win text
    public void WinTextActive()
    {
        foreach (Text text in winText)
        {
            if (winMutliplier > 0)
            {
                text.gameObject.SetActive(true);
            }
            else
            {
                text.gameObject.SetActive(false);
            }
        }
    }

    //Disable win text after animation ends
    public void WinTextDisable()
    {
        foreach (Text text in winText)
            text.gameObject.SetActive(false);
    }

    // Set win multiplayer based on tags
    public void WinCondition()
    {
        if (Rows[0].tag == "Lemon" && Rows[1].tag == "Lemon" && Rows[2].tag == "Lemon")
        {
            winMutliplier = 3f;
        }
        else if ((Rows[0].tag == "Lemon" && Rows[1].tag == "Lemon") || (Rows[1].tag == "Lemon" && Rows[2].tag == "Lemon") || (Rows[0].tag == "Lemon" && Rows[2].tag == "Lemon"))
        {
            winMutliplier = 1.5f;
        }
        else if (Rows[0].tag == "Gem" && Rows[1].tag == "Gem" && Rows[2].tag == "Gem")
        {
            winMutliplier = 3f;
        }
        else if ((Rows[0].tag == "Gem" && Rows[1].tag == "Gem") || (Rows[1].tag == "Gem" && Rows[2].tag == "Gem") || (Rows[0].tag == "Gem" && Rows[2].tag == "Gem"))
        {
            winMutliplier = 1.5f;
        }
        else if (Rows[0].tag == "Cherry" && Rows[1].tag == "Cherry" && Rows[2].tag == "Cherry")
        {
            winMutliplier = 3f;
        }
        else if ((Rows[0].tag == "Cherry" && Rows[1].tag == "Cherry") || (Rows[1].tag == "Cherry" && Rows[2].tag == "Cherry") || (Rows[0].tag == "Cherry" && Rows[2].tag == "Cherry"))
        {
            winMutliplier = 1.5f;
        }
        else if (Rows[0].tag == "Watermelon" && Rows[1].tag == "Watermelon" && Rows[2].tag == "Watermelon")
        {
            winMutliplier = 3f;
        }
        else if ((Rows[0].tag == "Watermelon" && Rows[1].tag == "Watermelon") || (Rows[1].tag == "Watermelon" && Rows[2].tag == "Watermelon") || (Rows[0].tag == "Watermelon" && Rows[2].tag == "Watermelon"))
        {
            winMutliplier = 1.5f;
        }
        else if (Rows[0].tag == "Crown" && Rows[1].tag == "Crown" && Rows[2].tag == "Crown")
        {
            winMutliplier = 3f;
        }
        else if ((Rows[0].tag == "Crown" && Rows[1].tag == "Crown") || (Rows[1].tag == "Crown" && Rows[2].tag == "Crown") || (Rows[0].tag == "Crown" && Rows[2].tag == "Crown"))
        {
            winMutliplier = 1.5f;
        }
        else if (Rows[0].tag == "Seven" && Rows[1].tag == "Seven" && Rows[2].tag == "Seven")
        {
            winMutliplier = 3f; ;
        }
        else if ((Rows[0].tag == "Seven" && Rows[1].tag == "Seven") || (Rows[1].tag == "Seven" && Rows[2].tag == "Seven") || (Rows[0].tag == "Seven" && Rows[2].tag == "Seven"))
        {
            winMutliplier = 1.5f;
        }
        else if (Rows[0].tag == "Bar" && Rows[1].tag == "Bar" && Rows[2].tag == "Bar")
        {
            winMutliplier = 3f;
        }
        else if ((Rows[0].tag == "Bar" && Rows[1].tag == "Bar") || (Rows[1].tag == "Bar" && Rows[2].tag == "Bar") || (Rows[0].tag == "Bar" && Rows[2].tag == "Bar"))
        {
            winMutliplier = 1.5f;
        }
        else
        {
            winMutliplier = 0;
        }
        WinAmount();
        WinTextActive();
        Invoke("WinTextDisable", 3f);
        if (initialBalance < initialBet)
        {
            initialBet = initialBalance;
        }
    }
}

