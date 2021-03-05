using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallSpawnerLevel2 : MonoBehaviour
{

    public GameObject ballObj;


    public GameObject ballObj2;
    public GameObject ballObj3;


    //public GameObject location;

    private bool isCreated;
    private bool isCreated2 = true;
    private bool isCreated3 = true;

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
                    PlayerPrefs.SetInt("currentLevel", 3);
                    levelTextMesh.currentLevel = 3;
                    StartCoroutine(levelUnlock());

            }

            }


          


    }

    IEnumerator levelUnlock()
    {
        yield return new WaitForSeconds(3);
        if (PlayerPrefs.GetInt("Level2Status") == 1)
        {
           
        SceneManager.LoadScene("SuccessSceneLevel2");
            
        }

    }
}
