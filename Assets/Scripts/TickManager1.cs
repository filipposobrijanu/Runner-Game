using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TickManager1 : MonoBehaviour
{
    public TextMeshProUGUI tickScoreUI;

    public Button b_blue;
    public Button b_green;
    public Button b_gold;
    public Button b_rain;

    private void Awake()
    {

        //PlayerPrefs.SetFloat("tscore1", TickManager.tscore);
        //TickManager.tscore = PlayerPrefs.GetFloat("tscore", TickManager.tscore);
        tickScoreUI.text = "Ticks " + PlayerPrefs.GetFloat("tscore", TickManager.tscore);


    }

    private void Start()
    {
        if (PlayerPrefs.GetFloat("tscore", TickManager.tscore) >= 1)
        {
            b_blue.enabled = true;

        }
        if (PlayerPrefs.GetFloat("tscore", TickManager.tscore) >= 3)
        {
            b_blue.enabled = true;
            b_green.enabled = true;

        }
        if (PlayerPrefs.GetFloat("tscore", TickManager.tscore) >= 5)
        {
            b_blue.enabled = true;
            b_green.enabled = true;
            b_gold.enabled = true;

        }
        if (PlayerPrefs.GetFloat("tscore", TickManager.tscore) >= 10)
        {
            b_blue.enabled = true;
            b_green.enabled = true;
            b_gold.enabled = true;
            b_rain.enabled = true;

        }
    }

    private void Update()
    {
        tickScoreUI.text = "Ticks " + PlayerPrefs.GetFloat("tscore", TickManager.tscore);
    }

}

