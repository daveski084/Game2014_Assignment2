/***********************************************************************;
* Project            : Tsumuji's Winter Adventure
*
* Author             : David Gasinec
* 
* Student Number     : 101187910
*
* Date created       : 20/12/10
*
* Description        : Controls jump logic.
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


/** Handles slider logic. */
public class JumpButton : MonoBehaviour
{
    public Rigidbody2D playerBody;
    public PlayerCharacterBehaviour player;

    [SerializeField]
    public float jumpForce;


    /** Make Tsumuji jump/double jump. */
    public void OnJumpPressed()
    {
        if(player.isJumping == false)
        {
            player.isJumping = true;
            player.m_animator.SetInteger("Animation State", (int)PlayerAnimationState.JUMP);
            playerBody.AddForce(Vector2.up * jumpForce);
        }
    }
}
