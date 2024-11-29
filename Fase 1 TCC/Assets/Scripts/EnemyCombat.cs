
using UnityEngine;

public class EnemyCombat : MonoBehaviour
{
    [Header("Configura��es de Combate")]
    public int damage = 10; // Dano causado pelo inimigo
    public float attackInterval = 2f; // Intervalo entre ataques
    private bool playerInRange = false; // Verifica se o jogador est� na �rea
    public GameObject player; // Refer�ncia ao jogador
    private Animator animator;


    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (playerInRange)
        {
            animator.SetBool("ataque", true);
        }
        else
        {
            animator.SetBool("ataque", false);
        }
        }

    public void AtacarJogador()
    {
        if (playerInRange)
        {
            player.GetComponent<PlayerHealth>().TomarDano(damage);
            Debug.Log("O inimigo causou " + damage + " de dano ao jogador!");
      
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        // Verifica se o objeto na �rea de colis�o tem a tag "Player"
        if (collision.gameObject.CompareTag("Player"))
        {
            playerInRange = true;
    
            Debug.Log("Jogador est� no alcance do inimigo.");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        // Verifica se o jogador saiu da �rea de colis�o
        if (collision.gameObject.CompareTag("Player"))
        {
            playerInRange = false;
            Debug.Log("Jogador saiu do alcance do inimigo.");
        }
    }
}
