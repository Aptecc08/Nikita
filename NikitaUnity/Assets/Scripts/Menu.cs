using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject MenuSettings;
    public void Exit()
    {
        Application.Quit();
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    
    public void SettingsBack()
    {
        MainMenu.SetActive(!MainMenu.activeSelf);
        MenuSettings.SetActive(!MenuSettings.activeSelf);
    }
}
