using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Skin : MonoBehaviour
{

    public Button s_default;
    public Button s_blue;
    public Button s_green;
    public Button s_gold;
    public Button s_rain;

    public GameObject sdefault;
    public GameObject sblue;
    public GameObject sgreen;
    public GameObject sgold;
    public GameObject srain;

    public static float lastpress;

    void Start()
    {
        PlayerPrefs.SetFloat("lastpress", lastpress);
        lastpress = PlayerPrefs.GetFloat("lastpress", lastpress);

        s_default.onClick.AddListener(def);
        s_blue.onClick.AddListener(blue);
        s_green.onClick.AddListener(green);
        s_gold.onClick.AddListener(gold);
        s_rain.onClick.AddListener(rain);

    }

    public void def()
    {
        lastpress = 0;

    }

    public void blue()
    {
        lastpress = 1;

    }

    public void green()
    {
        lastpress = 2;

    }

    public void gold()
    {
        lastpress = 3;

    }

    public void rain()
    {
        lastpress = 4;

    }

    private void Update()
    {
        if (lastpress == 0)
        {

            sdefault.gameObject.SetActive(true);
            sblue.gameObject.SetActive(false);
            sgreen.gameObject.SetActive(false);
            sgold.gameObject.SetActive(false);
            srain.gameObject.SetActive(false);

        }
        if (lastpress == 1)
        {

            sdefault.gameObject.SetActive(false);
            sblue.gameObject.SetActive(true);
            sgreen.gameObject.SetActive(false);
            sgold.gameObject.SetActive(false);
            srain.gameObject.SetActive(false);

        }
        if (lastpress == 2)
        {

            sdefault.gameObject.SetActive(false);
            sblue.gameObject.SetActive(false);
            sgreen.gameObject.SetActive(true);
            sgold.gameObject.SetActive(false);
            srain.gameObject.SetActive(false);

        }
        if (lastpress == 3)
        {

            sdefault.gameObject.SetActive(false);
            sblue.gameObject.SetActive(false);
            sgreen.gameObject.SetActive(false);
            sgold.gameObject.SetActive(true);
            srain.gameObject.SetActive(false);

        }
        if (lastpress == 4)
        {

            sdefault.gameObject.SetActive(false);
            sblue.gameObject.SetActive(false);
            sgreen.gameObject.SetActive(false);
            sgold.gameObject.SetActive(false);
            srain.gameObject.SetActive(true);

        }
    }
}
