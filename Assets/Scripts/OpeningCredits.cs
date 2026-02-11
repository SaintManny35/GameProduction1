using System.Diagnostics;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpeningCredits : MonoBehaviour
{
    [SerializeField] private Stopwatch OpeningTimer;

    // Begin Timer
    private void Start()
    => OpeningTimer = Stopwatch.StartNew();

    void Update()
    {
        if (OpeningTimer.Elapsed.TotalSeconds >= 6.5f)
        {
            LoadNextScene();
            OpeningTimer.Stop();
        }
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(1); // Main Game Scene
    }
}