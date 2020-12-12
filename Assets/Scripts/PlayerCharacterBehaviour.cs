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
* Last modified      : 20/11/20
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

    private Rigidbody2D m_rigidBody2D;
    private SpriteRenderer m_spriteRenderer;
    private Animator m_animator;

    // Start is called before the first frame update
    void Start()
    {
        m_rigidBody2D = GetComponent<Rigidbody2D>();
        m_spriteRenderer = GetComponent<SpriteRenderer>();
        m_animator = GetComponent<Animator>();
        currHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
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
            m_animator.SetInteger("Animation State", (int)PlayerAnimationState.IDLE);
        }
    }

    public void TakeDamage(int dmg)
    {
        currHealth -= dmg;
        healthBar.SetHealthBar(currHealth);
    }
}
