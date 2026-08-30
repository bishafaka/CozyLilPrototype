using UnityEngine;

public class ButtonAction : MonoBehaviour
{
    public enum InputActionType
    {
        None,
        Quest
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
            default:
                break;
        }
    }
    void OnQuestPressed()
    {
        if(buttonContainer!=null)
            buttonContainer.TogglePanel();
    }
}
