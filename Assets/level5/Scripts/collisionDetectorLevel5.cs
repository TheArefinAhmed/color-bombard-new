using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collisionDetectorLevel5 : MonoBehaviour
{

    public GameObject magentaRemain;
    public GameObject cyanRemain;
    public GameObject greenRemain;
    public GameObject orangeRemain;
    public GameObject yellowremain;
    public GameObject purpleremain;


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
        else if (collision.tag == "orange")
        {
            if (PlayerPrefs.GetInt("soundStatus") != 1)
            {
                soundManagerScript.PlaySound("shoot");
            }
            orangeRemain.SetActive(true);
        }
        else if (collision.tag == "yellow")
        {
            if (PlayerPrefs.GetInt("soundStatus") != 1)
            {
                soundManagerScript.PlaySound("shoot");
            }
            yellowremain.SetActive(true);
        }  
        else if (collision.tag == "purple")
        {
            if (PlayerPrefs.GetInt("soundStatus") != 1)
            {
                soundManagerScript.PlaySound("shoot");
            }
            purpleremain.SetActive(true);
            PlayerPrefs.SetInt("level5status", 1);
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
        print(sceneName);
        switch (sceneName)
        {
            case "Scene5":
                SceneManager.LoadScene("Scene5");
                break;
            case "Scene6":
                SceneManager.LoadScene("Scene6");
                break;
        }
        //SceneManager.LoadScene("Scene5");
    }


}
