using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetectorLevel10 : MonoBehaviour
{

    public GameObject magentaRemain;
    public GameObject cyanRemain;
    public GameObject greenRemain;
    public GameObject offwhiteRemain;
    public GameObject blueRemain;
    public GameObject purpleRemain;
    public GameObject orangeRemain;
    public GameObject redRemain;
    public GameObject grayRemain;

    public GameObject midPoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "magenta")
        {
            if (PlayerPrefs.GetInt("soundStatus") != 1)
            {
                soundManagerScript.PlaySound("shoot");
            }
            magentaRemain.SetActive(true);
        }

        else if (collision.tag == "cyan")
        {
            if (PlayerPrefs.GetInt("soundStatus") != 1)
            {
                soundManagerScript.PlaySound("shoot");
            }
            cyanRemain.SetActive(true);
        }

        else if (collision.tag == "green")
        {
            if (PlayerPrefs.GetInt("soundStatus") != 1)
            {
                soundManagerScript.PlaySound("shoot");
            }
            greenRemain.SetActive(true);
        }

        else if (collision.tag == "offwhite")
        {
            if (PlayerPrefs.GetInt("soundStatus") != 1)
            {
                soundManagerScript.PlaySound("shoot");
            }
            offwhiteRemain.SetActive(true);
        }

        else if (collision.tag == "blue")
        {
            if (PlayerPrefs.GetInt("soundStatus") != 1)
            {
                soundManagerScript.PlaySound("shoot");
            }
            blueRemain.SetActive(true);
        }


        else if (collision.tag == "purple")
        {
            if (PlayerPrefs.GetInt("soundStatus") != 1)
            {
                soundManagerScript.PlaySound("shoot");
            }
            purpleRemain.SetActive(true);
        }

        else if (collision.tag == "orange")
        {
            if (PlayerPrefs.GetInt("soundStatus") != 1)
            {
                soundManagerScript.PlaySound("shoot");
            }
            orangeRemain.SetActive(true);
        }

        else if (collision.tag == "red")
        {
            if (PlayerPrefs.GetInt("soundStatus") != 1)
            {
                soundManagerScript.PlaySound("shoot");
            }
            redRemain.SetActive(true);
        }

        else if (collision.tag == "gray")
        {
            if (PlayerPrefs.GetInt("soundStatus") != 1)
            {
                soundManagerScript.PlaySound("shoot");
            }
            grayRemain.SetActive(true);

            Scene currentScene = SceneManager.GetActiveScene();

            string sceneName = currentScene.name;

            switch (sceneName)
            {
                case "Scene10":
                    PlayerPrefs.SetInt("level10status", 1);
                    break;
                case "Scene11":
                    PlayerPrefs.SetInt("level11status", 1);
                    break;
            }

            
        }

        if (gameObject.name != collision.name)
        {
            if (PlayerPrefs.GetInt("soundStatus") != 1)
            {
                soundManagerScript.PlaySound("GameOver");
            }
            midPoint.SetActive(false);
            Invoke("wait", 2);
            PlayerPrefs.SetInt("gameHasFinished", 1);
            print("Game Over");
        }

        else if (collision.tag == name)
        {
            Destroy(collision.gameObject);
        }

    }

    public void wait()
    {


        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;

        switch (sceneName)
        {
            case "Scene10":
                SceneManager.LoadScene("Scene10");
                break;
            case "Scene11":
                SceneManager.LoadScene("Scene11");
                break;
        }
    }
}