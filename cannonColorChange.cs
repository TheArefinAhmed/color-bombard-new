using UnityEngine;

public class cannonColorChange : MonoBehaviour
{
    public SpriteRenderer cannonColorChanger;
    void Start()
    {
        cannonColorChanger.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
       
        int number;

        number = PlayerPrefs.GetInt("currentNumber");

        int num = 0;

        switch (number)
        {

            case 1: //magenta
                cannonColorChanger.color = new Color(255f / 255f, 0f / 255f, 128f / 255f);
                PlayerPrefs.SetInt("currentNumberfromCannon",1);
                num = num + 1;
                break;

            case 2: //purple
                cannonColorChanger.color = new Color(140f / 255f, 19f / 255f, 251f / 255f);
                PlayerPrefs.SetInt("currentNumberfromCannon",2);
                num = num + 2;
                break;

            case 3: //yellow
                cannonColorChanger.color = new Color(246f / 255f, 223f / 225f, 14f / 223f);
                PlayerPrefs.SetInt("currentNumberfromCannon",3);
                num = num + 3;
                break;
        }

        print("num = "+num);
    }
}
