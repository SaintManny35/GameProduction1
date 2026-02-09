
using System.Collections;
using System.Diagnostics;
using TMPro;
using UnityEngine;

public class gameTimer : MonoBehaviour 
{
    // Define variables for timer count and HUD.
    public Stopwatch time;
    public TextMeshProUGUI timerText;
    
    // Begin timer
    private void Start()
    => time = Stopwatch.StartNew();
   // Display timer on HUD.
   void Update()
    {
        timerText.text = string.Format("{0:mm\\:ss\\.ff}", time.Elapsed);
    }
}
