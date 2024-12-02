using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransicoesTemp : MonoBehaviour
{
    public string NomeCena;
    public float TempoTrocar;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("TrocarCena", TempoTrocar);
    }

    // Update is called once per frame
    void TrocarCena()
    {
        SceneManager.LoadScene(NomeCena);
    }
}
