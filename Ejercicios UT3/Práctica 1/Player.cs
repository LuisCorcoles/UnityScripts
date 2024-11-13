using UnityEngine;

public class Jugador : Personaje
{
    public float velocidad = 5f;
    public int puntos = 0;
    public float animacion = 7f;

    void Update()
    {
        Mover();
    }

    public override void Mover()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(horizontal, 0, vertical) * velocidad * Time.deltaTime;
        transform.Translate(movimiento);
    }

    void OnTriggerEnter(Collider otro)
    {
        if (otro.gameObject.CompareTag("Recolectable"))
        {
            puntos++;
            Destroy(otro.gameObject);
            Debug.Log("Puntos: " + puntos);
        }
    }

    void OnCollisionEnter(Collision colision)
    {
        if (colision.gameObject.CompareTag("Enemigo"))
        {
            HacerDaño(colision.gameObject.GetComponent<Enemigo>());
        }
    }

    void nextObject (int obj){

        Debug.LOg("Hola")
    }


}