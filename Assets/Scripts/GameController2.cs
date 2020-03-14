using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController2 : MonoBehaviour {

    public int Blood;
    public GameObject[] hazards;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public GameObject EnemyShip1;
    public GameObject Crate;
    public GameObject Crate1;
    public GameObject Player;
    public int waveCount;
    public bool gameOver;
    public bool restart;
    public bool NextScene;
    public GameObject[] character;
    public GUIText restartText;
    public Text gameOverText;



    void Start()
    {
        NextScene = false;
        gameOver = false;
        restart = false;
        restartText.text = "";
       gameOverText.text = "";
        StartCoroutine(SpawnWaves());
        waveCount = 0;
        Blood = 0;
        //	charachange ();


        //Debug.Log("==============" + CharacterCreation.s);

        Player = character[CharacterCreation.s];
        Vector3 spawnPosition = new Vector3(0, 0, 0);
        Quaternion spawnRotation = Quaternion.identity;
        Instantiate(Player, spawnPosition, spawnRotation);
    }

    void Update()
    {
        if (NextScene)
            Invoke("Gotonext", 2);
    }
    void Gotonext()
    {
        SceneManager.LoadScene("main2");

    }

    IEnumerator SpawnWaves()

    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            waveCount++;
            if (waveCount == 10)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(EnemyShip1, spawnPosition, spawnRotation);
            }
            else if (waveCount == 3)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(Crate, spawnPosition, spawnRotation);
            }
            else if (waveCount % 7 == 0)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(Crate1, spawnPosition, spawnRotation);


            }
            for (int i = 0; i < hazardCount; i++)
            {
                GameObject hazard = hazards[Random.Range(0, hazards.Length)];
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);

            if (gameOver)
            {
                restartText.text = "Press 'R' for Restart";
                restart = true;
                break;
            }
        }
    }
    public void charachange(int s)
    {
        Player = character[s];
    }

    public void GameOver()
    {
        Debug.Log("in game over");
        gameOverText.text = "Game Over!";
        gameOver = true;
    }

}

