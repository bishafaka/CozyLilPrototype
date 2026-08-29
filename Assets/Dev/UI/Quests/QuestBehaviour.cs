using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuestBehaviour : MonoBehaviour
{
    [SerializeField] Quest quest;
    [SerializeField] TextMeshProUGUI questName;
    [SerializeField] TextMeshProUGUI questDescription;
    [SerializeField] Toggle questComplete;

    void Start()
    {
        if (quest!=null && questName!=null && questDescription!=null)
            Refresh();
    }
    void OnValidate()
    {
        if (quest!=null && questName!=null && questDescription!=null)
            Refresh();
    }
    void Refresh()
    {
        questName.text=quest.questName;
        questDescription.text=quest.questDescription;
        questComplete.isOn=quest.isQuestCompleted;
    }
}
