     using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gotolevel3 : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("Scene3");
    }
}
