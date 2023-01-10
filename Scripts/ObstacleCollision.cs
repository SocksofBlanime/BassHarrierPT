using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject mainCam;
    public GameObject gameOverScreen;
    public AudioSource theMusic;
   

    public void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.gameObject.GetComponent<PlayerMove>().enabled = false;
        mainCam.GetComponent<Animator>().enabled = true;
        gameOverScreen.SetActive(true);
        theMusic.Pause();
    }

    
}
