/***********************************************************************;
* Project            : Tsumuji's Winter Adventure
*
* Author             : David Gasinec
* 
* Student Number     : 101187910
*
* Date created       : 20/12/10
*
* Description        : Controls slider logic.
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
using UnityEngine.UI;

/** Handles slider logic. */
public class HealthbarBehaviour : MonoBehaviour
{
    public Slider slider;


    /** Updates the slider value. */
    public void SetHealthBar(int hp)
    {
        slider.value = hp;
    }

    public void SetMaxHealth(int hp)
    {
        slider.maxValue = hp;
        slider.value = hp;
    }
 
}
