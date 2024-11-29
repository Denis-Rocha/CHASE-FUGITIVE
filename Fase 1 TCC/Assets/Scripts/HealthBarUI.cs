using UnityEngine;
using UnityEngine.UI; // Necessário para usar elementos de UI

public class HealthBarUI : MonoBehaviour
{
    public Slider healthSlider; // Referência ao Slider da barra de vida
    public PlayerHealth playerHealth; // Referência ao script de vida do jogador

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
