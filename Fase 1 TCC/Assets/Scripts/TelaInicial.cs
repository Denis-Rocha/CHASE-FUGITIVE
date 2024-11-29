using UnityEngine;
using UnityEngine.UI;

public class TelaInicial : MonoBehaviour
{
    public GameObject telaInicial; // Refer�ncia ao GameObject da tela inicial
    public GameObject jogo; // Refer�ncia ao GameObject principal do jogo

    private bool jogoIniciado = false; // Controle para verificar se o jogo j� come�ou

    void Start()
    {
        // Certifique-se de que a tela inicial est� ativa e o jogo desativado
        telaInicial.SetActive(true);
        jogo.SetActive(false);
    }

    void Update()
    {
        // Verifica se o jogador pressionou Enter
        if (!jogoIniciado && Input.GetKeyDown(KeyCode.Return)) // Return � o Enter
        {
            IniciarJogo();
        }
    }

    void IniciarJogo()
    {
        jogoIniciado = true;
        telaInicial.SetActive(false); // Esconde a tela inicial
        jogo.SetActive(true); // Ativa o jogo
    }
}
