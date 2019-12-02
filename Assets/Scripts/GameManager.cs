using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;

    [SerializeField] private Move _moving;

    private void Start() 
    {
        Time.timeScale = 1;
        gameOverCanvas.SetActive(false);
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        _moving.enabled = false;
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
}
