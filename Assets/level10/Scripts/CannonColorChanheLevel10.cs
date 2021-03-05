using UnityEngine;

public class CannonColorChanheLevel10 : MonoBehaviour
{
    public SpriteRenderer cannonColorchange;
    public SpriteRenderer cannonColorchange2;


    public SpriteRenderer wheel;

    private bool isEntered;
    private bool turnedCyan = true;
    private bool turnedGreen = true;
    private bool turnedOffwhite = true;
    private bool turnedBlue = true;
    private bool turnedPurple = true;
    private bool turnedOrange = true;
    private bool turnedRed = true;
    //private bool turnedGray = true;

    void Start()
    {
        cannonColorchange.GetComponent<SpriteRenderer>();
        cannonColorchange2.GetComponent<SpriteRenderer>();

        wheel.GetComponent<SpriteRenderer>();
    }

    void Update()

    {
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isEntered)
        {
            //cyan
            cannonColorchange.color = new Color(88f / 255f, 155f / 225f, 200f / 223f);
            wheel.color = new Color(88f / 255f, 155f / 225f, 200f / 223f);
            isEntered = true;
            turnedCyan = false;

        }

        else if (!turnedCyan)
        {
            //green
            cannonColorchange2.color = new Color(26f / 255f, 107f / 225f, 65f / 223f);
            wheel.color = new Color(26f / 255f, 107f / 225f, 65f / 223f);
            turnedCyan = true;
            turnedGreen = false;
        }

        else if (!turnedGreen)
        {
            //offwhite
            cannonColorchange2.color = new Color(152f / 255f, 237f / 225f, 175f / 223f);
            wheel.color = new Color(152f / 255f, 237f / 225f, 175f / 223f);
            turnedGreen = true;
            turnedOffwhite = false;
        }

        else if (!turnedOffwhite)
        {
            //blue
            cannonColorchange2.color = new Color(8f / 255f, 56f / 225f, 96f / 223f);
            wheel.color = new Color(8f / 255f, 56f / 225f, 96f / 223f);
            turnedOffwhite = true;
            turnedBlue = false;
        }

        else if (!turnedBlue)
        {
            //purple
            cannonColorchange2.color = new Color(140f / 255f, 19f / 225f, 251f / 223f);
            wheel.color = new Color(140f / 255f, 19f / 225f, 251f / 223f);
            turnedBlue = true;
            turnedPurple = false;
        }

        else if (!turnedPurple)
        {
            //orange
            cannonColorchange2.color = new Color(255f / 255f, 129f / 225f, 40f / 223f);
            wheel.color = new Color(255f / 255f, 129f / 225f, 40f / 223f);
            turnedPurple = true;
            turnedOrange = false;
        }

        else if (!turnedOrange)
        {
            //red
            cannonColorchange2.color = new Color(244f / 255f, 0f / 225f, 0f / 223f);
            wheel.color = new Color(244f / 255f, 0f / 225f, 0f / 223f);
            turnedOrange = true;
            turnedRed = false;
        }
        
 

        else if (!turnedRed)
        {
            //gray
            cannonColorchange2.color = new Color(101f / 255f, 101f / 225f, 101f / 223f);
            wheel.color = new Color(101f / 255f, 101f / 225f, 101f / 223f);
            turnedPurple = true;
        }

    }
}
