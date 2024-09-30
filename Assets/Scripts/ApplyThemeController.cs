using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ApplyThemeController : MonoBehaviour
{
    // Reference to TextMeshPro elements in different scenes
    public TMP_Text[] textElements;

    // Reference to the background image
    public Image backgroundImage;
    public Sprite darkModeBackground; // Background for dark mode
    public Sprite lightModeBackground; // Background for light mode

    private Color darkModeTextColor = Color.white; // Dark mode text color
    private Color lightModeTextColor = Color.black; // Light mode text color

    private void Start()
    {
        // Load the saved toggle state
        bool isLightMode = PlayerPrefs.GetInt("IsLightMode", 0) == 1;

        // Apply the mode based on the saved state
        ApplyMode(isLightMode);
    }

    // Method to apply dark or light mode
    private void ApplyMode(bool isLightMode)
    {
        if (isLightMode)
        {
            // Switch to Light Mode
            ChangeTextColor(lightModeTextColor);
            ChangeBackgroundImage(lightModeBackground);
        }
        else
        {
            // Switch to Dark Mode
            ChangeTextColor(darkModeTextColor);
            ChangeBackgroundImage(darkModeBackground);
        }
    }

    // Method to change the color of all TextMeshPro elements
    private void ChangeTextColor(Color newColor)
    {
        foreach (TMP_Text textElement in textElements)
        {
            if (textElement != null)
            {
                textElement.color = newColor;
            }
        }
    }

    // Method to change the background image
    private void ChangeBackgroundImage(Sprite newBackground)
    {
        if (backgroundImage != null)
        {
            backgroundImage.sprite = newBackground;
        }
    }
}
