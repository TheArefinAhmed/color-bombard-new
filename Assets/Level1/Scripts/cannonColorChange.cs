 using UnityEngine;

public class cannonColorChange : MonoBehaviour
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
            cannonColorchange.color = new Color(50f / 255f, 219f / 225f, 240f / 223f);
            wheel.color = new Color(50f / 255f, 219f / 225f, 240f / 223f);
            isEntered = true;

        }

        if (turnedYellow == true)
        {
            cannonColorchange2.color = new Color(140f / 255f, 19f / 225f, 251f / 223f);
            wheel.color = new Color(140f / 255f, 19f / 225f, 251f / 223f);
            turnedYellow = false;
        }
    }
}
