using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//TODO 
    //1. ADD DEATH ANIMATION
    //2. ADD DEATH SOUND
    //private animator animator;
public class PlayerLife : MonoBehaviour
{
    [SerializeField] private Text LifeHUD;
    //[SerializeField] int life = 100;    
    
     private new Rigidbody2D rigidbody2D;

    // Start is called before the first frame update
     private void Start()
    {
        //animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    //dying logic
    private void Die()
    {
        //queue death animation right here
        rigidbody2D.bodyType = RigidbodyType2D.Static;
    }

    private void RestartLevel()
    {
        //restart level logic
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
