/***********************************************************************;
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
public class HealingItem : MonoBehaviour
{
    public Transform itemPrefab;
    public Transform spawnLocation;
    public float maxTime = 60;
    public float minTime = 30;

    private float time;
    private float spawnTime;

    void Start()
    {
        SetRandomTime();
        time = minTime;
    }

    void FixedUpdate()
    {

        time += Time.deltaTime;

        if (time >= spawnTime)
        {
            SpawnObject();
            SetRandomTime();
        }

    }
    void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);
    }

    void SpawnObject()
    {
        time = 0;
        Instantiate(itemPrefab, spawnLocation.position, spawnLocation.rotation);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

}
