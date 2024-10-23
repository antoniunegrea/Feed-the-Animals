using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public static int health = 3;
    public static int numOfHearts = 3;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    private void Start()
    {
        health = 3;
    }

    private void Update()
    {
        for (int i = 0; i < hearts.Length; i++) 
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }


            if(i<numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }
}
