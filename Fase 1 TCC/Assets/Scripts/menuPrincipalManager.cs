using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuPrincipalManager : MonoBehaviour
{
    [SerializeField] private string nomeDoLevelDeJogo;
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelOpcoes;
    [SerializeField] private GameObject painelFASES;
    private bool Trancado;
    public void VoltarMenu()

    {
        SceneManager.LoadScene("MenuPrincipal");
    }

    public void Fase1()
    {
        SceneManager.LoadScene("FASE1");
    }
    public void Fase2()
    {
        SceneManager.LoadScene("FASE2");
    }
    public void Fase3()
    {
        SceneManager.LoadScene("FASE3");
    }
    public void Jogar()
    {
        SceneManager.LoadScene(nomeDoLevelDeJogo);

    }

    public void AbrirOpcoes()
    {
        painelMenuInicial.SetActive(false);
        painelOpcoes.SetActive(true);

    }

    public void FecharOpcoes()

    {
        painelOpcoes.SetActive(false);
        painelMenuInicial.SetActive(true);

    }

    public void AbrirFases()
    {
        painelMenuInicial.SetActive(false);
        painelFASES.SetActive(true);

    }
    public void FecharFases()

    {
        painelFASES.SetActive(false);
        painelMenuInicial.SetActive(true);

    }

    public void SairJogo()
    {
        Application.Quit();

    }
}
