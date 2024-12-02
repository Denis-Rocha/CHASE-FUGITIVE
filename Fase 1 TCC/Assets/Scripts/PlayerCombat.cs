using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    [Header("Configura��es de Combate")]
    public int damage; // Dano causado pelo ataque
    private bool enemyInRange = false; // Verifica se o inimigo est� na �rea
    private GameObject currentEnemy; // Refer�ncia ao inimigo na �rea



    public void Atacar()
    {
        if (enemyInRange)
        {
            currentEnemy.GetComponent<Inimigo>().VidaInimigo -= damage;

        }

    }


    void OnCollisionStay(Collision collision)
    {
        // Verifica se o objeto que entrou na �rea tem a tag "Inimigo"
        if (collision.gameObject.CompareTag("inimigo"))
        {
            enemyInRange = true;
            currentEnemy = collision.gameObject; // Armazena o inimigo atual
            Debug.Log("Inimigo detectado no alcance.");
        }
    }

    void OnCollisionExit(Collision collision)
    {
        // Verifica se o objeto que saiu da �rea tem a tag "Inimigo"
        if (collision.gameObject.CompareTag("inimigo"))
        {
            enemyInRange = false;
            currentEnemy = null; // Remove o inimigo atual
            Debug.Log("Inimigo saiu do alcance.");
        }
    }
}