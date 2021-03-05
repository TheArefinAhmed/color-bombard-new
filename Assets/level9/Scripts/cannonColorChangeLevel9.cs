using UnityEngine;

public class cannonColorChangeLevel9 : MonoBehaviour
{
    public SpriteRenderer cannonColorchange;
    public SpriteRenderer cannonColorchange2;


    public SpriteRenderer wheel;

    private bool isEntered;
    private bool turnedCyan = true;
    private bool turnedYellow = true;
    private bool turnedOrange = true;
    private bool turnedBrown = true;
    private bool turnedPurple= true;

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
            //yellow
            cannonColorchange2.color = new Color(206f / 255f, 255f / 225f, 0f / 223f);
            wheel.color = new Color(206f / 255f, 255f / 225f, 0f / 223f);
            turnedCyan = true;
            turnedYellow = false;
        }

        else if (!turnedYellow)
        {
            //orange
            cannonColorchange2.color = new Color(255f / 255f, 129f / 225f, 40f / 223f);
            wheel.color = new Color(255f / 255f, 129f / 225f, 40f / 223f);
            turnedYellow = true;
            turnedOrange = false;
        }

        else if (!turnedOrange)
        {
            //brown
            cannonColorchange2.color = new Color(130f / 255f, 70f / 225f, 29f / 223f);
            wheel.color = new Color(130f / 255f, 70f / 225f, 29f / 223f);
            turnedOrange = true;
            turnedBrown = false;
        }

        else if (!turnedBrown)
        {
            //purple
            cannonColorchange2.color = new Color(140f / 255f, 19f / 225f, 251f / 223f);
            wheel.color = new Color(140f / 255f, 19f / 225f, 251f / 223f);
            turnedBrown = true;
            turnedPurple = false;
        }

        else if (!turnedPurple)
        {
            //offwhite
            cannonColorchange2.color = new Color(234f / 255f, 170f / 225f, 170f / 223f);
            wheel.color = new Color(234f / 255f, 170f / 225f, 170f / 223f);
            turnedPurple = true;
        }

    }
}
