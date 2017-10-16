using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject[] hazards;
    public float startWait = 1;
    public float spawnWait = 0.75f;
    public float waveWait = 2;


    public GUIText scoreText;
    public GUIText restartText;
    public GUIText gameOverText;


    int score;
    bool gameover;
    bool restart;

    void Start()
    {


        score = 0;
        restartText.text = "";
        gameOverText.text = "";
        UpdateScore();
        StartCoroutine(SpawnWaves());
        gameover = false;
        restart = false;

    }

   public void AddScore(int newScore)
    {

        score += newScore;
        UpdateScore();

    }

    public void GameOver()
    {

        gameOverText.text = "응 망했어 다시해";
        gameover = true;



    }



    void UpdateScore()
    {
        scoreText.text = "점수 : " + score;



    }


    IEnumerator SpawnWaves()
    {

        yield return new WaitForSeconds(startWait);

        while (true)
        { 

        for (int i = 0; i < 10; ++i)
        {
            GameObject hazard = hazards[Random.Range(0, hazards.Length)];
            Vector3 spawnPosition = new Vector3(Random.Range(-5, 5), 5, 16);
            Quaternion spawnRotation = Quaternion.Euler(new Vector3(0, 180, 0));
            Instantiate(hazard, spawnPosition, spawnRotation);


            yield return new WaitForSeconds(spawnWait);

        }


        yield return new WaitForSeconds(waveWait);

            if (gameover == true)
            {

                restartText.text = "R키를 눌러주세요";
                restart = true;
                break;



            }


    }
}
	
	void Update ()
    {

        if (restart == true)
        {

            if (Input.GetKeyDown(KeyCode.R) == true)
            {

                Application.LoadLevel(Application.loadedLevel);


            }



        }


	}

}
