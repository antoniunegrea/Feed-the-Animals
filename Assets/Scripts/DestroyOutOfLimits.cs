using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Threading;

public class DestroyOutOfLimits : MonoBehaviour
{
    public float topLimit = 15.0f;
    public float downLilmit = -10.0f;
    public static int exits = 0;
    public static int score;
    private int maxNumExits = 3;


    void Update()
    {
        if (exits == maxNumExits)
        {
            Thread.Sleep(200);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (transform.position.z > topLimit)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < downLilmit)
        {
            Destroy(gameObject);
            exits++;
            Health.health -= 1;
        }
    }
}
