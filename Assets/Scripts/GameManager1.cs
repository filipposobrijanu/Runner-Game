using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager1 : MonoBehaviour
{
    //public GameObject spawnObject;
   // public GameObject spawnObject1;
    public GameObject[] spawnObject1;
    public GameObject[] spawnObject;
    public GameObject[] spawnObject0;
    public GameObject[] spawnPoints;
    public GameObject[] spawnPoints1;
    public GameObject[] spawnPoints2;
    public double timer;
    public float timeBetweenSpawns;
    public float timer1;
    public float timeBetweenSpawns1;
    public float timer2;
    public float timeBetweenSpawns2;
    public float speedMultiplier;
    public TextMeshProUGUI scoreUI;
    public TextMeshProUGUI highScoreUI;
    private float score;
    private float highScore;

    [SerializeField] private AudioSource deathsfx;


    public PlayerMovement player;
    public PlayerMovement player1;
    public PlayerMovement player2;
    public PlayerMovement player3;
    public PlayerMovement player4;
    public Vector3 playerStartPoint;
    public Vector3 spawnPointStartPoint;
    public Vector3 spawnPoint1StartPoint;

    public FPSCounter fps;

    private void Start()
    {
        
        //PlayerPrefs.DeleteAll();
        //SceneManager.LoadScene(1);  

        fps.SaveFPS();

    }

    public void RestartGame()
    {

        StartCoroutine("RestartGameCo");

    }

    public IEnumerator RestartGameCo()
    {
        deathsfx.Play();
        player.gameObject.SetActive(false);
        player1.gameObject.SetActive(false);
        player2.gameObject.SetActive(false);
        player3.gameObject.SetActive(false);
        player4.gameObject.SetActive(false);
        fps.SaveFPS();
        yield return new WaitForSeconds(0.6f);
        SceneManager.LoadScene(1);
        //Time.timeScale = 0;
        //spawnPoints = GameObject.FindGameObjectsWithTag("Enemy");
        //spawnPoints1 = GameObject.FindGameObjectsWithTag("Bg");
        //for (int i = 0; i < spawnPoints.Length; i++)
        //{
        //    
        //    spawnPoints[i].gameObject.SetActive(false);
        //
        //}
        //for (int i = 0; i < spawnPoints1.Length; i++)
        //{
        //
        //    spawnPoints1[i].gameObject.SetActive(false);
        //
        //}
        //
        //        player.transform.position = playerStartPoint;
        //        timer = 1.5;
        //        timer1 = 1;
        //        speedMultiplier = 0;
        //        player.gameObject.SetActive(true);
        //        score = 0;
        //       spawnObject.gameObject.SetActive(true);
        //        spawnObject1.gameObject.SetActive(true);
        //       spawnPointStartPoint = spawnObject.transform.position;
        //        spawnPoint1StartPoint = spawnObject1.transform.position;
        //
        //
    } 

    void Update()
    {
        //triescount = PlayerPrefs.GetFloat("triescount", triescount);

        score += Time.deltaTime * 10;

        //highScoreUI.text = "High Score " + Mathf.Round(PlayerPrefs.GetFloat("highscore", score));

        speedMultiplier += Time.deltaTime *  0.2f;

        timer1 += Time.deltaTime * 1f;
        timer += Time.deltaTime * 1.5f;
        timer2 += Time.deltaTime * 0.9f;


        if (timer > timeBetweenSpawns)
        {
            timer = 0;
            int randNum1 = Random.Range(0, 1);
            int randNum = Random.Range(0, 2);
            if (score >= 400 && score < 800)
            {

                randNum1 = Random.Range(0, 2);

            }
            else if (score >= 800)
            {

                randNum1 = Random.Range(1, 3);

            }
            Instantiate(spawnObject[randNum1], spawnPoints[randNum].transform.position, Quaternion.identity);

        }

        if (timer1 > timeBetweenSpawns1)
        {
            timer1 = 0;
            int randNum = Random.Range(0, 2);
            Instantiate(spawnObject0[randNum], spawnPoints1[randNum].transform.position, Quaternion.identity);

        }

        if (timer2 > timeBetweenSpawns2)
        {
            timer2 = 0;
            int randNum = Random.Range(0, 2);
            Instantiate(spawnObject1[randNum], spawnPoints2[randNum].transform.position, Quaternion.identity);

        }

    }
}
