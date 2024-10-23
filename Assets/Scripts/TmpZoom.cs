using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using TMPro;

public class TmpZoom : MonoBehaviour
{
    private TextMeshProUGUI tapText;
    private bool ok;
    public int maxFontSize = 50;
    public int minFontSize = 30;

    void Start()
    {
        tapText = GetComponent<TextMeshProUGUI>();
        ok = false;
    }

    void Update()
    {
        if (ObjectFall.activate == true) 
        {
            if (tapText.fontSize == maxFontSize) ok = true;
            if (tapText.fontSize == minFontSize) ok = false;
            if (!ok && tapText.fontSize < maxFontSize) tapText.fontSize++;
            else if (ok && tapText.fontSize > minFontSize) tapText.fontSize--;
            Thread.Sleep(30);
        }
        
    }
}
