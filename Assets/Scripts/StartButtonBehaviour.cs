/***********************************************************************;
* Project            : Tsumuji's Winter Adventure
*
* Author             : David Gasinec
* 
* Student Number     : 101187910
*
* Date created       : 20/11/20
*
* Description        : Load scenes with button press.
*
* Last modified      : 20/11/20
*
* Revision History   :
*
* Date        Author Ref    Revision (Date in YYYYMMDD format) 
* 201120    David Gasinec        Created script. 
*
*
|**********************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/** Button click functionality. */
public class StartButtonBehaviour : MonoBehaviour
{

    /** Adds delay so the sound can play and isn't cut off. */
    private IEnumerator WaitForSceneLoad()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("MenuScene");
    }

    /** Makes the button change scenes. */
    public void OnStartButtonClicked()
    {
        StartCoroutine(WaitForSceneLoad());
    }
}
