using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuestEntry : MonoBehaviour
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
        questName.text=quest.entryName;
        questDescription.text=quest.entryDescription;
        questComplete.isOn=quest.isQuestCompleted;
    }
}
