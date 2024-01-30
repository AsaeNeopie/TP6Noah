using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D PlayerRigidbody;
    public float Bounce;
    private void Start()
    {
        PlayerRigidbody = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            PlayerRigidbody.AddForce(Vector2.up*Bounce); 
        }
        
    }
  
}
