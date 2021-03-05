using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collisionDetectorLevel7 : MonoBehaviour
{

    public GameObject magentaRemain;
    public GameObject cyanRemain;
    public GameObject brownRemain;
    public GameObject orangeRemain;
    public GameObject yellowRemain;
    public GameObject chocolateRemain;
    public GameObject ashRemain;


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

        else if (collision.tag == "brown")
        {
            if (PlayerPrefs.GetInt("soundStatus") != 1)
            {
                soundManagerScript.PlaySound("shoot");
            }
            brownRemain.SetActive(true);
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
            yellowRemain.SetActive(true);
        }

        else if (collision.tag == "chocolate")
        {
            if (PlayerPrefs.GetInt("soundStatus") != 1)
            {
                soundManagerScript.PlaySound("shoot");
            }
            chocolateRemain.SetActive(true);
        } 

        else if (collision.tag == "ash")
        {
            if (PlayerPrefs.GetInt("soundStatus") != 1)
            {
                soundManagerScript.PlaySound("shoot");
            }
            ashRemain.SetActive(true);
            PlayerPrefs.SetInt("level7status", 1);
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
        SceneManager.LoadScene("Scene7");
    }


}
