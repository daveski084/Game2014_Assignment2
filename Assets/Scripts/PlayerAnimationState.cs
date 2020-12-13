/***********************************************************************;
* Project            : Tsumuji's Winter Adventure
*
* Author             : David Gasinec
* 
* Student Number     : 101187910
*
* Date created       : 20/11/20
*
* Description        : Enum for animation states.
*
* Last modified      : 20/12/12
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

/** ENUM for Animation */
[System.Serializable]
public enum PlayerAnimationState 
{
  IDLE,
  RUN,
  JUMP
}
