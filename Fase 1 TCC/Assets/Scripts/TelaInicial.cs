using UnityEngine;
using UnityEngine.UI;

public class TelaInicial : MonoBehaviour
{
    public GameObject telaInicial; // Referência ao GameObject da tela inicial
    public GameObject jogo; // Referência ao GameObject principal do jogo

    private bool jogoIniciado = false; // Controle para verificar se o jogo já começou

    void Start()
    {
        // Certifique-se de que a tela inicial está ativa e o jogo desativado
        telaInicial.SetActive(true);
        jogo.SetActive(false);
    }

    void Update()
    {
        // Verifica se o jogador pressionou Enter
        if (!jogoIniciado && Input.GetKeyDown(KeyCode.Return)) // Return é o Enter
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
