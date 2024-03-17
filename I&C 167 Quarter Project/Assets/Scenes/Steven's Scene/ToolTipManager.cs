using UnityEngine;
using TMPro;

public class TooltipManager : MonoBehaviour
{
    public GameObject tooltipPrefab;

    private GameObject currentTooltip;

    private void Start()
    {
        if (tooltipPrefab == null)
        {
            Debug.LogError("Tooltip prefab is not assigned in the TooltipManager.");
        }
    }

    public void ShowTooltip(string text, Vector2 position)
    {
        if (tooltipPrefab == null)
        {
            Debug.LogError("Tooltip prefab is not assigned in the TooltipManager.");
            return;
        }

        if (currentTooltip != null)
        {
            Destroy(currentTooltip);
        }

        currentTooltip = Instantiate(tooltipPrefab, position, Quaternion.identity, transform);
        currentTooltip.GetComponentInChildren<TextMeshProUGUI>().text = text;
    }

    public void HideTooltip()
    {
        if (currentTooltip != null)
        {
            Destroy(currentTooltip);
        }
    }
}
