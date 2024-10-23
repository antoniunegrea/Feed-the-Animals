using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public Button button;
    public Sprite muteImage;
    public Sprite soundImage;

    void Start()
    {
        button.GetComponent<Image>();
    }

    public void ButtonPressStart()
    {
        SceneManager.LoadScene(1);
    }

    public void ButtonPressMute()
    {
        AudioListener.volume = 1 - AudioListener.volume;
        if(AudioListener.volume==0)
        {
            button.image.sprite = muteImage;
        }
        else
        {
            button.image.sprite = soundImage;
        }
        
    }
}
