/***********************************************************************;
* Project            : Tsumuji's Winter Adventure
*
* Author             : David Gasinec
* 
* Student Number     : 101187910
*
* Date created       : 20/12/10
*
* Description        : Controls ferris platform logic.
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


/** Handles ferris platform logic. */
public class FerrisBehaviour : MonoBehaviour
{
    [SerializeField]
    Transform centerPoint;

    float posX = 0;
    float posY = 0;
    float angle = 0;
    float radius = 10f;
    float speed = 2f;

   

    // Make the platform move in a circular motion.
    void Update()
    {
        posX = centerPoint.position.x + Mathf.Cos(angle) * radius;
        posY = centerPoint.position.y + Mathf.Sin(angle) * radius;
        transform.position = new Vector2(posX, posY);
        angle = angle + Time.deltaTime * speed;
        if(angle >= 360f)
        {
            angle = 0;
        }
    }
}
