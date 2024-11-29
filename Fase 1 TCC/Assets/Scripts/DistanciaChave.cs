using UnityEngine;
using TMPro;

public class DistanciaChave : MonoBehaviour
{
    public TextMeshProUGUI distanceText; // Referência ao componente TextMeshPro para mostrar a distância
    private Transform player; // Referência ao jogador
    public Transform fimlabirinto;
    private int keysCollected = 0; // Contador de chaves coletadas
    private int totalKeys = 3; // Total de chaves necessárias

    void Start()
    {
        player = GetComponent<Transform>();
    }

    void Update()
    {
        if (keysCollected < totalKeys)
        {
            // Encontra a chave mais próxima
            GameObject closestKey = FindClosestKey();

            if (closestKey != null)
            {
                // Calcula a distância entre o jogador e a chave mais próxima
                float distance = Vector3.Distance(player.position, closestKey.transform.position);

                // Exibe a distância no TextMeshPro
                distanceText.text = Mathf.Round(distance) + " Metros";
            }
        }
        else if (fimlabirinto != null)
        {
            // Quando todas as chaves são coletadas, exibe a distância até o fim do labirinto
            float distanceToReferencia = Vector3.Distance(player.position, fimlabirinto.position);
            distanceText.text =Mathf.Round(distanceToReferencia) + " Metros";
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Verifica se o jogador colidiu com uma chave
        if (other.CompareTag("chave"))
        {
            // Incrementa o contador de chaves coletadas
            keysCollected++;

            // Remove a chave do cenário
            Destroy(other.gameObject);

            // Atualiza o texto para indicar quantas chaves faltam
            if (keysCollected < totalKeys)
            {
                distanceText.text = "Chaves coletadas: " + keysCollected + "/" + totalKeys;
            }
        }
    }

    // Função para encontrar o objeto com a tag "chave" mais próximo do jogador
    GameObject FindClosestKey()
    {
        GameObject[] keys = GameObject.FindGameObjectsWithTag("chave"); // Acha todos os objetos com a tag "chave"
        GameObject closest = null;
        float minDistance = Mathf.Infinity;

        foreach (GameObject key in keys)
        {
            float distance = Vector3.Distance(player.position, key.transform.position);

            if (distance < minDistance)
            {
                closest = key;
                minDistance = distance;
            }
        }

        return closest;
    }
}
