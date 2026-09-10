using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float velocidad;
 
    void Start()
    {
 
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(transform.right*velocidad*Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.A))
        {

            transform.Translate(-transform.right * velocidad * Time.deltaTime);

        }
    }
}
