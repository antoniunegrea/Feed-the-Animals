using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using TMPro;

public class TextZoom : MonoBehaviour
{
    private Text tapText;
    private bool ok;
    public int maxFontSize = 50;
    public int minFontSize = 30;

    void Start()
    {
        tapText = GetComponent<Text>();
        ok = false;
    }

    void Update()
    {
        if (tapText.fontSize == maxFontSize) ok = true;
        if (tapText.fontSize == minFontSize) ok = false;
        if (!ok && tapText.fontSize < maxFontSize) tapText.fontSize++;
        else if (ok && tapText.fontSize > minFontSize) tapText.fontSize--;
        Thread.Sleep(40);
    }
}
