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


/** Handles enemy logic. */
public class EnemyBehaviour : MonoBehaviour
{

    public float runForce;
    public Rigidbody2D rigidbody2D;
    public Transform lookAheadPoint;
    public LayerMask collisionGroundLayer;

    private bool shouldFlip;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    private void _LookAhead()
    {
        var groundHit = Physics2D.Linecast(transform.position, lookAheadPoint.position, collisionGroundLayer);
        if (groundHit)
        {
            if (groundHit.collider.CompareTag("EnemyTurnPoint"))
            {
                shouldFlip = true;
            }

        }
        

        Debug.DrawLine(transform.position, lookAheadPoint.position, Color.green);
    }

    private void Move()
    {
        rigidbody2D.AddForce(Vector2.left * runForce * Time.deltaTime * transform.localScale.x); ;

    }

    private void FlipX()
    {
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("EnemyTurnPoint"))
        {
            FlipX();
        }
    }
}
