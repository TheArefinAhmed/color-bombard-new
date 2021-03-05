using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallSpawnerLevel8 : MonoBehaviour
{

    public GameObject ballObj;

    public GameObject ballObj2;
    public GameObject ballObj3;
    public GameObject ballObj4;
    public GameObject ballObj5;
    public GameObject ballObj6;
    public GameObject ballObj7;
    public GameObject ballObj8;
    public GameObject ballObj9;
    public GameObject ballObj10;
    public GameObject ballObj11;

    //public GameObject location;

    private bool isCreated;
    private bool isCreated2 = true;
    private bool isCreated3 = true;
    private bool isCreated4 = true;
    private bool isCreated5 = true;
    private bool isCreated6 = true;
    private bool isCreated7 = true;
    private bool isCreated8 = true;
    private bool isCreated9 = true;
    private bool isCreated10 = true;
    private bool isCreated11 = true;

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
                isCreated8 = false;


            } 
            else if (!isCreated8)
            {
                if (PlayerPrefs.GetInt("soundStatus") != 1)
                {
                    soundManagerScript.PlaySound("blast");
                }
                ballObj8.SetActive(true);
                isCreated8 = true;
                isCreated9 = false;

            }

            else if (!isCreated9)
            {
                if (PlayerPrefs.GetInt("soundStatus") != 1)
                {
                    soundManagerScript.PlaySound("blast");
                }
                ballObj9.SetActive(true);
                isCreated9 = true;
                isCreated10 = false;
            }
            else if (!isCreated10)
            {
                if (PlayerPrefs.GetInt("soundStatus") != 1)
                {
                    soundManagerScript.PlaySound("blast");
                }
                ballObj10.SetActive(true);
                isCreated10 = true;
                isCreated11 = false;
            }   

            else if (!isCreated11)
            {
                if (PlayerPrefs.GetInt("soundStatus") != 1)
                {
                    soundManagerScript.PlaySound("blast");
                }
                ballObj11.SetActive(true);
                isCreated11 = true;
                Scene currentScene = SceneManager.GetActiveScene();

                string sceneName = currentScene.name;

                switch (sceneName)
                {
                    case "Scene8":
                        PlayerPrefs.SetInt("currentLevel", 9);
                        levelTextMesh.currentLevel = 9;
                        break;
                    case "Scene9":
                        PlayerPrefs.SetInt("currentLevel", 10);
                        levelTextMesh.currentLevel = 10;
                        break;
                    case "Scene14":
                        PlayerPrefs.SetInt("currentLevel", 15);
                        levelTextMesh.currentLevel = 15;
                        break;
                    case "Scene15":
                        PlayerPrefs.SetInt("currentLevel", 16);
                        levelTextMesh.currentLevel = 16;
                        break;
                    case "Scene16":
                        PlayerPrefs.SetInt("currentLevel", 17);
                        levelTextMesh.currentLevel = 17;
                        break;
                    case "Scene17":
                        PlayerPrefs.SetInt("currentLevel", 18);
                        levelTextMesh.currentLevel = 18;
                        break;
                    case "Scene18":
                        PlayerPrefs.SetInt("currentLevel", 19);
                        levelTextMesh.currentLevel = 19;
                        break;
                    case "Scene19":
                        PlayerPrefs.SetInt("currentLevel", 20);
                        levelTextMesh.currentLevel = 20;
                        break;
                    case "Scene20":
                        PlayerPrefs.SetInt("currentLevel", 8);
                        levelTextMesh.currentLevel = 8;
                        break;
                }

                StartCoroutine(levelUnlock());

            }

        }
    }

    IEnumerator levelUnlock()
    {
        yield return new WaitForSeconds(1);
        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;

        switch (sceneName)
        {
            case "Scene8":
                if (PlayerPrefs.GetInt("level8status") == 1)
                {
                    SceneManager.LoadScene("SuccessSceneLevel8");
                    levelTextMesh.currentLevel = 9;
                    PlayerPrefs.SetInt("level8status", 0);

                }
                break;
            case "Scene9":
                if (PlayerPrefs.GetInt("level9status") == 1)
                {
                    SceneManager.LoadScene("SuccessSceneLevel9");
                    levelTextMesh.currentLevel = 10;

                    PlayerPrefs.SetInt("level9status", 0);
                }
                break;

            case "Scene14":
                if (PlayerPrefs.GetInt("level14status") == 1)
                {
                    SceneManager.LoadScene("SuccessSceneLevel14");
                    levelTextMesh.currentLevel = 15;
                    PlayerPrefs.SetInt("level14status", 0);
                }
                break;
            case "Scene15":
                if (PlayerPrefs.GetInt("level15status") == 1)
                {
                    SceneManager.LoadScene("SuccessSceneLevel15");
                    levelTextMesh.currentLevel = 16;

                    PlayerPrefs.SetInt("level15status", 0);
                }
                break;
            case "Scene16":
                if (PlayerPrefs.GetInt("level16status") == 1)
                {
                    SceneManager.LoadScene("SuccessSceneLevel16");
                    levelTextMesh.currentLevel = 17;
                    PlayerPrefs.SetInt("level16status", 0);
                }
                break;
            case "Scene17":
                if (PlayerPrefs.GetInt("level17status") == 1)
                {
                    SceneManager.LoadScene("SuccessSceneLevel17");
                    levelTextMesh.currentLevel = 18;

                    PlayerPrefs.SetInt("level17status", 0);
                }
                break;
            case "Scene18":
                if (PlayerPrefs.GetInt("level18status") == 1)
                {
                    SceneManager.LoadScene("SuccessSceneLevel18");
                    levelTextMesh.currentLevel = 19;

                    PlayerPrefs.SetInt("level18status", 0);
                }
                break;
            case "Scene19":
                if (PlayerPrefs.GetInt("level19status") == 1)
                {
                    SceneManager.LoadScene("SuccessSceneLevel19");
                    levelTextMesh.currentLevel = 20;

                    PlayerPrefs.SetInt("level19status", 0);
                }
                break;
            case "Scene20":
                if (PlayerPrefs.GetInt("level20status") == 1)
                {
                    SceneManager.LoadScene("SuccessSceneLevel20");
                    levelTextMesh.currentLevel = 8;

                    PlayerPrefs.SetInt("level20status", 0);
                }
                break;
        }

    }
}
