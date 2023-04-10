using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject mainCam;
    public GameObject gameOverScreen;
    public AudioSource theMusic;
    private ScoreManager theScoreManager;


    public void OnTriggerEnter(Collider other)

    {
        if (other.gameObject.CompareTag("Player"))
        {

            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            thePlayer.gameObject.GetComponent<PlayerMove>().enabled = false;
            mainCam.GetComponent<Animator>().enabled = true;
            gameOverScreen.SetActive(true);
            theMusic.Pause();
        }

        if (other.gameObject.CompareTag("Backwall"))
        {
            Destroy(this.gameObject);
        }
    }
}

