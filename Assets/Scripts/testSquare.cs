using UnityEngine;

public class testSquare : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
     
    
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = new Vector2(0, -5);
    }
}
