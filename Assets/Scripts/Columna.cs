using UnityEngine;


public class Columna : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Vector3 posInicial;
    Vector3 posFinal;
    public bool downUp = true;
    float alturaMax = 5;

    public float velocidadY;

    public Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        posInicial = transform.position;
        posFinal = transform.position + new Vector3(0, alturaMax, 0);
        newVelocity();
    }
    public void newVelocity()
    {
        velocidadY = Random.Range(1f, 10f);

    }
    // Update is called once per frame
    void Update()
    {
       
        if (downUp)
        {

            if (transform.position.y < posFinal.y)
            {
                //transform.Translate(transform.up * velocidadY * Time.deltaTime);
                rb.linearVelocity = new Vector2(0, velocidadY);
            }
            else
            {
                downUp = !downUp;
            }


        }
        else
        {
            if (transform.position.y > posInicial.y)
            {
                //transform.Translate(-transform.up * velocidadY * Time.deltaTime);
                rb.linearVelocity = new Vector2(0, -velocidadY);

            }
            else
            {
                downUp = !downUp;
            }

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.gameObject.CompareTag("Player"))
        //{
        //    Destroy(gameObject);

        //}
    }


}
