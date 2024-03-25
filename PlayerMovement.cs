using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private XboxControls xboxActions;
    private Rigidbody2D rb2d;
    private BoxCollider2D coll;
    private SpriteRenderer sprite;
    private Animator anim;

    [SerializeField] private float dashSpeed = 2.0f; //RECOMMEND 3.5
    private int dashCounter = 2;
    [SerializeField] private LayerMask jumpableGround;

    private int doubleJump = 2;
    private float dirX = 0f;
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpForce = 14f;
    [SerializeField] private float isWalking = 0.5f;


    private enum MovementState { idle, running, jumping, isWalking }

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        // Enable the XboxControls actions when the script is enabled
        xboxActions.Enable();
    }

    private void OnDisable()
    {
        // Disable the XboxControls actions when the script is disabled
        xboxActions.Disable();
    }

    private void Awake()
    {
        xboxActions = new XboxControls();
         // Subscribe to the Jump action callback
        xboxActions.move.jump.performed += ctx => Jump();
        xboxActions.move.dash.performed += ctx => Dash();
    }

    private void Update()
    {
         if (Time.timeScale == 0){
                return;
        }
        dirX = xboxActions.move.Analog.ReadValue<float>();
        rb2d.velocity = new Vector2(dirX * moveSpeed, rb2d.velocity.y);
        CanDash();
        UpdateAnimationState();
    }
  private void Dash()
{
    if (CanDash() && dashCounter > 0)
    {
        StartCoroutine(DashCoroutine());
    }
}

private IEnumerator DashCoroutine()
{
    float elapsedTime = 0f;
    Vector2 startPosition = rb2d.position;
    Vector2 endPosition = new Vector2(rb2d.position.x + dirX * dashSpeed, rb2d.position.y);

    while (elapsedTime < 0.2f) // Adjust the duration as needed
    {
        rb2d.position = Vector2.Lerp(startPosition, endPosition, elapsedTime / 0.2f);
        elapsedTime += Time.deltaTime;
        yield return null;
    }

    dashCounter--;
    Debug.Log(dashCounter);
}
    private void Jump()
    {
        if (IsGrounded() || doubleJump >=1)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpForce);
            doubleJump--;
        }
    }
    private void UpdateAnimationState()
    {
       float absoluteDirectionX = Mathf.Abs(dirX);
            //running animatiion
        if (dirX > 0f)
        {
            //this is for the analog stick to check if its in full force or half force
            if(absoluteDirectionX > isWalking)
            {
                anim.SetBool("Running",true);
                anim.SetBool("walking",false);
                anim.SetBool("idle",false);
            }
            sprite.flipX = false;
        }
        else if (dirX < 0f)
        {
            if(absoluteDirectionX > 0)
            {
                anim.SetBool("Running",true);
                anim.SetBool("walking",false);
                anim.SetBool("idle",false);
            }
            sprite.flipX = true;
        }
        //idle animation
        else
        {
            anim.SetBool("Running",false);
            anim.SetBool("idle",true);
        }
        //jumping animation
        // if (rb2d.velocity.y > .1f)
        // {
        //    anim.SetBool("jumping",true);
        //     anim.SetBool("idle",false);

        // }
        // else if (rb2d.velocity.y < -.1f)
        // {
        //    anim.SetBool("jumping",false );
        //    anim.SetBool("idle",true);
        // }

    }
    private bool CanDash()
    {
        if(dashCounter > 0 || Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround))
        {
            if(Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround))
            {
                dashCounter = 1;
            }
            return true;
        }
        else
        {
            return false;
        }  
    }       
    private bool IsGrounded()
    {
        if (Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround))
        {
            doubleJump = 2;
        }
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround );
    }
}
