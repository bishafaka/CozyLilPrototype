using UnityEngine;

public class ButtonAction : MonoBehaviour
{
    public enum InputActionType
    {
        None,
        Quest,
        Book,
        Inventory
    }
    [SerializeField] InputActionType actionType;
    [SerializeField] Container buttonContainer;
    void OnEnable()
    {
        if(InputManager.Instance!=null)
            OnInputActionTypeEnabled();
    }
    void OnDisable()
    {
        if(InputManager.Instance!=null)
            OnInputActionTypeDisabled();
    }
    void OnDestroy()
    {
        if(InputManager.Instance!=null)
            OnInputActionTypeDisabled();
    }
    void OnInputActionTypeEnabled()
    {
        switch (actionType)
        {
            case InputActionType.None:
                break;
            case InputActionType.Quest:
                InputManager.Instance.QuestPressed+=OnQuestPressed;
                break;
            case InputActionType.Book:
                InputManager.Instance.BookPressed+=OnBookPressed;
                break;
            case InputActionType.Inventory:
                InputManager.Instance.InventoryPressed+=OnInventoryPressed;
                break;
            default:
                break;
        }
    }
    void OnInputActionTypeDisabled()
    {
        switch (actionType)
        {
            case InputActionType.None:
                break;
            case InputActionType.Quest:
                InputManager.Instance.QuestPressed-=OnQuestPressed;
                break;
            case InputActionType.Book:
                InputManager.Instance.BookPressed-=OnBookPressed;
                break;
            case InputActionType.Inventory:
                InputManager.Instance.InventoryPressed-=OnInventoryPressed;
                break;
            default:
                break;
        }
    }
    public void OnQuestPressed()
    {
        if(buttonContainer!=null)
            buttonContainer.TogglePanel();
    }
    public void OnBookPressed()
    {
        if (buttonContainer!=null)
            buttonContainer.TogglePanel();
    }
    public void OnInventoryPressed()
    {
        if (buttonContainer!=null)
            buttonContainer.TogglePanel();
    }
}
