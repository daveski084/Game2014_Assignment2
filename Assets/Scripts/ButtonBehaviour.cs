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
public class ButtonBehaviour : MonoBehaviour
{
    //Title Scene

    /** Adds delay so the sound can play and isn't cut off. */
    private IEnumerator WaitForSceneLoadStart()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("MenuScene");
    }

    /** Makes the button change scenes. */
    public void OnStartButtonClicked()
    {
        StartCoroutine(WaitForSceneLoadStart());
    }

    // Main menu //

    private IEnumerator WaitForSceneLoadPlayGame()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("GameLevelScene");
    }

    public void OnButtonClickedPlay()
    {
        StartCoroutine(WaitForSceneLoadPlayGame());
    }

    //How to play
    private IEnumerator WaitForSceneLoadHowToPlay()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("InstructionsScene");
    }

    public void OnButtonClickedHowToPlay()
    {
        StartCoroutine(WaitForSceneLoadHowToPlay());
    }

    private IEnumerator WaitForSceneLoadHowToPlayBack()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("MenuScene");
    }

    public void OnButtonClickedHowToPlayBack()
    {
        StartCoroutine(WaitForSceneLoadHowToPlayBack());
    }

    private IEnumerator WaitForSceneLoadBackToTitle()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("TitleScene");
    }

    //Back to Title
    public void OnButtonClickedBackToTitle()
    {
        StartCoroutine(WaitForSceneLoadBackToTitle());
    }

}
