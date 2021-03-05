using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;

    }

}