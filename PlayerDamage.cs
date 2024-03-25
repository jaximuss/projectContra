using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    
   private BoxCollider2D boxCollisor2D; 
   private Animator animator;
    private Rigidbody2D rigid2d;
    [SerializeField]private LayerMask Enemy;

    [SerializeField] private float attackSpeed = 0f;

    [SerializeField] private float attackCooldown = 2f;
    XboxControls xboxActions;
    public int Damage = 100;
    void Start()
    {
        boxCollisor2D = GetComponent<BoxCollider2D>();  
        rigid2d = GetComponent<Rigidbody2D>();  
        animator = GetComponent<Animator>();
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
        xboxActions.move.Attack.performed += ctx => Attack();
    }
    // Update is called once per frame
    void Update()
    {
       attackSpeed =- Time.deltaTime;
        hitboxChecker();
    }
    private bool CanDealDamage(){
        return Physics2D.BoxCast(boxCollisor2D.bounds.center, boxCollisor2D.bounds.size, 0f, Vector2.right, .1f,Enemy);
       
    }

    private void hitboxChecker(){
        if(CanDealDamage()){
            Debug.Log("TESTING 1 2 TESTING 1 2 3");
        }
    }
//basically this is saying if the attack speed is less than or equal to 0 then we can attack
    private bool CanAttack()
    {
        if(attackSpeed <= 0 )
        {
            return true;
        }
        //then we minus the attack speed by the time basically saying every frame counts as a second
       return false;
    }


    private void Attack(){
        if(CanAttack())
        {
            attackSpeed = attackCooldown;
            //if we can attack then we play the animation to attack needs to be checked  
            playAttackAnimation();

            
            if(CanDealDamage())
            {
                Debug.Log("i am supposed to be doing Damage");
            }
        }
    }

    public void playAttackAnimation()
    {
        animator.SetTrigger("Attack");
        //maybe we set others to true?
        animator.SetBool("Running", true); 

    }

}
