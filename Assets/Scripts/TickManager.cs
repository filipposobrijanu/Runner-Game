using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TickManager : MonoBehaviour
{

    public GameObject spawnObject;
    public GameObject goldtickscreen;
    public GameObject spawnPoint;
    public SpriteRenderer ticksprite;

    public GameObject Congrats1;
    public GameObject Congrats2;
    [SerializeField] private AudioSource congratssfx;

    [SerializeField] private AudioSource collectsfx;

    private float score;

    public float congr;

    public static float tscore;

    public TextMeshProUGUI tickScoreUI;

    private void Awake()
    {

        congr = PlayerPrefs.GetFloat("congr", congr);  
        ticksprite.enabled = true;
        //PlayerPrefs.SetFloat("tscore", tscore);
        tickScoreUI.text = "Ticks " + PlayerPrefs.GetFloat("tscore", tscore);

    }

    public void Tick()
    {

        goldtickscreen.gameObject.SetActive(true);
        ticksprite.enabled = false;
        collectsfx.Play();
        tscore = PlayerPrefs.GetFloat("tscore", tscore) + 1;
        PlayerPrefs.SetFloat("tscore", tscore);
        tickScoreUI.text = "Ticks " + PlayerPrefs.GetFloat("tscore", tscore);

    }
    public void Congrats()
    {

        StartCoroutine("CongratsCo");

    }
    public IEnumerator CongratsCo()
    {
        if (PlayerPrefs.GetFloat("tscore", tscore) == 10 && congr == 0)
        {

            yield return new WaitForSeconds(1.5f);
            //congratssfx.Play();
            Congrats1.gameObject.SetActive(true);
            Congrats2.gameObject.SetActive(true);
            yield return new WaitForSeconds(0.0f);
            congr = PlayerPrefs.GetFloat("congr", congr) + 1;
            PlayerPrefs.SetFloat("congr", congr);

        }

    }

    void Update()
    {
        Congrats();

        score += Time.deltaTime * 10;

        if (score >= 1000 & score < 1001)
        {
            spawnObject.gameObject.SetActive(true);
            //Instantiate(spawnObject, spawnObject.transform.position, Quaternion.identity);

        }

        tickScoreUI.text = "Ticks " + PlayerPrefs.GetFloat("tscore", tscore);

    }

}

