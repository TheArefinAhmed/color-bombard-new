using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetectorlevel3 : MonoBehaviour
{

    public GameObject magentaRemain;
    public GameObject cyanRemain;
    public GameObject greenRemain;
    public GameObject orangeRemain;


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
            PlayerPrefs.SetInt("level3status", 1);
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
        SceneManager.LoadScene("Scene3");
    }


}
