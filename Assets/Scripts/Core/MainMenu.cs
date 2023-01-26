using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void MenuScreen()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    public void Level1()
    {
        SceneManager.LoadScene(1);
    }
        public void Level2()
    {
        SceneManager.LoadScene(2);
    }
        public void Level3()
    {
        SceneManager.LoadScene(3);
    }
        public void QuitGame()
    {
        Application.Quit();
    }
    public void CurrentScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
}
