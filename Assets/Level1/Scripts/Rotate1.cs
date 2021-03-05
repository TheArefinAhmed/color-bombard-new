using UnityEngine;

public class Rotate1 : MonoBehaviour
{

    public float speed = 150f;
 
    void Update()
    {

        transform.Rotate(Vector3.back, speed * Time.deltaTime);  
    }
}
