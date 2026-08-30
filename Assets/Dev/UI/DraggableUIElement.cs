using UnityEngine;
using UnityEngine.EventSystems;

public class DraggableUIElement : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField] Canvas canvas;
    RectTransform rectTransform;
    Vector2 position;

    void Awake()
    {
        rectTransform=GetComponent<RectTransform>();
    }
    void OnEnable()
    {
        if (rectTransform!=null)
            rectTransform.anchoredPosition=new Vector2(0.0f, 0.0f);
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("WindowBeginDrag");
    }
    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition+=eventData.delta/canvas.scaleFactor;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("WindowEndDrag");
    }
}
