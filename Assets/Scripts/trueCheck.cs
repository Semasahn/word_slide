using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TrueCheck : MonoBehaviour
{
    public TextMeshProUGUI trueText;
    public TextMeshProUGUI falseText;

    private int trueCount = 0;
    private int falseCount = 0;

    void Start()
    {
        UpdateUI();
    }

    public void IncrementTrueCount()
    {
        trueCount++;
        UpdateUI();
    }

    public void IncrementFalseCount()
    {
        falseCount++;
        UpdateUI();
    }

    void UpdateUI()
    {
        trueText.text = "True: " + trueCount.ToString();
        falseText.text = "False: " + falseCount.ToString();
    }
}
