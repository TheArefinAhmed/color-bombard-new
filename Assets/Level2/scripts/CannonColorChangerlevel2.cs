using UnityEngine;

public class CannonColorChangerlevel2 : MonoBehaviour
{
    public SpriteRenderer cannonColorchange;
    public SpriteRenderer cannonColorchange2;
    public SpriteRenderer wheel;
    private bool isEntered;
    private bool turnedYellow;
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
        turnedYellow = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isEntered)
        {
            cannonColorchange.color = new Color(246f / 255f, 223f / 225f, 14f / 223f);
            wheel.color = new Color(246f / 255f, 223f / 225f, 14f / 223f);
            isEntered = true;

        }

        if (turnedYellow == true)
        {
            cannonColorchange2.color = new Color(140f / 255f, 19f / 225f, 251f / 223f);
            wheel.color = new Color(140f / 255f, 19f / 225f, 251f / 223f);
            turnedYellow = false;
        }

        //if (isEntered2)
        //{
        //    cannonColorchange.color = new Color(0f / 255f, 128f / 225f, 0f / 223f);
        //    isEntered2 = false;
        //}

    }
}
