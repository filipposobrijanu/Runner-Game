using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    [SerializeField] private AudioSource clicksfx;

    public void StartGame()
    {

        StartCoroutine("StartGameCo");

    }

    public void ClickSfx()
    {

        clicksfx.Play();

    }

    public IEnumerator StartGameCo()
    {

        ClickSfx();
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene(0);

    }

    public void QuitGame()
    {

        Application.Quit();

    }
}
