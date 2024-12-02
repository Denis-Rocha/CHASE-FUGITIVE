using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class EndSceneController : MonoBehaviour
{
    public VideoPlayer videoPlayer; // Refer�ncia ao Video Player
    public string creditsSceneName = "Creditos"; // Nome da cena de Cr�ditos

    void Start()
    {
        // Adiciona um evento para detectar quando o v�deo termina
        if (videoPlayer != null)
        {
            videoPlayer.loopPointReached += OnVideoEnd;
        }
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        // Carrega a cena de cr�ditos quando o v�deo termina
        SceneManager.LoadScene(creditsSceneName);
    }
}
