using UnityEngine;

public class soundController : MonoBehaviour
{
    public GameObject cross;
    bool isOn = false;

     private void OnMouseDown()
    {
        if (!isOn)
        {
            cross.SetActive(true);
            //1 means stop sound
            PlayerPrefs.SetInt("soundStatus", 1);
            soundManagerScript.PlaySound("blast");
            isOn = true;
        }
        else if (isOn)
        {
            cross.SetActive(false);
            //0 means play sound
            //cross.SetActive(false);
            PlayerPrefs.SetInt("soundStatus", 0);
            isOn = false;
        }

        //if (PlayerPrefs.GetInt("soundStatus") == 1)
        //{
        //    cross.SetActive(true);
        //}
    }

    private void Update()
    {

        if (!isOn)
        {
            print("I'm !isOn");
        }
        else if(isOn)
        {
            print("I'm isOn");
        }
    }
}
