using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextSceneOnTrigger : MonoBehaviour
{
    public string targetTag = "Portal"; // Tag do objeto que acionará a mudança de cena

    void OnTriggerEnter(Collider other)
    {
        // Verifica se o jogador colidiu com o objeto com a tag especificada
        if (other.CompareTag(targetTag))
        {
            // Carrega a próxima cena no Build Settings
            int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(nextSceneIndex);
        }
    }
}
