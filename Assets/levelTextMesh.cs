using UnityEngine;
using UnityEngine.UI;

public class levelTextMesh : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text;
    public static int currentLevel = 1;

    int currentLevel2;
    void Start()
    {
        text.text = currentLevel2.ToString();
        
    }

    void Update()
    {
        currentLevel2 = PlayerPrefs.GetInt("currentLevel",1);

        if (currentLevel2 > PlayerPrefs.GetInt("level"))
        {
            PlayerPrefs.SetInt("level", currentLevel2);
        }
        text.text = PlayerPrefs.GetInt("level",1).ToString();
    }
}
