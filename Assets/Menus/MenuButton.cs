using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Menu button feedback: hovering selects the button, and the selected button grows slightly.
public class MenuButton : MonoBehaviour, IPointerEnterHandler, ISelectHandler, IDeselectHandler
{
    public float selectedScale = 1.08f;

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Hover selects, so mouse and keyboard share a single highlight
        GetComponent<Button>().Select();
    }

    public void OnSelect(BaseEventData eventData)
    {
        transform.localScale = Vector3.one * selectedScale;
    }

    public void OnDeselect(BaseEventData eventData)
    {
        transform.localScale = Vector3.one;
    }

    void OnDisable()
    {
        transform.localScale = Vector3.one;
    }
}
