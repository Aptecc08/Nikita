using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    public GameObject Menu1;
    public GameObject Menu2;
    public GameObject Canvas;
    public void Exit()
    {
        Application.Quit();
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void Settings()
    {
        Canvas.SetActive(false);
        Menu2.SetActive(true);

    }
    public void Back()
    {
        Canvas.SetActive(true);
        Menu2.SetActive(false);

    }
}
