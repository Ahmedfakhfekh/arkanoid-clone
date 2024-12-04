using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsManager : MonoBehaviour
{
    GameObject winPanel;
    void Start()
    {
        winPanel = GameObject.Find("Panel");   
    }
    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
        winPanel.SetActive(false);

    }
}
