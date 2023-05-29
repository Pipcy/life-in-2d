using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public AudioSource bgMusic1;
    public AudioSource bgMusic2;
    public Button pauseBtn;

    Routine rt;
    /*
        to use this vaiable in other scripts:
        directly refer to it as "PauseMenu.GameIsPaused", no need of anything else.

    */
    void Start()
    {
        GameObject routine = GameObject.Find("Routine"); ;
		rt = routine.GetComponent<Routine>();
    }

    public GameObject pauseMenuUI;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }



    public void Resume ()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        pauseBtn.enabled = true;
        GameIsPaused = false;

        if(rt.isDreaming) {bgMusic1.UnPause();}
        else{bgMusic2.UnPause();}
    }

    public void Pause()
    {
        pauseBtn.enabled = false;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        //bgMusic.Pause();
        GameIsPaused = true;

        if(rt.isDreaming) {bgMusic1.Pause();}
        else{bgMusic2.Pause();}
    }

    public void LoadTutorial()
    {
        SceneManager.LoadScene("tutorial");
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Title");
    }
}