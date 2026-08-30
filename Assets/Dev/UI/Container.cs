using UnityEngine;

public class Container : DraggableUIElement
{
    [SerializeField] bool isActiveOnStart=false;

    void Start()
    {
        gameObject.SetActive(isActiveOnStart);
    }
    public void TogglePanel()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }
}
