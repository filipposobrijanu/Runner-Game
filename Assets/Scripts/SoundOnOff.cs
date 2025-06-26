using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundOnOff : MonoBehaviour
{
    [SerializeField] Image Audioonicon;

    [SerializeField] Image Audioofficon;

    private bool muted = false;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("muted"))
        {

            PlayerPrefs.SetInt("muted", 0);
            Load();

        }

        else
        {

            Load();

        }

        UpdateButtonIcon();
        AudioListener.pause = muted;

    }

    public void OnButtonPress()
    {
        if (muted == false)
        {
            muted = true;
            AudioListener.pause = true;

        }

        else
        {
            muted = false;
            AudioListener.pause = false;

        }

        Save();
        UpdateButtonIcon();

    }

    private void UpdateButtonIcon()
    {
        if (muted == false)
        {
            Audioofficon.enabled = false;
            Audioonicon.enabled = true;

        }

        else
        {
            Audioofficon.enabled = true;
            Audioonicon.enabled = false;

        }

    }

    private void Load()
    {

        muted = PlayerPrefs.GetInt("muted") == 1;

    }

    private void Save()
    {

        PlayerPrefs.SetInt("muted", muted ? 1 : 0);

    }
}
