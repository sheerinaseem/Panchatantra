﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text countText;

    public Text winText;

    public Text gameOverText;

    private int count;

    private void Start()
    {
        Dragobject.targetFound += UpdateScore; 
    }

    private void UpdateScore()
    {
        count = count + 1;
        if (count > 4)
        {
            GameObject adsManager = GameObject.Find("AdsManager");
            if (adsManager != null)
            {
                UnityAdsExample ads = adsManager.GetComponent<UnityAdsExample>();
                ads.ShowRewardedAd();
            }
        }
        //SetCountText();

    }


    void SetCountText()
    {
        countText.text = "Your Score : " + count.ToString();
        if (count >= 8)
        {
            winText.text = "Woohooo!!";

        }
    }
}
