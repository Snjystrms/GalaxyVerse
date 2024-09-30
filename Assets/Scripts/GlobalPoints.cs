using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GlobalPoints : MonoBehaviour
{
    public static int PointCount = 0;  
    public int InternalPoint = 0;  
    public TMP_Text ProgressStatusText;
    public Slider progressBar;

    void Start()
    {
        
        PointCount = 200;
        InternalPoint = 200;

        progressBar.maxValue = 200;  
        progressBar.value = PointCount;  

        ProgressStatusText.text = InternalPoint + " / 200 ";  // Update the display text
    }
    void Update()
    {
        if (PointCount > 200)
        {
            PointCount = 200;  // Ensure CookieCount doesn't exceed 2000
        }

        InternalPoint = PointCount;

        ProgressStatusText.text = InternalPoint + " / 200 ";  // Update display text to match current value

        progressBar.value = InternalPoint;  // Update progress bar value to match current CookieCount
    }
}
