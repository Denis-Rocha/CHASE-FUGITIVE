using UnityEngine;
using UnityEngine.UI; // Necess�rio para usar elementos de UI

public class HealthBarUI : MonoBehaviour
{
    public Slider healthSlider; // Refer�ncia ao Slider da barra de vida
    public PlayerHealth playerHealth; // Refer�ncia ao script de vida do jogador

    void Start()
    {
        // Configura o valor inicial da barra de vida
        healthSlider.maxValue = playerHealth.maxHealth;
        healthSlider.value = playerHealth.maxHealth;
    }

    void Update()
    {
        // Atualiza a barra de vida com o valor atual da vida do jogador
        healthSlider.value = playerHealth.maxHealth;
    }
}
