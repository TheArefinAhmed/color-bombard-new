using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collisionDetectorLevel9 : MonoBehaviour
{

    public GameObject magentaRemain;
    public GameObject cyanRemain;
    public GameObject yellowRemain;
    public GameObject orangeRemain;
    public GameObject brownRemain;
    public GameObject purpleRemain;
    public GameObject offwhiteRemain;

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

        else if (collision.tag == "purple")
        {
            if (PlayerPrefs.GetInt("soundStatus") != 1)
            {
                soundManagerScript.PlaySound("shoot");
            }
            purpleRemain.SetActive(true);
        }

         else if (collision.tag == "yellow")
        {
            if (PlayerPrefs.GetInt("soundStatus") != 1)
            {
                soundManagerScript.PlaySound("shoot");
            }
            yellowRemain.SetActive(true);
        }



        else if (collision.tag == "orange")
        {
            if (PlayerPrefs.GetInt("soundStatus") != 1)
            {
                soundManagerScript.PlaySound("shoot");
            }
            orangeRemain.SetActive(true);
        }


        else if (collision.tag == "brown")
        {
            if (PlayerPrefs.GetInt("soundStatus") != 1)
            {
                soundManagerScript.PlaySound("shoot");
            }
            brownRemain.SetActive(true);
        }

        else if (collision.tag == "offwhite")
        {
            if (PlayerPrefs.GetInt("soundStatus") != 1)
            {
                soundManagerScript.PlaySound("shoot");
            }

            offwhiteRemain.SetActive(true);
            Scene currentScene = SceneManager.GetActiveScene();

            string sceneName = currentScene.name;

            switch (sceneName)
            {
                case "Scene9":
                    PlayerPrefs.SetInt("level9status", 1);
                    break;
                case "Scene8":
                    PlayerPrefs.SetInt("level8status", 1);
                    break;
                case "Scene12":
                    PlayerPrefs.SetInt("level12status", 1);
                    break;
                case "Scene13":
                    PlayerPrefs.SetInt("level13status", 1);
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
            case "Scene9":
                SceneManager.LoadScene("Scene9");
                break; 
            case "Scene8":
                SceneManager.LoadScene("Scene8");
                break;
            case "Scene12":
                SceneManager.LoadScene("Scene12");
                break;
            case "Scene13":
                SceneManager.LoadScene("Scene13");
                break;
        }
        
    }


}