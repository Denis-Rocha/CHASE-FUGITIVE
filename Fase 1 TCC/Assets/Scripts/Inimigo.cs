using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour

{
    public int VidaInimigo;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (VidaInimigo <= 0)
        {
            GetComponent<Animator>().SetBool("morrendo", true);
            Destroy(GetComponent<EnemyCombat>());
            GetComponent<Collider>().enabled = false;
            GetComponent<Rigidbody>().isKinematic = true;
            Destroy(GetComponent<InimigoMovimentoECombate>());

        }
    }
}