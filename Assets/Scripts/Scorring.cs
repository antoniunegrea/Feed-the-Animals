using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorring : MonoBehaviour
{
    public static int scoreValue = 0;
    public static int scoreValueFox = 8;
    public static int scoreValueCow = 10;
    public static int scoreValueMoose = 20;
    public static int scoreValueRooster = 5;
    public static int scoreValueStag = 15;
    public static int scoreValueDog = 6;
    public static int scoreValueChick = 4;
    public static int scoreValueHorse = 17;
    public Text score;

    private void Start()
    {
        score = GetComponent<Text>();
        scoreValue = 0;
    }

    void Update()
    {
        score.text = "SCORE " + scoreValue;
    }

}
