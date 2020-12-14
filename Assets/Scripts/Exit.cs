/***********************************************************************;
* Project            : Tsumuji's Winter Adventure
*
* Author             : David Gasinec
* 
* Student Number     : 101187910
*
* Date created       : 20/12/10
*
* Description        : Controls exit gate logic.
*
* Last modified      : 20/12/12
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
using UnityEngine.SceneManagement;

/** Handles Exit logic. */
public class Exit : MonoBehaviour
{
    public void OnCollisonEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("Player Character"))
        {
            SceneManager.LoadScene("GameWin");
        }
    }
}
