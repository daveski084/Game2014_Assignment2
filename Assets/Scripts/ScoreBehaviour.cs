/***********************************************************************;
* Project            : Tsumuji's Winter Adventure
*
* Author             : David Gasinec
* 
* Student Number     : 101187910
*
* Date created       : 20/12/10
*
* Description        : Controls score logic.
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


/** Handles score logic. */
public class ScoreBehaviour : MonoBehaviour
{

    public static int scoreNumber = 0;
    Text scoreText;

    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreNumber = 0;
    }

    // Updates the score.
    void Update()
    {
        scoreText.text = "Score: " + scoreNumber;
    }
}
