using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BackOut : MonoBehaviour
{
    public string mainMenuLevel;
    public void RestartButton() {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex); 
    }

    public void QuitButton(){
        SceneManager.LoadScene(" ");
    } 
}
