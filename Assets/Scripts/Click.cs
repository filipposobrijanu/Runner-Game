using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{

    public static Click instance { get; private set; }

    [SerializeField] private AudioSource clicksfx;

    private void Awake()
    {

        if (instance == null)
        {

            instance = this;
            DontDestroyOnLoad(gameObject);

        }

        else if (instance != null && instance != this)
        {

            Destroy(gameObject);

        }

    }

    public void ClickSfx()
    {

        clicksfx.Play();

    }
}
