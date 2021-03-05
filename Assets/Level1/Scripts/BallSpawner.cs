using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallSpawner : MonoBehaviour
{

    public GameObject ballObj;


    public GameObject ballObj2;
    public GameObject ballObj3;
    public GameObject ballObj4;




    //public GameObject location;

    private bool isCreated;
    private bool isCreated2 = true;
    private bool isCreated3 = true;
    private bool isCreated4 = true;

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
                    ballObj.SetActive(true);
                    isCreated = true;
                    isCreated2 = false;

                }

                else if (!isCreated2)
                {
                    ballObj2.SetActive(true);
                    isCreated2 = true;
                    isCreated3 = false;
                }

                else if (!isCreated3)
                {
                    ballObj3.SetActive(true);
                    isCreated3 = true;
                    isCreated4 = false;
                }

                else if (!isCreated4)
                {
                    ballObj4.SetActive(true);
                    isCreated4 = true;
                    if (PlayerPrefs.GetInt("gameHasFinished") == 1)
                    {
                        StartCoroutine(levelUnlock());
                        unlockLevel2 = 1;
                    }

                }

            }
        

    }

    IEnumerator levelUnlock()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("SuccessSceneLevel3");

    }
}
