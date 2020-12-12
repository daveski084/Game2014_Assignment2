/***********************************************************************;
* Project            : Tsumuji's Winter Adventure
*
* Author             : David Gasinec
* 
* Student Number     : 101187910
*
* Date created       : 20/12/10
*
* Description        : Controls timer logic.
*
* Last modified      : 20/12/11
*
* Revision History   :
*
*Date        Author Ref    Revision (Date in YYYYMMDD format) 
*201024    David Gasinec        Created script. 
*
|**********************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/** Handles timer logic. */
public class TimerBehaviour : MonoBehaviour
{
    public float time = 10;
    public Text timerText;

    void Update()
    {
        
        if (time > 0)
        {
            time -= Time.deltaTime;
            DisplayTime(time);
        }
        else
        {
            Debug.Log("Time has run out!");
            time = 0;
        }
        
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}