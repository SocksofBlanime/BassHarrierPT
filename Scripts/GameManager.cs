using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;

    public bool startPlaying;

    public Kremlings kremlings;
    public GameObject thePlayer;

    public static GameManager instance;

    public int currentScore;
    public int scorePerNote = 100;
    public int scorePerGoodNote = 200;
    public int scorePerPerfectNote = 500;
    public static int score;

    public int currentMultiplier;
    public int multiplierTracker;
    public int[] multiplierThresholds;

    public Text scoreText;
    public Text multiText;

    public float totalEnemies;

    public GameObject resultsScreen;
    public Text  finalScoreText;
    private ScoreManager thescoreManager;
    

    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        scoreText.text = "Score: 0";
        currentMultiplier = 1;

        thescoreManager = FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
       

        if (!startPlaying)
        {
            startPlaying = true;
            theMusic.Play();
        }
        else
        {
           if (!theMusic.isPlaying && !resultsScreen.activeInHierarchy)
           {
                resultsScreen.SetActive(true);
                thePlayer.gameObject.GetComponent<PlayerMove>().enabled = false;
                thescoreManager.scoreIncreasing = false;
            }
               
            
        }
        
       
    }

  

    void FixedUpdate()
    {
        totalEnemies = FindObjectsOfType<Enemy>().Length;
        finalScoreText.text = currentScore.ToString();
    }

    public void EnemyHit()
    {
       

        if(currentMultiplier - 1 < multiplierThresholds.Length)
        {
            multiplierTracker++;

            if (multiplierThresholds[currentMultiplier - 1] <= multiplierTracker)
            {
                multiplierTracker = 0;
                currentMultiplier++;
            }
        }

        multiText.text = "Multiplier: x" + currentMultiplier;

        currentScore += scorePerNote * currentMultiplier;
        scoreText.text = "Score: " + currentScore;
    }

    public void NormalEnemy()
    {
        currentScore += scorePerNote * currentMultiplier;
        EnemyHit();

    }

    public void AcidEnemy()
    {
        currentScore += scorePerGoodNote * currentMultiplier;
        EnemyHit();

    }

    public void ZapptaEnemy()
    {
        currentScore += scorePerPerfectNote * currentMultiplier;
        EnemyHit();

    }

    public void EnemyMissed()
    {

        currentMultiplier = 1;
        multiplierTracker = 0;

        multiText.text = "Multiplier: x" + currentMultiplier;


    }
}
