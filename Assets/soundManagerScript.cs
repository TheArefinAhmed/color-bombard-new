using UnityEngine;

public class soundManagerScript : MonoBehaviour
{
    public static AudioClip blast, gameOver, shoot,click;
    static AudioSource audioSource;

    void Start()
    {
        blast = Resources.Load<AudioClip>("blast");
        gameOver = Resources.Load<AudioClip>("GameOver");
        shoot = Resources.Load<AudioClip>("shoot");
        click = Resources.Load<AudioClip>("click");

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "blast":
                audioSource.PlayOneShot(blast);
                break;
            case "GameOver":
                audioSource.PlayOneShot(gameOver);
                break;
            case "shoot":
                audioSource.PlayOneShot(shoot);
                break;
            case "click":
                audioSource.PlayOneShot(click);
                break;
        }
    }
}
