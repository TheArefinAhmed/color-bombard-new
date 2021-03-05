using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BAllSpawnerLevel9 : MonoBehaviour
{

    public GameObject ballObj;

    public GameObject ballObj2;
    public GameObject ballObj3;
    public GameObject ballObj4;
    public GameObject ballObj5;
    public GameObject ballObj6;
    public GameObject ballObj7;


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
                StartCoroutine(levelUnlock());

            }

            

        }


    }

    IEnumerator levelUnlock()
    {
        yield return new WaitForSeconds(2);

        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;

        switch (sceneName)
        {
            case "Scene9":
                if (PlayerPrefs.GetInt("level9status") == 1)
                {
                    SceneManager.LoadScene("SuccessSceneLevel9");
                    levelTextMesh.currentLevel = 10;
                    PlayerPrefs.SetInt("level9status", 0);
                }
                break;
            case "Scene8":
                if (PlayerPrefs.GetInt("level8status") == 1)
                {
                    levelTextMesh.currentLevel = 9;
                    SceneManager.LoadScene("SuccessSceneLevel8");
                    PlayerPrefs.SetInt("level8status", 0);
                }
                break;
            case "Scene12":
                if (PlayerPrefs.GetInt("level12status") == 1)
                {
                    levelTextMesh.currentLevel = 13;
                    SceneManager.LoadScene("SuccessSceneLevel12");
                    PlayerPrefs.SetInt("level12status", 0);
                }
                break;
            case "Scene13":
                if (PlayerPrefs.GetInt("level13status") == 1)
                {
                    levelTextMesh.currentLevel = 14;
                    SceneManager.LoadScene("SuccessSceneLevel13");
                    PlayerPrefs.SetInt("level13status", 0);
                }
                break;
        }

    



    }
}
