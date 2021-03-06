﻿/***********************************************************************;
* Project            : Tsumuji's Winter Adventure
*
* Author             : David Gasinec
* 
* Student Number     : 101187910
*
* Date created       : 20/13/10
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


/** Bone money and sound effects. */
public class BoneMoney : MonoBehaviour
{
    public AudioSource collectSound;
    public Vector3 groundLevel;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _toggle();
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collectSound.Play();
            ScoreBehaviour.scoreNumber += 100;
            Destroy(gameObject);
        }
    }

    private void _toggle()
    {
      
        {
            transform.position = new Vector3(transform.position.x,
            groundLevel.y + Mathf.PingPong(Time.time, 1), 0.0f);
        }
    }
}
