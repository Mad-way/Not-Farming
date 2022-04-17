using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class BuildingState
{
    //public int level;
    public int clicks;
    public GameObject gameObject;



}
public class UpdateBuildings : MonoBehaviour
{
    [SerializeField]
    private int currentLevel;
    [SerializeField] private List<BuildingState> states = new List<BuildingState>();
    [SerializeField] private Clicker clicker;
    [SerializeField] private Button updateButton;
    [SerializeField] private Text textOfLevel;
    // Start is called before the first frame update
    void Start()
    {
        Clicker.Click.AddListener(() => CheckLevel());
        for (int i = 0; i < states.Count; i++)
        {
            states[i].gameObject.SetActive(false);
        }
        states[0].gameObject.SetActive(true);
        CheckLevel();

    }
    void CheckLevel()
    {
        if (currentLevel >= states.Count-1)
        {
            textOfLevel.text = "������� �������: " + currentLevel + "\n��������� ������������ �������";
            updateButton.interactable = false;
            return;
        }
        
        if (states[currentLevel + 1].clicks <= Clicker.clicks)
        {
            updateButton.interactable = true;
        }
        else
        {
            updateButton.interactable = false;
        }
        ShowInfo();
    }
    public void UpdateBuilding()
    {
        if (states[currentLevel + 1].clicks <= Clicker.clicks)
        {
            for (int i = 0; i < states.Count; i++)
            {
                states[i].gameObject.SetActive(false);
            }
            currentLevel++;
            states[currentLevel].gameObject.SetActive(true);
            Clicker.clicks -= states[currentLevel].clicks;
            clicker.clicksText.text = Clicker.clicks.ToString();
            Clicker.Click?.Invoke();
        }
    }
    void ShowInfo() {
        if (currentLevel < states.Count-1)
            textOfLevel.text = "������� �������: " + currentLevel + "\n����������� ���-�� ������: " + states[currentLevel + 1].clicks;
        else textOfLevel.text = "������� �������: " + currentLevel + "\n��������� ������������ �������";
    }
}
