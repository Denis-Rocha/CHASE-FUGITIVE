using UnityEngine;

public class MoveAndRevealObjects : MonoBehaviour
{
    public Transform target; // Ponto para o inimigo se mover
    public float speed = 5f; // Velocidade de movimento
    public GameObject[] objectsToReveal; // Objetos revelados ao chegar
    public Animator animator; // Controlador de animações
    public int dano = 10; // Dano causado ao jogador
    public float tempoEntreAtaques = 1.5f; // Intervalo entre ataques
    public float raioDeAtaque = 2f; // Raio de ataque do inimigo
    public LayerMask layerJogador; // Layer para identificar o jogador

    private bool hasReachedDestination = false; // Se chegou ao destino
    private float proximoAtaque; // Controle do tempo de ataque

    private void Start()
    {
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
            Vector3 direction = (target.position - transform.position).normalized;
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

            // Verifica se chegou ao destino
            if (Vector3.Distance(transform.position, target.position) < 0.1f)
            {
                hasReachedDestination = true;

                if (animator != null)
                {
                    animator.SetBool("correndo", false);
                    animator.SetBool("briga", true); // Ativa a animação de luta
                }

                foreach (var obj in objectsToReveal)
                {
                    obj.SetActive(true);
                }

                transform.Rotate(0, 180f, 0);
            }
        }

        // Lógica de combate
        if (hasReachedDestination)
        {
            DetectarEAtacarJogador();
        }
    }

    private void DetectarEAtacarJogador()
    {
        // Detectar jogadores dentro do raio de ataque
        Collider[] jogadores = Physics.OverlapSphere(transform.position, raioDeAtaque, layerJogador);

        foreach (var jogador in jogadores)
        {
            var vidaJogador = jogador.GetComponent<VidaJogador>();

            if (vidaJogador != null && Time.time >= proximoAtaque)
            {
                if (animator != null)
                {
                    animator.SetBool("lutando", true); // Ativa a animação de luta
                }

                vidaJogador.TomarDano(dano); // Causa dano ao jogador
                proximoAtaque = Time.time + tempoEntreAtaques; // Define o tempo do próximo ataque
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        // Desenhar o raio de ataque no editor
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, raioDeAtaque);
    }
}
