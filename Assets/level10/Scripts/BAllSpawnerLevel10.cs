using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BAllSpawnerLevel10 : MonoBehaviour
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

                Scene currentScene = SceneManager.GetActiveScene();
                string sceneName = currentScene.name;

                switch (sceneName)
                {
                    case "Scene10":
                        if (PlayerPrefs.GetInt("level10status") == 1)
                        {
                            PlayerPrefs.SetInt("currentLevel", 11);
                        }
                        break;
                    case "Scene11":
                        if (PlayerPrefs.GetInt("level11status") == 1)
                        {
                            PlayerPrefs.SetInt("currentLevel", 12);
                        }
                        break;
                }
                StartCoroutine(levelUnlock());
            }
   
            

        }


    }

    IEnumerator levelUnlock()
    {
        yield return new WaitForSeconds(3);

     
            Scene currentScene = SceneManager.GetActiveScene();

            string sceneName = currentScene.name;

            switch (sceneName)
            {
                case "Scene10":
                    if (PlayerPrefs.GetInt("level10status") == 1)
                    {
                    SceneManager.LoadScene("SuccessSceneLevel10");
                    levelTextMesh.currentLevel = 11;
                    PlayerPrefs.SetInt("currentLevel",11);
                    PlayerPrefs.SetInt("level10status", 0);
                    }
                    break;
                case "Scene11":
                    if (PlayerPrefs.GetInt("level11status") == 1)
                    {
                        SceneManager.LoadScene("SuccessSceneLevel11");
                    PlayerPrefs.SetInt("currentLevel", 12);
                    levelTextMesh.currentLevel = 12;
                    PlayerPrefs.SetInt("level11status", 0);
                    }
                    break;
            }   
    }
}
