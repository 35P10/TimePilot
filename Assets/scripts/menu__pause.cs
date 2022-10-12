using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu__pause : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject exitMenu;
    public bool isPaused;

    void Start(){
        pauseMenu.SetActive(false);
        exitMenu.SetActive(false);
        isPaused = false;
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(isPaused){
                ResumeGame();
            }
            else {
                PauseGame();
            }
        }
    }

    public void PauseGame(){
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame(){
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void open_exitGame(){
        pauseMenu.SetActive(false);
        exitMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void exitGame_yes(){
        SceneManager.LoadScene("menu");
    }

    public void exitGame_no(){
        exitMenu.SetActive(false);
        pauseMenu.SetActive(true);
    }
}
