using UnityEngine;
using UnityEngine.SceneManagement;

public class gotoNextLevel : MonoBehaviour
{

    private void OnMouseDown()
    {
        if (PlayerPrefs.GetInt("soundStatus") != 1)
        {
            soundManagerScript.PlaySound("click");
        }
        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;

        switch (sceneName)
        {
            case "SuccessSceneLevel1":
                SceneManager.LoadScene("Scene2");
                break;
            case "SuccessSceneLevel2":
                SceneManager.LoadScene("Scene3");
                break;
            case "SuccessSceneLevel3":
                SceneManager.LoadScene("Scene4");
                break;
            case "SuccessSceneLevel4":
                SceneManager.LoadScene("Scene5");
                break;
            case "SuccessSceneLevel5":
                SceneManager.LoadScene("Scene6");
                break;
            case "SuccessSceneLevel6":
                SceneManager.LoadScene("Scene7");
                break;
            case "SuccessSceneLevel7":
                SceneManager.LoadScene("Scene8");
                break;
            case "SuccessSceneLevel8":
                SceneManager.LoadScene("Scene9");
                break;
            case "SuccessSceneLevel9":
                SceneManager.LoadScene("Scene10");
                break;
            case "SuccessSceneLevel10":
                SceneManager.LoadScene("Scene11");
                break;
            case "SuccessSceneLevel11":
                SceneManager.LoadScene("Scene12");
                break;
            case "SuccessSceneLevel12":
                SceneManager.LoadScene("Scene13");
                break;
            case "SuccessSceneLevel13":
                SceneManager.LoadScene("Scene14");
                break;
            case "SuccessSceneLevel14":
                SceneManager.LoadScene("Scene15");
                break;
            case "SuccessSceneLevel15":
                SceneManager.LoadScene("Scene16");
                break;
            case "SuccessSceneLevel16":
                SceneManager.LoadScene("Scene17");
                break;
            case "SuccessSceneLevel17":
                SceneManager.LoadScene("Scene18");
                break;
            case "SuccessSceneLevel18":
                SceneManager.LoadScene("Scene19");
                break;
            case "SuccessSceneLevel19":
                SceneManager.LoadScene("Scene20");
                break;
            case "SuccessSceneLevel20":
                SceneManager.LoadScene("Scene8");
                break;
        }

    }

    private void Start()
    {
        
    }
    void Update()
    {
          
    }
}
