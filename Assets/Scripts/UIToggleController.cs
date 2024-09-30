using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIToggleController : MonoBehaviour
{
    public Toggle uiToggle; // Reference to your UI toggle

    // Reference to TextMeshPro elements
    public TMP_Text coinsText;
    public TMP_Text gVerseTitle;
    public TMP_Text levelText;
    public TMP_Text progressBarText;

    // Reference to Buttons
    public Button[] buttons;

    // Reference to the background image
    public Image backgroundImage;
    public Sprite darkModeBackground; // Background for dark mode
    public Sprite lightModeBackground; // Background for light mode

    private Color darkModeTextColor = Color.white; // Dark mode text color
    private Color lightModeTextColor = Color.black; // Light mode text color

    // Reference to the background object of the toggle
    public RectTransform toggleBackgroundRectTransform;

    // Positions for toggle background
    private Vector3 darkModePosition = new Vector3(-10.7f, 0f, 0f);
    private Vector3 lightModePosition = new Vector3(11.3f, 0f, 0f);

    private void Start()
    {
        // Load the saved toggle state
        bool isLightMode = PlayerPrefs.GetInt("IsLightMode", 0) == 1;

        // Set the toggle based on saved state
        uiToggle.isOn = isLightMode;
        ApplyMode(isLightMode);

        // Add listener to the Toggle's onValueChanged event
        uiToggle.onValueChanged.AddListener(OnToggleChanged);
    }

    // This method is called whenever the toggle is switched
    private void OnToggleChanged(bool isToggled)
    {
        // Save the toggle state
        PlayerPrefs.SetInt("IsLightMode", isToggled ? 1 : 0);
        PlayerPrefs.Save();

        // Apply the mode
        ApplyMode(isToggled);
    }

    // Method to apply dark or light mode
    private void ApplyMode(bool isLightMode)
    {
        if (isLightMode)
        {
            // Switch to Light Mode
            ChangeTextColor(lightModeTextColor);
            ChangeBackgroundImage(lightModeBackground);
            MoveToggleBackground(lightModePosition);
        }
        else
        {
            // Switch to Dark Mode
            ChangeTextColor(darkModeTextColor);
            ChangeBackgroundImage(darkModeBackground);
            MoveToggleBackground(darkModePosition);
        }
    }

    // Method to change the color of all TextMeshPro elements
    private void ChangeTextColor(Color newColor)
    {
        coinsText.color = newColor;
        gVerseTitle.color = newColor;
        levelText.color = newColor;
        progressBarText.color = newColor;

        foreach (Button button in buttons)
        {
            TMP_Text buttonText = button.GetComponentInChildren<TMP_Text>();
            if (buttonText != null)
            {
                buttonText.color = newColor;
            }
        }
    }

    // Method to change the background image
    private void ChangeBackgroundImage(Sprite newBackground)
    {
        backgroundImage.sprite = newBackground;
    }

    // Method to move the toggle background
    private void MoveToggleBackground(Vector3 newPosition)
    {
        toggleBackgroundRectTransform.localPosition = newPosition;
    }
}
