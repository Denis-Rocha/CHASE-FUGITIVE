using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartSceneOnTrigger : MonoBehaviour
{
    public string targetTag = "Obstacle"; // Tag do objeto que acionará a reinicialização da cena

    void OnTriggerEnter(Collider other)
    {
        // Verifica se o jogador colidiu com o objeto com a tag especificada
        if (other.CompareTag(targetTag))
        {
            // Reinicia a cena atual
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
