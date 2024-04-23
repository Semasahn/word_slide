using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class timeCounter : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 60f;

    public TextMeshProUGUI timeText;

    void Start()
    {
        currentTime = startingTime;
    }

    void FixedUpdate()
    {
        currentTime -= Time.deltaTime;
        timeText.text = "Time: " + currentTime.ToString("0");
       
        if (currentTime <= 0) 
        {
            currentTime = 0;
            UnityEngine.SceneManagement.SceneManager.LoadScene(3);
        }
    }
}
