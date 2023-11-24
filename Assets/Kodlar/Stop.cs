using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Cinemachine;


public class Stop : MonoBehaviour
{
    public bool oyundurdumu = false;

    public GameObject PauseMenuScreen;
    public GameObject AyarlarEkran;



    public void oyunudurdur()
    {
        Time.timeScale = 0f;
        PauseMenuScreen.SetActive(true);


    }

    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
    public void PlayGame()
    {
        Time.timeScale = 1f;
        PauseMenuScreen.SetActive(false);
        AyarlarEkran.SetActive(false);

    }
    public void Home()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
    public void Settings()
    {
        AyarlarEkran.SetActive(true);
        Time.timeScale = 1f;
    }



}
