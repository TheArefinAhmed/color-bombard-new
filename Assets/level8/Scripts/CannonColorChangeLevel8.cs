using UnityEngine;

public class CannonColorChangeLevel8 : MonoBehaviour
{
    public SpriteRenderer cannonColorchange;
    public SpriteRenderer cannonColorchange2;


    public SpriteRenderer wheel;

    private bool isEntered;
    private bool turnedCyan = true;
    private bool turnedGreen = true;
    private bool turnedPurple = true;
    private bool turnedOffwhite = true;
    private bool turnedAsh = true;
    private bool turnedGray = true;
    private bool turnedOrange = true;
    private bool turnedBlue = true;
    private bool turnedRed = true;
    private bool turnedBrown = true;
    void Start()
    {
        cannonColorchange.GetComponent<SpriteRenderer>();
        cannonColorchange2.GetComponent<SpriteRenderer>();

        wheel.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
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
            //Green
            cannonColorchange2.color = new Color(26f / 255f, 107f / 225f, 65f / 223f);
            wheel.color = new Color(26f / 255f, 107f / 225f, 65f / 223f);
            turnedCyan = true;
            turnedGreen = false;
        }

        else if (!turnedGreen)
        {
            //purple
            cannonColorchange2.color = new Color(107 / 255f, 0f / 225f, 161f / 223f);
            wheel.color = new Color(107 / 255f, 0f / 225f, 161f / 223f);
            turnedGreen = true;
            turnedPurple = false;
        }

        else if (!turnedPurple)
        {
            //offwhite
            cannonColorchange2.color = new Color(152f / 255f, 237f / 225f, 175f / 223f);
            wheel.color = new Color(152f / 255f, 237f / 225f, 175f / 223f);
            turnedPurple = true;
            turnedOffwhite = false;
        }

        else if (!turnedOffwhite)
        {
            //gray
            cannonColorchange2.color = new Color(101f / 255f, 101f / 225f, 101f / 223f);
            wheel.color = new Color(101f / 255f, 101f / 225f, 101f / 223f);
            turnedOffwhite = true;
            turnedGray = false;
        }

        else if (!turnedGray)
        {
            //ash
            cannonColorchange2.color = new Color(212f / 255f, 212f / 225f, 212f / 223f);
            wheel.color = new Color(212f / 255f, 212f / 225f, 212f / 223f);
            turnedGray = true;
            turnedAsh = false;
        }

        else if (!turnedAsh)
        {
            //orange
            cannonColorchange2.color = new Color(255f / 255f, 129f / 225f, 40f / 223f);
            wheel.color = new Color(255f / 255f, 129f / 225f, 40f / 223f);
            turnedAsh = true;
            turnedOrange = false;
        }

        else if (!turnedOrange)
        {
            //blue
            cannonColorchange2.color = new Color(8f / 255f, 56f / 225f, 96f / 223f);
            wheel.color = new Color(8f / 255f, 56f / 225f, 96f / 223f);
            turnedOrange = true;
            turnedBlue = false;
        }

        else if (!turnedBlue)
        {
            //red
            cannonColorchange2.color = new Color(244f / 255f, 0f / 225f, 0f / 223f);
            wheel.color = new Color(244f / 255f, 0f / 225f, 0f / 223f);
            turnedBlue = true;
            turnedBrown = false;
        }
        else if (!turnedBrown)
        {
            //brown
            cannonColorchange2.color = new Color(170f / 255f, 113f / 225f, 77f / 223f);
            wheel.color = new Color(170f / 255f, 113f / 225f, 77f / 223f);
            turnedAsh = true;
        }
    }
}
