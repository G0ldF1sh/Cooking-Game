﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    public Text timerTxt;
    private int totalSec;

    public GameObject endPanel; 

	void Start () {
        // Use this for initialization
        totalSec = 120; //Player gets 120 seconds to play  
        timerTxt.text = "Time Left: " + totalSec.ToString(); 

        InvokeRepeating( "UpdateSeconds" , 2.0f, 1.0f); //calls after 2 seconds for every second 
	}
	
	// Update is called once per frame
	void UpdateSeconds() {
        if( totalSec >= 0 )
        {
            timerTxt.text = "Time Left: " + totalSec.ToString(); 
            totalSec = totalSec - 1;
        }
        else
        {
            //time == 0, game must end. Since time ran out, goes to lose screen 
            // SceneManager.LoadScene("LoseTest", LoadSceneMode.Single);
            totalSec = 0; //totalSec is actually -1, reset to 0. 
            endPanel.SetActive(true);    
        }
        //elapsed time is float 
        // ((int)elapsedTime % 60).ToString("f0"); //float with 0 decimals; f2 = float w/ 2 decimal places    
    }

    public int GetTimeLeft()
    {
        return totalSec; 
    }
}
