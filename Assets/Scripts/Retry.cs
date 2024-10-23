using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class Retry : MonoBehaviour
{
    public float timeRemaining = 2.5f;

    private void Update()
    {
        if (timeRemaining > 0) timeRemaining -= Time.deltaTime;
        else if (Input.touchCount>0)
        {
            DestroyOutOfLimits.exits = 0;
            SceneManager.LoadScene(1);
        }
    }
}