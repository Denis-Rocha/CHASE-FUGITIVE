using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI; // Referência ao Canvas do Menu de Pausa
    private bool isPaused = false;

    void Update()
    {
        // Verifica se o jogador pressionou ESC
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
                ResumeGame();
            else
                PauseGame();
        }
    }

    public void PauseGame()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f; // Congela o tempo do jogo
        isPaused = true;

        // Libera o cursor
        Cursor.lockState = CursorLockMode.None; // Desbloqueia o cursor
        Cursor.visible = true; // Torna o cursor visível
    }

    public void ResumeGame()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f; // Retoma o tempo do jogo
        isPaused = false;

        // Trava o cursor novamente
        Cursor.lockState = CursorLockMode.Locked; // Trava o cursor no centro
        Cursor.visible = false; // Esconde o cursor
    }

    public void RestartLevel()
    {
        Time.timeScale = 1f; // Garante que o tempo volte ao normal
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuPrincipal"); // Certifique-se de que o nome da cena está correto
    }
}
