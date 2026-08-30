using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(RectTransform))]
[RequireComponent(typeof(Animator))]
public class DraggableUIElement : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    Canvas canvas;
    RectTransform rectTransform;
    Animator animator;
    Vector2 position;
    const string ON_END_DRAG_TRIGGER = "OnEndDrag";

    void Awake()
    {
        canvas=GetComponentInParent<Canvas>();
        rectTransform=GetComponent<RectTransform>();
        animator=GetComponent<Animator>();
        position=rectTransform.anchoredPosition;
    }
    void OnEnable()
    {
        if(rectTransform!=null)
            rectTransform.anchoredPosition=position;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
    }
    public void OnDrag(PointerEventData eventData)
    {
        if(canvas!=null && rectTransform!=null)
            rectTransform.anchoredPosition+=eventData.delta/canvas.scaleFactor;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        if(animator!=null)
            animator.SetTrigger(ON_END_DRAG_TRIGGER);
    }
}
