using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI pauseScreen;
    SpriteRenderer playerSprite;


    public XboxControls xboxActions;

    void Start()
    {
        playerSprite = GetComponent<SpriteRenderer>();
        pauseScreen.enabled = false;
    }   
    void OnEnable()
    {
        xboxActions.Enable();
    }

    void OnDisable()
    {
        xboxActions.Disable();
    }

    void Awake()
    {
        xboxActions = new XboxControls();
        xboxActions.move.Pause.performed += ctx => isPausable();
    }
        

    public void isPausable()
    {
        if (Time.timeScale == 1)
        {
            PauseGame();

        }
        else if (Time.timeScale == 0)
        {
            PlayGame();
            
        }
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
        pauseScreen.enabled = true;
        //freeze the player
        //playerSprite.enabled = false;
    }

    public void PlayGame()
    {
        Time.timeScale = 1;
        pauseScreen.enabled = false;
    }
}
