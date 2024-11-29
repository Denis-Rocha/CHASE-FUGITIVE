using UnityEngine;

public class InimigoMovimentoECombate : MonoBehaviour
{
    [Header("Configurações de Movimento")]
    public Transform target; // Ponto para o inimigo se mover
    public float speed = 5f; // Velocidade de movimento
    public GameObject[] objectsToReveal; // Objetos revelados ao chegar
    public Animator animator; // Controlador de animações

    [Header("Configurações de Combate")]
    public int dano = 10; // Dano causado ao jogador
    public float intervaloEntreAtaques = 2f; // Intervalo entre ataques
    public GameObject player; // Referência ao jogador
    private bool jogadorNoAlcance = false; // Verifica se o jogador está na área de combate
    private float proximoAtaque = 0f; // Controle do tempo do próximo ataque
    private bool hasReachedDestination = false; // Se chegou ao destino

    private void Start()
    {
        // Configurações iniciais
        if (animator != null)
        {
            animator.SetBool("correndo", true);
        }

        foreach (var obj in objectsToReveal)
        {
            obj.SetActive(false);
        }
    }

    private void Update()
    {
        if (!hasReachedDestination && target != null)
        {
            // Movimento até o destino
            MoverParaDestino();
        }
        else if (hasReachedDestination)
        {
            // Modo de combate
            CombateComJogador();
        }
    }

   

    private void MoverParaDestino()

    {
        Vector3 direction = (target.position - transform.position).normalized;
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        // Verifica se chegou ao destino
        if (Vector3.Distance(transform.position, target.position) < 0.1f)
        {
            hasReachedDestination = true;

            if (animator != null)
            {
                animator.SetBool("correndo", false);
            }

            foreach (var obj in objectsToReveal)
            {
                obj.SetActive(true); // Revela os objetos
            }

            transform.Rotate(0, 180f, 0); // Rotaciona o inimigo
        }
    }

    private void CombateComJogador()
    {
        if (jogadorNoAlcance)
        {
            animator.SetBool("ataque", true);

            if (Time.time >= proximoAtaque)
            {
                AtacarJogador();
                proximoAtaque = Time.time + intervaloEntreAtaques; // Define o próximo ataque
            }
        }
        else
        {
            animator.SetBool("ataque", false);
        }
    }

    private void AtacarJogador()
    {
        if (player != null)
        {
            var vidaDoJogador = player.GetComponent<PlayerHealth>();
            if (vidaDoJogador != null)
            {
                vidaDoJogador.TomarDano(dano);
                Debug.Log("O inimigo causou " + dano + " de dano ao jogador!");
            }
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        // Verifica se o jogador está no alcance
        if (collision.gameObject.CompareTag("Player"))
        {
            jogadorNoAlcance = true;
            Debug.Log("Jogador está no alcance do inimigo.");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        // Verifica se o jogador saiu do alcance
        if (collision.gameObject.CompareTag("Player"))
        {
            jogadorNoAlcance = false;
            Debug.Log("Jogador saiu do alcance do inimigo.");
        }
    }
}
