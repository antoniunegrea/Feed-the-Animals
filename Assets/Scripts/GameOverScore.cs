using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScore : MonoBehaviour
{
    public Text score;
    
    void Start()
    {
        score = GetComponent<Text>();
    }

    void Update()
    {
        score.text = "SCORE " + Scorring.scoreValue;
    }
}
