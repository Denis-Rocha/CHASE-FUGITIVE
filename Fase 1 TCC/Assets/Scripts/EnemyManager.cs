using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyManager : MonoBehaviour
{
    [Header("Configurações do Inimigo")]
    public int vidaInimigo = 100; // Vida inicial do inimigo

    public void ReceberDano(int dano)
    {
        // Reduz a vida do inimigo
        vidaInimigo -= dano;

        // Verifica se a vida chegou a zero
        if (vidaInimigo <= 0)
        {
            Derrotar();
        }
    }

    private void Derrotar()
    {
        Debug.Log("Inimigo derrotado!");
        Destroy(gameObject); // Remove o inimigo do jogo
        CarregarCenaFimDeJogo();
    }

    private void CarregarCenaFimDeJogo()
    {
        // Certifique-se de que o nome da cena está correto no Unity
        SceneManager.LoadScene("FimDeJogo");
    }
}
