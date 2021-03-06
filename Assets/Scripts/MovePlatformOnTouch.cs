﻿/***********************************************************************;
* Project            : Tsumuji's Winter Adventure
*
* Author             : David Gasinec
* 
* Student Number     : 101187910
*
* Date created       : 20/12/10
*
* Description        : Controls moving platform logic.
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


/** Handles moving platform logic. */
public class MovePlatformOnTouch : MonoBehaviour
{

    [SerializeField]
    public float speed;
    private float XDirection;
    private bool moveRight;


    /** Moves the platform back and forth. */
    void Update()
    {
        if (transform.position.x < 131f)
            moveRight = true;
        if (transform.position.x > 156f)
            moveRight = false; 

        if(moveRight)
        {
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        }
    }

}
