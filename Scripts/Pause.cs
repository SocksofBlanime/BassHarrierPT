using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public static bool isGamePaused = false;
    [SerializeField] GameObject pauseMenu;
    public AudioSource theMusic;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (isGamePaused)
            {
                ResumeGame();
                theMusic.Play();
            }
            else
            {
                PauseGame();
                theMusic.Stop();
            }
        }
    }

   public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        isGamePaused = false;
    }

    void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        isGamePaused = true;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Mainmenu");
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
