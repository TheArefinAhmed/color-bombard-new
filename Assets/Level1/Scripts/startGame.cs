using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnMouseDown()
    {
        int levelToStart;

        if (PlayerPrefs.GetInt("soundStatus") != 1)
        {   
        soundManagerScript.PlaySound("blast");
        }

            switch (PlayerPrefs.GetInt("level"))
            {
                case 1:
                    SceneManager.LoadScene("Scene1");
                    break;
                case 2:
                    SceneManager.LoadScene("Scene2");
                    break;
                case 3:
                    SceneManager.LoadScene("Scene3");
                    break;
                case 4:
                    SceneManager.LoadScene("Scene4");
                    break;
                case 5:
                    SceneManager.LoadScene("Scene5");
                    break;
                case 6:
                    SceneManager.LoadScene("Scene6");
                    break;
                case 7:
                    SceneManager.LoadScene("Scene7");
                    break;
                case 8:
                    SceneManager.LoadScene("Scene8");
                    break;
                case 9:
                    SceneManager.LoadScene("Scene9");
                    break;
                case 10:
                    SceneManager.LoadScene("Scene10");
                    break;
                case 11:
                    SceneManager.LoadScene("Scene11");
                    break;
                case 12:
                    SceneManager.LoadScene("Scene12");
                    break;
                case 13:
                    SceneManager.LoadScene("Scene13");
                    break;
                case 14:
                    SceneManager.LoadScene("Scene14");
                    break;
                case 15:
                    SceneManager.LoadScene("Scene15");
                    break;
                case 16:
                    SceneManager.LoadScene("Scene16");
                    break;
                case 17:
                    SceneManager.LoadScene("Scene17");
                    break;
                case 18:
                    SceneManager.LoadScene("Scene18");
                    break;
                case 19:
                    SceneManager.LoadScene("Scene19");
                    break;
                case 20:
                    SceneManager.LoadScene("Scene20");
                    break;

            }

       
    }
}
