using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    [SerializeField] private AudioSource clicksfx;

    [SerializeField] public AudioSource click1sfx;


    public void StartGame()
    {

        StartCoroutine("StartGameCo");

    }

    public void ClickSfx()
    {

        clicksfx.Play();

    }

    public void Click1Sfx()
    {

        click1sfx.Play();

    }

    public IEnumerator StartGameCo()
    {

        ClickSfx();
        yield return new WaitForSeconds(0.25f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void QuitGame()
    {

        Application.Quit();

    }
}
