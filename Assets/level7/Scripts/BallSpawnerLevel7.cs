using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallSpawnerLevel7 : MonoBehaviour
{

    public GameObject ballObj;

    public GameObject ballObj2;
    public GameObject ballObj3;
    public GameObject ballObj4;
    public GameObject ballObj5;
    public GameObject ballObj6;
    public GameObject ballObj7;

    //public GameObject location;

    private bool isCreated;
    private bool isCreated2 = true;
    private bool isCreated3 = true;
    private bool isCreated4 = true;
    private bool isCreated5 = true;
    private bool isCreated6 = true;
    private bool isCreated7 = true;

    int unlockLevel2 = 0;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {


            if (!isCreated)
            {
                if (PlayerPrefs.GetInt("soundStatus") != 1)
                {
                    soundManagerScript.PlaySound("blast");
                }
                ballObj.SetActive(true);
                isCreated = true;
                isCreated2 = false;

            }

            else if (!isCreated2)
            {
                if (PlayerPrefs.GetInt("soundStatus") != 1)
                {
                    soundManagerScript.PlaySound("blast");
                }
                ballObj2.SetActive(true);
                isCreated2 = true;
                isCreated3 = false;
            }

            else if (!isCreated3)
            {
                if (PlayerPrefs.GetInt("soundStatus") != 1)
                {
                    soundManagerScript.PlaySound("blast");
                }
                ballObj3.SetActive(true);
                isCreated3 = true;
                isCreated4 = false;
            }

            else if (!isCreated4)
            {
                if (PlayerPrefs.GetInt("soundStatus") != 1)
                {
                    soundManagerScript.PlaySound("blast");
                }
                ballObj4.SetActive(true);
                isCreated4 = true;
                isCreated5 = false;

            }
            else if (!isCreated5)
            {
                if (PlayerPrefs.GetInt("soundStatus") != 1)
                {
                    soundManagerScript.PlaySound("blast");
                }
                ballObj5.SetActive(true);
                isCreated5 = true;
                isCreated6 = false;
            }
            else if (!isCreated6)
            {
                if (PlayerPrefs.GetInt("soundStatus") != 1)
                {
                    soundManagerScript.PlaySound("blast");
                }
                ballObj6.SetActive(true);
                isCreated6 = true;
                isCreated7 = false;

            }
            else if (!isCreated7)
            {
                if (PlayerPrefs.GetInt("soundStatus") != 1)
                {
                    soundManagerScript.PlaySound("blast");
                }
                ballObj7.SetActive(true);
                isCreated7 = true;
                PlayerPrefs.SetInt("currentLevel", 8);
                StartCoroutine(levelUnlock());
                levelTextMesh.currentLevel = 8;
            }

        }


    }

    IEnumerator levelUnlock()
    {
        yield return new WaitForSeconds(1);
        if (PlayerPrefs.GetInt("level7status") == 1)
        {
            SceneManager.LoadScene("SuccessSceneLevel7");
            PlayerPrefs.SetInt("level7status", 0);    


        }



    }
}
