using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public Button playButton;
    public Button quitButton;
    public Button optionsButton;

    public int currentButtonIndex = 0;

    XboxControls xboxActions;

    private void OnEnable()
    {
        xboxActions.Enable();
    }

    private void OnDisable()
    {
        xboxActions.Disable();
    }

    private void Awake()
    {
        xboxActions = new XboxControls();
    }

    private void Start()
    {
        // Select the play button by default
        EventSystem.current.SetSelectedGameObject(playButton.gameObject);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);//lets start from the main menu
    }

    public void QuitGame()
    {
        Debug.Log("YOU EXITED THE GAME");
        Application.Quit();
    }

}
