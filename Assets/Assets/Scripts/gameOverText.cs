using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameOverText : MonoBehaviour
{
    public TextMeshProUGUI trueCountText;
    public TextMeshProUGUI falseCountText;

    // Start is called before the first frame update
    void Start()
    {
        string trueCount = PlayerPrefs.GetString("TrueCount");
        string falseCount = PlayerPrefs.GetString("FalseCount");

        trueCountText.text = "True: " + trueCount;
        falseCountText.text = "False: " + falseCount;
    }

}
