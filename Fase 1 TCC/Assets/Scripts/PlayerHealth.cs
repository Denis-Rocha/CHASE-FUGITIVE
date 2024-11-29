using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement; // Importar para reiniciar a cena

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100; // Vida máxima do jogador

    public void TomarDano(int dano)
    {
        maxHealth -= dano;
        Debug.Log("Jogador tomou " + dano + " de dano! Vida restante: " + maxHealth);

        if (maxHealth <= 0)
        {
            Morrer();
        }
    }

    private void Morrer()
    {
        Debug.Log("Jogador morreu!");
        StartCoroutine(Morrendo());
    }


    IEnumerator Morrendo()
    {
        GetComponent<PlayerController>().enabled = false;
        GetComponent<Animator>().SetBool("morrendo", true);
        GetComponent<Animator>().SetBool("correndo", false);

        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
