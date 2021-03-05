using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ballspawnerlevel5 : MonoBehaviour
{

    public GameObject ballObj;

    public GameObject ballObj2;
    public GameObject ballObj3;
    public GameObject ballObj4;
    public GameObject ballObj5;
    public GameObject ballObj6;

    //public GameObject location;

    private bool isCreated;
    private bool isCreated2 = true;
    private bool isCreated3 = true;
    private bool isCreated4 = true;
    private bool isCreated5 = true;
    private bool isCreated6 = true;

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

                Scene currentScene = SceneManager.GetActiveScene();

                string sceneName = currentScene.name;

                switch (sceneName)
                {
                    case "Scene5":
                        PlayerPrefs.SetInt("currentLevel", 6);
                        break;
                    case "Scene6":
                        PlayerPrefs.SetInt("currentLevel", 7);
                        break;
                }

                StartCoroutine(levelUnlock());

                

            }

        }


    }

    IEnumerator levelUnlock()
    {
        yield return new WaitForSeconds(3);
        if (PlayerPrefs.GetInt("level5status") == 1)
        {


            Scene currentScene = SceneManager.GetActiveScene();

            string sceneName = currentScene.name;

            switch (sceneName)
            {
                case "Scene5":
                    SceneManager.LoadScene("SuccessSceneLevel5");
                    PlayerPrefs.SetInt("currentLevel", 6);
                    levelTextMesh.currentLevel = 6;
                    break;
                case "Scene6":
                    SceneManager.LoadScene("SuccessSceneLevel6");
                    PlayerPrefs.SetInt("currentLevel", 7);
                    levelTextMesh.currentLevel = 7;
                    break;
            }
            PlayerPrefs.SetInt("level5status", 0);

        
        }
    
        

    }
}
