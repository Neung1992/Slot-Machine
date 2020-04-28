﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LosePanel : MonoBehaviour
{
    public Text Balance;
    public Text Bet;
    public GameObject Panel;
    private void Update()
    {
        if (Balance.text == 0.ToString() && Bet.text == 0.ToString())
        {
            Invoke("active", 4f);
        }
    }
    public void active()
    {
        Panel.SetActive(true);
    }
    public void deactivate()
    {
        Panel.SetActive(false);
    }
    public void Onclick()
    {
        Balance.text = 500.ToString();
        Panel.SetActive(false);
    }
}
