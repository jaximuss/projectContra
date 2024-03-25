using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

//controls how the enemy behaves(movement and animations)
public class EnemyController : MonoBehaviour
 {
    [SerializeField] private Transform[] patrolPoints;
    [SerializeField] private float speed = 2.0f;
    [SerializeField] private float attackRange = 2.0f;//wtf is this actually bullshit range
    [SerializeField]private float detectionRange = 5.0f;
    [SerializeField] private float attackDamage = 10.0f;
    [SerializeField] private float attackCooldown = 2.0f;

    private Animator anim;

    private SpriteRenderer sprite;
    private Transform playerTransform;
    private int currentPatrolIndex = 0;
    private float attackTimer = 0f;

    private enum State { Patrolling, Chasing, Attacking }
    private State currentState = State.Patrolling;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        switch (currentState)
        {
            case State.Patrolling:
                Patrol();
                CheckForPlayer();
                break;
            case State.Chasing:
                ChasePlayer();
                break;
            case State.Attacking:
                AttackPlayer();
                break;
        }
        animationHandler();
        flipSprite();

    }

    private void Patrol()
    {
        Transform patrolPoint = patrolPoints[currentPatrolIndex];
        if (Vector2.Distance(transform.position, patrolPoint.position) < 0.1f)
        {
            currentPatrolIndex = (currentPatrolIndex + 1) % patrolPoints.Length;
        }
        else
        {
            MoveTowards(patrolPoint.position);
        }
    }
     

     //flip the sprite to the direction of the player
     private void flipSprite()
     {
         if(transform.position.x < playerTransform.position.x){
             //face right
             sprite.flipX = false;
         }
         else{
             //face left
             sprite.flipX = true;
         }
     }
    private void ChasePlayer()
    {
        if (Vector2.Distance(transform.position, playerTransform.position) <= attackRange)
        {
            //currentState = State.Attacking;
            Debug.Log("Attacking player");
        }
        else
        {
            MoveTowards(playerTransform.position);
            Debug.Log("Chasing player");
            currentState = State.Chasing;

        }
    }

    private void AttackPlayer()
    {
        //if the time to attack is 0 or less then the object is allowed to attack, this is basically like cooldown in league of legend
        
        if (attackTimer <= 0)
        {
            Debug.Log("Attacking player with " + attackDamage + " damage.");
            attackTimer = attackCooldown;
            currentState = State.Attacking;
        }
        attackTimer -= Time.deltaTime;

        // Check if player is still in range
        if (Vector2.Distance(transform.position, playerTransform.position) > attackRange)
        {
            //chase if out of range
            currentState = State.Chasing;
        }
    }

    private void CheckForPlayer()
    {
        if (Vector2.Distance(transform.position, playerTransform.position) <= detectionRange)
        {
            currentState = State.Chasing;
        }
    }

    private void MoveTowards(Vector2 target)
    {
        if(transform.position.x < target.x)
        {
            //move towards the poisiton
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            currentState = State.Chasing;
        }
        else
        {
            //move towards the poisiton
            transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
            currentState = State.Chasing;

        }
    }

    public void Die(){
        //play death animation 
        anim.SetBool("die",true);
        //delete enemy object
        Destroy(gameObject);
    }

    private void animationHandler(){
        if(State.Attacking == currentState){
            //play attack animation
            anim.SetBool("Attacking",true);
            anim.SetBool("Running",false);
            anim.SetBool("Walking",false);
        }
        else if(State.Chasing == currentState){
            //play chase animation
            anim.SetBool("Running",true);
            anim.SetBool("Attacking",false);
            anim.SetBool("Walking",false);
        }
        else if(State.Patrolling == currentState){
            //play patrol animation
            anim.SetBool("Walking",true);
            anim.SetBool("Running",false);
            anim.SetBool("Attacking",false);
        }
    }

}
