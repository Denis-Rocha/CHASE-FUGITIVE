using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FimFase3 : MonoBehaviour
{
    public GameObject player; // Referência ao jogador
    public GameObject[] camera;

    // Update is called once per frame
    void Update()
    {
        Fimdafase();
    }
    private void Fimdafase()
    {
        if (GetComponent<Inimigo>().VidaInimigo <= 0)
        {
            StartCoroutine(FimDeJogo());
        }
    }
    IEnumerator FimDeJogo()
    {
        camera[0].SetActive(false);
        camera[1].SetActive(true);
        player.GetComponent<Animator>().SetBool("dancando", true);

        yield return new WaitForSeconds(5f);

        SceneManager.LoadScene("FimDeJogo");
    }
}

