using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    [Header("Configurações de Combate")]
    public int damage; // Dano causado pelo ataque
    private bool enemyInRange = false; // Verifica se o inimigo está na área
    private GameObject currentEnemy; // Referência ao inimigo na área



    public void Atacar()
    {
        if (enemyInRange)
        {
            currentEnemy.GetComponent<Inimigo>().VidaInimigo -= damage;

        }

    }


    void OnCollisionStay(Collision collision)
    {
        // Verifica se o objeto que entrou na área tem a tag "Inimigo"
        if (collision.gameObject.CompareTag("inimigo"))
        {
            enemyInRange = true;
            currentEnemy = collision.gameObject; // Armazena o inimigo atual
            Debug.Log("Inimigo detectado no alcance.");
        }
    }

    void OnCollisionExit(Collision collision)
    {
        // Verifica se o objeto que saiu da área tem a tag "Inimigo"
        if (collision.gameObject.CompareTag("inimigo"))
        {
            enemyInRange = false;
            currentEnemy = null; // Remove o inimigo atual
            Debug.Log("Inimigo saiu do alcance.");
        }
    }
}