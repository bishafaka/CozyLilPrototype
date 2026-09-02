using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuestEntry : MonoBehaviour
{
    [SerializeField] Quest quest;
    [SerializeField] TextMeshProUGUI questName;
    [SerializeField] TextMeshProUGUI questDescription;
    [SerializeField] Toggle questComplete;

    void InitialiseQuest(Quest newQuest)
    {
        questName.text=newQuest.entryName;
        questDescription.text=newQuest.entryDescription;
        questComplete.isOn=newQuest.isQuestCompleted;
    }
    void Start()
    {
        if(quest!=null && questName!=null && questDescription!=null)
            InitialiseQuest(quest);
    }
    void OnValidate()
    {
        if(quest!=null && questName!=null && questDescription!=null)
            InitialiseQuest(quest);
    }
}
