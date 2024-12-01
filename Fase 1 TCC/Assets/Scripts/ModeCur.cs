using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeCur : MonoBehaviour
{
    public bool Trancado;
    // Start is called before the first frame update
    void Start()
    {
        if (Trancado)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        }

        // Update is called once per frame
        void Update()
    {
        
    }
}
