using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerLose : MonoBehaviour
{
    public GameObject panelLose;
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Wall")
        {
            Time.timeScale = 0;
            Debug.Log("Oui");
            panelLose.SetActive(true);
        }
        
    }
}
