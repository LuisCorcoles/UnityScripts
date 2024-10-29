using UnityEngine;

public class Personaje : MonoBehaviour
{
    public int vida = 100;
    public int daño = 10;

    public virtual void Mover() { }

    public void HacerDaño(Personaje objetivo)
    {
        objetivo.RecibirDaño(daño);
    }

    public void RecibirDaño(int cantidad)
    {
        vida -= cantidad;
        if (vida <= 0)
        {
            Debug.Log(gameObject.name + " ha sido derrotado.");
        }
    }
}