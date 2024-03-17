using UnityEngine;
using UnityEngine.UI;

public class NumberKeyButtons : MonoBehaviour
{
    public Button[] buttons;
    public Color highlightColor = Color.yellow;
    public float pressDuration = 0.3f; // Highlight duration for both mouse clicks and key presses

    private Color[] originalColors;
    private Button lastPressedButton;

    void Start()
    {
        originalColors = new Color[buttons.Length];
        for (int i = 0; i < buttons.Length; i++)
        {
            originalColors[i] = buttons[i].colors.normalColor;
            int buttonIndex = i;
            buttons[i].onClick.AddListener(() => ButtonClicked(buttonIndex));
        }
    }

    void ButtonClicked(int index)
    {
        Debug.Log($"Button {index + 1} clicked!");

        HighlightButton(index);
        Invoke(nameof(ResetButtonColor), pressDuration); // Use pressDuration for both mouse clicks and key presses

        ColorBlock colors = buttons[index].colors;
        colors.normalColor = colors.pressedColor;
        buttons[index].colors = colors;

        if (lastPressedButton != null && lastPressedButton != buttons[index])
        {
            ResetButtonColor(lastPressedButton);
        }

        lastPressedButton = buttons[index];
    }

    void HighlightButton(int index)
    {
        ColorBlock colors = buttons[index].colors;
        colors.normalColor = highlightColor;
        buttons[index].colors = colors;
    }

    void ResetButtonColor()
    {
        if (lastPressedButton != null)
        {
            ColorBlock colors = lastPressedButton.colors;
            colors.normalColor = originalColors[GetButtonIndex(lastPressedButton)];
            lastPressedButton.colors = colors;
            lastPressedButton = null;
        }
    }

    void ResetButtonColor(Button button)
    {
        ColorBlock colors = button.colors;
        colors.normalColor = originalColors[GetButtonIndex(button)];
        button.colors = colors;
    }

    int GetButtonIndex(Button button)
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            if (buttons[i] == button)
            {
                return i;
            }
        }
        return -1;
    }

    void Update()
    {
        for (int i = 0; i < 10; i++)
        {
            KeyCode keyCode = (KeyCode)(i == 9 ? KeyCode.Alpha0 : KeyCode.Alpha1 + i); // Convert i to key number (1-0)
            if (Input.GetKeyDown(keyCode))
            {
                if (i < buttons.Length)
                {
                    ButtonClicked(i);
                }
            }
        }
    }
}
