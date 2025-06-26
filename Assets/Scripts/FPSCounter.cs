using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FPSCounter : MonoBehaviour
{

    public TextMeshProUGUI FPSText;
    //public Text FPSText;
    private float pollingTime = 1.5f;
    private float time;
    private int frameCount;
    private int frameRate;


    void Update()
    {

        time += Time.deltaTime;

        frameCount++;

        if (time >= pollingTime)
        {

            frameRate = Mathf.RoundToInt(frameCount/time);
            FPSText.text = frameRate.ToString() + " FPS";
            PlayerPrefs.SetInt("saveFps", frameRate);

            time -= pollingTime;
            frameCount = 0;

        }

    }

    public void SaveFPS()
    {

        //if (frameRate > Mathf.RoundToInt(PlayerPrefs.GetFloat("saveFps", 0)))
        //{
            
            FPSText.text = Mathf.RoundToInt(PlayerPrefs.GetInt("saveFps", frameRate)) + " FPS";

        //}

    }
}
