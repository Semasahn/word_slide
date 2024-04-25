using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TrueCheck : MonoBehaviour
{
    public TextMeshProUGUI trueText;
    public TextMeshProUGUI falseText;
    public instantiator instantiator;

    private int trueCount = 0;
    private int falseCount = 0;

    void Start()
    {
        UpdateUI();
    }

    public void IncrementTrueCount()
    {
        if (instantiator.canIncreasePoint)
        {
            trueCount++;
            UpdateUI();
            instantiator.canIncreasePoint = false;
        }
    }

    public void IncrementFalseCount()
    {
        if (instantiator.canIncreasePoint)
        {
            falseCount++;
            UpdateUI();
            instantiator.canIncreasePoint = false;
        }
    }

    void UpdateUI()
    {
        trueText.text = "True: " + trueCount.ToString();
        falseText.text = "False: " + falseCount.ToString();

        PlayerPrefs.SetString("TrueCount", trueCount.ToString());
        PlayerPrefs.SetString("FalseCount", falseCount.ToString());

    }
}
