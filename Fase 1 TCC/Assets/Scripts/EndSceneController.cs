using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class EndSceneController : MonoBehaviour
{
    public VideoPlayer videoPlayer; // Referência ao Video Player
    public string creditsSceneName = "Creditos"; // Nome da cena de Créditos

    void Start()
    {
        // Adiciona um evento para detectar quando o vídeo termina
        if (videoPlayer != null)
        {
            videoPlayer.loopPointReached += OnVideoEnd;
        }
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        // Carrega a cena de créditos quando o vídeo termina
        SceneManager.LoadScene(creditsSceneName);
    }
}
