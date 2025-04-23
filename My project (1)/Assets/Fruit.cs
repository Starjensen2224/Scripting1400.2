using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    //public int points = 10;
    //public SimpleIntData scoreManager; // Drag your score manager in the inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //scoreManager.UpdateValue(points);
            Destroy(gameObject); // Destroy this fruit
        }
    }
}
