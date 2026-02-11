using System.Diagnostics;
using UnityEngine;

public class LevelIntro : MonoBehaviour
{
    private Stopwatch levelIntroTimer;

    // Begin Timer before Level intro drops
    private void Start()
    => levelIntroTimer = Stopwatch.StartNew();

    void Update()
    {
        if (levelIntroTimer.Elapsed.TotalSeconds >= 2.0f)
        {
            gameObject.SetActive(false);
            levelIntroTimer.Stop();
        }
    }
}
