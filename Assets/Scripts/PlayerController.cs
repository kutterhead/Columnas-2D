using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float velocidad;
    Vector3 posInicial; 
    [SerializeField]int vidas = 3;

    public GameObject[] columnas;
    [SerializeField] Columna[] columnasScript;
    void Start()
    {
       columnas = GameObject.FindGameObjectsWithTag("Columna");
        System.Array.Resize(ref columnasScript, columnas.Length);
        for (int i = 0; i < columnas.Length; i++)
        {
            columnasScript[i] = columnas[i].GetComponent<Columna>();

        }

        posInicial = transform.position;
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
    //private void OnTriggerEnter(Collider other)
    //{
    //    Debug.Log("Colision con: " + other.gameObject.tag);
    //    if (other.gameObject.CompareTag("Columna"))
    //    {
    //        Destroy(other.gameObject);
    //    }
    //}
    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("Colision con: " + collision.gameObject.tag);
    //}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Columna"))
        {
            vidas--;
            if (vidas<0)
            {
                vidas = 0;
                Debug.Log("Game Over");
            }
            resetPosition();
          
        }
        if (collision.gameObject.CompareTag("target"))
        {
            vidas++;
            if (vidas > 3)
            {
                vidas = 3;
                Debug.Log("Enhorabuena");
            }
            resetPosition();
            for (int i = 0; i < columnas.Length; i++)
            {
                columnasScript[i].newVelocity();

            }
        }
    }

    public void resetPosition()
    {
        transform.position = posInicial;

    }


}
