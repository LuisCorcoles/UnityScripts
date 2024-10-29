using UnityEngine;

public class Enemigo : Personaje
{
    public Transform jugador;
    public float velocidadEnemigo = 3f;

    void Update()
    {
        if (jugador != null)
        {
            Mover();
        }
    }

    public override void Mover()
    {
        transform.LookAt(jugador.position);
        transform.Translate(Vector3.forward * velocidadEnemigo * Time.deltaTime);
    }

    void OnCollisionEnter(Collision colision)
    {
        if (colision.gameObject.CompareTag("Jugador"))
        {
            HacerDaño(colision.gameObject.GetComponent<Jugador>());
        }
    }
}