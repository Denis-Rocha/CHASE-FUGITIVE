using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HUDController : MonoBehaviour
{
    public Transform player;
    public Transform[] objects;
    public Text distanceText;
    public GameObject distancePanel;


    private void Update()
    {
        if (!distancePanel.activeSelf) return;

        float distance1 = Vector3.Distance(player.position,
        objects[0].position);
        float distance2 = Vector3.Distance(player.position,
        objects[1].position);
        float distance3 = Vector3.Distance(player.position,
       objects[2].position);


        float nearestDistance = Mathf.Min(distance1, distance2, distance3);
        distanceText.text = "Distância até o objeto mais próximo: " + nearestDistance.ToString("F2") + "m";
    }
}
