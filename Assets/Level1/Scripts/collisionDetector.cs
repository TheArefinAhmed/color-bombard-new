using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collisionDetector : MonoBehaviour
{

    public GameObject magentaRemain;
    public GameObject yellowRemain;
    public GameObject purpleRemain;


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

        else if (collision.tag == "yellow")
        {
            if (PlayerPrefs.GetInt("soundStatus") != 1)
            {
                soundManagerScript.PlaySound("shoot");
            }
            yellowRemain.SetActive(true);
        }
        else if (collision.tag == "purple")
        {
            if (PlayerPrefs.GetInt("soundStatus") != 1)
            {
                soundManagerScript.PlaySound("shoot");
            }
            purpleRemain.SetActive(true);
            PlayerPrefs.SetInt("level1status", 1);
        }

        if (gameObject.name != collision.name)
        {
            if (PlayerPrefs.GetInt("soundStatus") != 1)
            {
                soundManagerScript.PlaySound("GameOver");
            }
            midPoint.SetActive(false);
            Invoke("wait", 2);
        }


        else if (collision.tag == name)
        {
            Destroy(collision.gameObject);
            
        }

    }

    public void wait()
    {
        SceneManager.LoadScene("Scene1");
    }

    
}
