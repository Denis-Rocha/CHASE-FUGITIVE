using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 100f;

    void Update()
    {
        // Rotaciona o objeto continuamente na horizontal (eixo Y)
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);

        // Checa se o objeto rotacionou 180 graus
        if (transform.rotation.eulerAngles.y >= 180f)
        {
            // Inverte a dire��o da rota��o
            rotationSpeed = -rotationSpeed;
        }
        else if (transform.rotation.eulerAngles.y <= 0f)
        {
            // Inverte a dire��o da rota��o novamente
            rotationSpeed = -rotationSpeed;
        }
    }
}