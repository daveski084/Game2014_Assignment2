﻿/***********************************************************************;
* Project            : Tsumuji's Winter Adventure
*
* Author             : David Gasinec
* 
* Student Number     : 101187910
*
* Date created       : 20/11/20
*
* Description        : Player.
*
* Last modified      : 20/13/20
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


/** Player Character Movement. */
public class PlayerCharacterBehaviour : MonoBehaviour
{
    public Joystick joystick;
    public float joystickHorizontalSensitivity;
    public float joystickVerticalSensitivity;
    public float horizontalForce;
    public float verticalForce;
    public int maxHealth = 100;
    public int currHealth;
    public HealthbarBehaviour healthBar;
    public bool isJumping = false;
    public Transform spawnPoint;
    public AudioSource ouchSFX;
    public AudioSource ouchSFX2;
    public AudioSource healSFX;


    private Rigidbody2D m_rigidBody2D;
    private SpriteRenderer m_spriteRenderer;
    public Animator m_animator;

    // Start is called before the first frame update
    void Start()
    {
        m_rigidBody2D = GetComponent<Rigidbody2D>();
        m_spriteRenderer = GetComponent<SpriteRenderer>();
        m_animator = GetComponent<Animator>();
        currHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        ScoreBehaviour.scoreNumber = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {

        if (joystick.Horizontal > joystickHorizontalSensitivity)
        {
            // Move right.
            m_rigidBody2D.AddForce(Vector2.right * horizontalForce * Time.deltaTime);
            m_animator.SetInteger("Animation State", (int)PlayerAnimationState.RUN);
            m_spriteRenderer.flipX = false;
        }
        else if (joystick.Horizontal < -joystickHorizontalSensitivity)
        {
            // Move left.
            m_rigidBody2D.AddForce(Vector2.left * horizontalForce * Time.deltaTime);
            m_animator.SetInteger("Animation State", (int)PlayerAnimationState.RUN);
            m_spriteRenderer.flipX = true;
        }
        else 
        {
            if (!isJumping)
            m_animator.SetInteger("Animation State", (int)PlayerAnimationState.IDLE);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Platform") || collision.gameObject.CompareTag("EnemyTurnPoint"))
        {
            m_animator.SetInteger("Animation State", (int)PlayerAnimationState.IDLE);
            isJumping = false;
        }
    }


    public void TakeDamage(int dmg)
    {
        if(currHealth <= 0)
        {
            SceneManager.LoadScene("GameoverScene");
        }
        currHealth -= dmg;
        healthBar.SetHealthBar(currHealth);
    }

    public void Heal(int dmg)
    {
        currHealth += dmg;
        healthBar.SetHealthBar(currHealth);
        ScoreBehaviour.scoreNumber += 25;
    }

    /** Allows the player to stay on the platform . */
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name.Equals("Moving Platform"))
        {
            this.transform.parent = collision.transform;
        }
       
        if (collision.gameObject.name.Equals("FerrisPlatform"))
        {
            this.transform.parent = collision.transform;
        }

        if(collision.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(15);
            ouchSFX.Play();
            ScoreBehaviour.scoreNumber -= 50;
        }
        // Death plane
        if (collision.gameObject.CompareTag("DeathPlane"))
        {
            ouchSFX2.Play();
            TakeDamage(50);
            transform.position = spawnPoint.position;
        }

        if (collision.gameObject.CompareTag("Heal"))
        {
            Heal(25);
            healSFX.Play();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Moving Platform"))
        {
            this.transform.parent = null; 
        }
        if (collision.gameObject.name.Equals("FerrisPlatform"))
        {
            this.transform.parent = null;
        }

    }

}