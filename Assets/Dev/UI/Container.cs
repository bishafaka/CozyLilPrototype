using UnityEngine;

public class Container : DraggableUIElement
{
    [SerializeField] GameObject panelToActivate;

    public void TogglePanel()
    {
        panelToActivate.SetActive(!panelToActivate.activeSelf);
    }
}
