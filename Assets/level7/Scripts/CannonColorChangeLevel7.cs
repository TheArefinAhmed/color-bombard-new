using UnityEngine;

public class CannonColorChangeLevel7 : MonoBehaviour
{
    public SpriteRenderer cannonColorchange;
    public SpriteRenderer cannonColorchange2;


    public SpriteRenderer wheel;

    private bool isEntered;
    private bool turnedCyan = true;
    private bool turnedBrown = true;
    private bool turnedOrange = true;
    private bool turnedYellow = true;
    private bool turnedChocolate = true;
    private bool turnedAsh = true;
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
            cannonColorchange.color = new Color(50f / 255f, 219f / 225f, 240f / 223f);
            wheel.color = new Color(50f / 255f, 219f / 225f, 240f / 223f);
            isEntered = true;
            turnedCyan = false;

        }

        else if (!turnedCyan)
        {
            //brown
            cannonColorchange2.color = new Color(195f / 255f, 126f / 225f, 76f / 223f);
            wheel.color = new Color(195f / 255f, 126f / 225f, 76f / 223f);
            turnedCyan = true;
            turnedBrown = false;
        }

        else if (!turnedBrown)
        {
            //orange
            cannonColorchange2.color = new Color(255f / 255f, 94f / 225f, 19f / 223f);
            wheel.color = new Color(255f / 255f, 94f / 225f, 19f / 223f);
            turnedBrown = true;
            turnedOrange = false;
        }

        else if (!turnedOrange)
        {
            //yellow
            cannonColorchange2.color = new Color(244f / 255f, 232f / 225f, 0f / 223f);
            wheel.color = new Color(244f / 255f, 232f / 225f, 0f / 223f);
            turnedOrange = true;
            turnedYellow = false;
        }

        else if (!turnedYellow)
        {
            //chocolate
            cannonColorchange2.color = new Color(89f / 255f, 60f / 225f, 31f / 223f);
            wheel.color = new Color(89f / 255f, 60f / 225f, 31f / 223f);
            turnedYellow = true;
            turnedChocolate = false;
        }
        else if (!turnedChocolate)
        {
            //ash
            cannonColorchange2.color = new Color(153f / 255f, 153f / 225f, 153f / 223f);
            wheel.color = new Color(153f / 255f, 153f / 225f, 153f / 223f);
            turnedAsh = true;
        }

        //if (isEntered2)
        //{
        //    cannonColorchange.color = new Color(0f / 255f, 128f / 225f, 0f / 223f);
        //    isEntered2 = false;
        //}

    }
}
