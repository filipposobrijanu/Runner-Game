using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPausePlay : MonoBehaviour
{

    [SerializeField] private AudioSource clicksfx;

    public void ClickSfx()
    {

        clicksfx.Play();

    }
}
