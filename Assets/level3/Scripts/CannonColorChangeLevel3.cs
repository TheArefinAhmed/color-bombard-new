using UnityEngine;

public class CannonColorChangeLevel3 : MonoBehaviour
{
    public SpriteRenderer cannonColorchange;
    public SpriteRenderer cannonColorchange2;
    public SpriteRenderer cannonColorchange3;

    public SpriteRenderer wheel;

    private bool isEntered;
    private bool turnedCyan = true;
    private bool turnedGreen = true;
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
        //turnedCyan = true;

        //if(turnedCyan = false)
        //{
            
        //}
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
            //green
            cannonColorchange2.color = new Color(49f / 255f, 160f / 225f, 48f / 223f);
            wheel.color = new Color(49f / 255f, 160f / 225f, 48f / 223f);
            turnedCyan = true;
            turnedGreen = false;
        }

        else if (!turnedGreen)
        {
            //orange
            cannonColorchange2.color = new Color(255f / 255f, 94f / 225f, 19f / 223f);
            wheel.color = new Color(255f / 255f, 94f / 225f, 19f / 223f);
            turnedGreen = true;
        }

        //if (isEntered2)
        //{
        //    cannonColorchange.color = new Color(0f / 255f, 128f / 225f, 0f / 223f);
        //    isEntered2 = false;
        //}

    }
}
