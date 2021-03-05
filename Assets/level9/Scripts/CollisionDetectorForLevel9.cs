using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetectorForLevel9 : MonoBehaviour
{

    public GameObject magentaRemain;
    public GameObject cyanRemain;
    public GameObject greenRemain;
    public GameObject purpleRemain;
    public GameObject offwhiteRemain;
    public GameObject ashRemain;
    public GameObject grayRemain;
    public GameObject orangeRemain;
    //public GameObject blueRemain;
    //public GameObject redRemain;
    //public GameObject brownRemain;


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

        else if (collision.tag == "ash")
        {
            if (PlayerPrefs.GetInt("soundStatus") != 1)
            {
                soundManagerScript.PlaySound("shoot");
            }
            ashRemain.SetActive(true);
        }

        else if (collision.tag == "gray")
        {
            if (PlayerPrefs.GetInt("soundStatus") != 1)
            {
                soundManagerScript.PlaySound("shoot");
            }
            grayRemain.SetActive(true);
        }

        else if (collision.tag == "orange")
        {
            if (PlayerPrefs.GetInt("soundStatus") != 1)
            {
                soundManagerScript.PlaySound("shoot");
            }
            orangeRemain.SetActive(true);
            Scene currentScene = SceneManager.GetActiveScene();

            string sceneName = currentScene.name;

            switch (sceneName)
            {
                case "Scene8":
                    PlayerPrefs.SetInt("level8status", 1);
                    break;
                case "Scene9":
                    PlayerPrefs.SetInt("level9status", 1);
                    break;
                case "Scene14":
                    PlayerPrefs.SetInt("level14status", 1);
                    break;
                case "Scene15":
                    PlayerPrefs.SetInt("level15status", 1);
                    break;
                case "Scene16":
                    PlayerPrefs.SetInt("level16status", 1);
                    break;
                case "Scene17":
                    PlayerPrefs.SetInt("level17status", 1);
                    break;
                case "Scene18":
                    PlayerPrefs.SetInt("level18status", 1);
                    break;
                case "Scene19":
                    PlayerPrefs.SetInt("level19status", 1);
                    break;
                case "Scene20":
                    PlayerPrefs.SetInt("level20status", 1);
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
            case "Scene8":
                SceneManager.LoadScene("Scene8");
                break;
            case "Scene9":
                SceneManager.LoadScene("Scene9");
                break;
            case "Scene14":
                SceneManager.LoadScene("Scene14");
                break;
            case "Scene15":
                SceneManager.LoadScene("Scene15");
                break;
            case "Scene16":
                SceneManager.LoadScene("Scene16");
                break;
            case "Scene17":
                SceneManager.LoadScene("Scene17");
                break;
            case "Scene18":
                SceneManager.LoadScene("Scene18");
                break;
            case "Scene19":
                SceneManager.LoadScene("Scene19");
                break;
            case "Scene20":
                SceneManager.LoadScene("Scene20");
                break;
        }


    }


}
