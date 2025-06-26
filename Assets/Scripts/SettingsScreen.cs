using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsScreen : MonoBehaviour
{
    [SerializeField] private AudioSource clicksfx;


    public void Settings()
    {
        clicksfx.Play();
        //StartCoroutine("SettingsCo");

    }

    public IEnumerator SettingsCo()
    {

        clicksfx.Play();
        yield return new WaitForSeconds(0.2f);


    }
}
