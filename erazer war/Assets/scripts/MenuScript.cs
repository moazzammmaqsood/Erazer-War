using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScript : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;
    void Start()
    {
        // PauseMenuUI = GameObject.FindGameObjectWithTag("bgpanel");
    }
    public void pauseGame()
    {
        Debug.Log("Game Paused");
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;


    }
    // Update is called once per frame
    public void resume()
    {
        Debug.Log("GG");
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void quit()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }
    public void restart(){
        Debug.Log("reloading scene");
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
