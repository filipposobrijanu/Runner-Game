using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PausePlay : MonoBehaviour
{
    [SerializeField] Image Pauseicon;

    [SerializeField] Image Playicon;

    private float sit = 0;

    public void Pause_Play()
    {
        if (sit == 0)
        {
            Pauseicon.gameObject.SetActive(false);
            Playicon.gameObject.SetActive(true);
            sit = 1;
            Time.timeScale = 0;

        }
        else if (sit == 1)
        {
            Pauseicon.gameObject.SetActive(true);
            Playicon.gameObject.SetActive(false);
            sit = 0;
            Time.timeScale = 1;

        }


    }

}
