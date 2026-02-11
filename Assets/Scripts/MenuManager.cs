using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MenuManager : MonoBehaviour
{
    [Header("Menu Objects")]
    [SerializeField] private GameObject _PauseMenuCanvasGO;
    [SerializeField] private GameManager _RetryButtonGo;
    [SerializeField] private GameObject _QuitButtonGo;

    [Header("Player Scripts to Deactivate on Pause")]
    [SerializeField] private PlayerMovement _player;

    [Header("First Selected Options")]
    [SerializeField] private GameObject _PauseMenuFirst;
    [SerializeField] private GameObject _RetryButtonFirst;
    [SerializeField] private GameObject _QuitButtonFirst;
    private bool isPaused;

    private void Start()
    {
        _PauseMenuCanvasGO.SetActive(false);

    }

    private void Update()
    {
        if (InputManager.instance.MenuOpenCloseInput)
        {
            if (!isPaused)
            {
                Pause();
            }
            else
            {
                Unpause();
            }
        }
    }

    #region Main Menu Button Activations

    public void OnRetryPress()
    {
       RetryGame(); 
    }

    public void OnResumePress()
    {
        Unpause();
    }

    public void OnQuitPress()
    {
        Quit();
    }

    #endregion

    #region Pause/Unpause Functions

    public void Pause()
    {
        isPaused = true;
        Time.timeScale = 0f;

        _player.enabled = false;

        OpenMainMenu();
    }

    public void Unpause()
    {
        isPaused = false;
        Time.timeScale = 1f;

        _player.enabled = true;

        CloseAllMenus();
    }

    public void Quit()
    {
        Application.Quit();
        
        EventSystem.current.SetSelectedGameObject(_QuitButtonFirst);
    }

    #endregion

    #region Canvas Activations

    private void OpenMainMenu()
    {
        _PauseMenuCanvasGO.SetActive(true);

        EventSystem.current.SetSelectedGameObject(_PauseMenuFirst);

    }

    public void RetryGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        EventSystem.current.SetSelectedGameObject(_RetryButtonFirst);
    }

    private void CloseAllMenus()
    {
        _PauseMenuCanvasGO.SetActive(false);

        EventSystem.current.SetSelectedGameObject(null);
    }

    #endregion
}