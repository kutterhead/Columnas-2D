using UnityEngine;
using UnityEngine.UIElements;

public class Columna : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Vector3 posInicial;
    Vector3 posFinal;
    public bool downUp = true;
    float alturaMax = 5;

    public float velocidadY;


    void Start()
    {
        posInicial = transform.position;
        posFinal = transform.position + new Vector3(0, alturaMax, 0);
        velocidadY = Random.Range(1f,10f);
    }

    // Update is called once per frame
    void Update()
    {
        if (downUp)
        {

            if (transform.position.y < posFinal.y)
            {
                transform.Translate(transform.up * velocidadY * Time.deltaTime);

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
                transform.Translate(-transform.up * velocidadY * Time.deltaTime);

            }
            else
            {
                downUp = !downUp;
            }

        }
    }
}
