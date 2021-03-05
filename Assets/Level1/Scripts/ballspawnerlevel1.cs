using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ballspawnerlevel1 : MonoBehaviour
{

    public GameObject ballObj;


    public GameObject ballObj2;
    public GameObject ballObj3;

    private bool isCreated;
    private bool isCreated2 = true;
    private bool isCreated3 = true;

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
                PlayerPrefs.SetInt("currentLevel",2);
                levelTextMesh.currentLevel = 2;
                StartCoroutine(levelUnlock());
            }
        }


    }

    IEnumerator levelUnlock()
    {
        yield return new WaitForSeconds(3);
        if (PlayerPrefs.GetInt("level1status")==1)
        {
            SceneManager.LoadScene("SuccessSceneLevel1");
            
        }
        

    }
}
