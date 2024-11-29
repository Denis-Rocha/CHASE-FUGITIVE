using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI; // Refer�ncia ao Canvas do Menu de Pausa
    public GameObject settingsCanvas; // Refer�ncia ao Canvas das Configura��es
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
        settingsCanvas.SetActive(false); // Garante que as configura��es est�o ocultas
        Time.timeScale = 0f; // Congela o tempo do jogo
        isPaused = true;

        // Libera o cursor
        Cursor.lockState = CursorLockMode.None; // Desbloqueia o cursor
        Cursor.visible = true; // Torna o cursor vis�vel
    }

    public void ResumeGame()
    {
        pauseMenuUI.SetActive(false);
        settingsCanvas.SetActive(false); // Garante que as configura��es est�o ocultas
        Time.timeScale = 1f; // Retoma o tempo do jogo
        isPaused = false;

        // Trava o cursor novamente
        Cursor.lockState = CursorLockMode.Locked; // Trava o cursor no centro
        Cursor.visible = false; // Esconde o cursor
    }

    public void OpenSettings()
    {
        settingsCanvas.SetActive(true); // Mostra o canvas das configura��es
        pauseMenuUI.SetActive(false); // Oculta o menu de pausa
    }

    public void CloseSettings()
    {
        settingsCanvas.SetActive(false); // Oculta o canvas das configura��es
        pauseMenuUI.SetActive(true); // Retorna ao menu de pausa
    }

    public void RestartLevel()
    {
        Time.timeScale = 1f; // Garante que o tempo volte ao normal
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu"); // Certifique-se de que o nome da cena est� correto
    }
}
