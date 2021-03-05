using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gotoHomeScreen : MonoBehaviour
{

    private void OnMouseDown()
    {
        if (PlayerPrefs.GetInt("soundStatus") != 1)
        {
            soundManagerScript.PlaySound("click");
        }
        SceneManager.LoadScene("HomeScene");
    }
    private void Update()
    {
      
    }

}
