using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonTooltip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public string tooltipText;

    private TooltipManager tooltipManager;

    private void Start()
    {
        tooltipManager = FindObjectOfType<TooltipManager>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Vector2 tooltipPosition = new Vector2(transform.position.x, transform.position.y + 50f);
        tooltipManager.ShowTooltip(tooltipText, tooltipPosition);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tooltipManager.HideTooltip();
    }
}
