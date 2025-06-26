using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerSkin : MonoBehaviour
{

    public GameObject default1;
    public GameObject blue;
    public GameObject green;
    public GameObject gold;
    public GameObject rain;

    public static float lastp;

    void Awake()
    {
        PlayerPrefs.SetFloat("lastpress", Skin.lastpress);
        lastp = PlayerPrefs.GetFloat("lastpress", Skin.lastpress);

        if (lastp == 0)
        {

            default1.gameObject.SetActive(true);
            blue.gameObject.SetActive(false);
            green.gameObject.SetActive(false);
            gold.gameObject.SetActive(false);
            rain.gameObject.SetActive(false);


        }
        if (lastp == 1)
        {

            default1.gameObject.SetActive(false);
            blue.gameObject.SetActive(true);
            green.gameObject.SetActive(false);
            gold.gameObject.SetActive(false);
            rain.gameObject.SetActive(false);

        }
        if (lastp == 2)
        {

            default1.gameObject.SetActive(false);
            blue.gameObject.SetActive(false);
            green.gameObject.SetActive(true);
            gold.gameObject.SetActive(false);
            rain.gameObject.SetActive(false);

        }
        if (lastp == 3)
        {

            default1.gameObject.SetActive(false);
            blue.gameObject.SetActive(false);
            green.gameObject.SetActive(false);
            gold.gameObject.SetActive(true);
            rain.gameObject.SetActive(false);

        }
        if (lastp == 4)
        {

            default1.gameObject.SetActive(false);
            blue.gameObject.SetActive(false);
            green.gameObject.SetActive(false);
            gold.gameObject.SetActive(false);
            rain.gameObject.SetActive(true);

        }
    }

}
