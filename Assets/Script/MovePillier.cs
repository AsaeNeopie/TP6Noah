using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class MovePillier : MonoBehaviour
{
    public float Speed;
    public float maxDespawn;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left *Speed* Time.deltaTime);
        
        if (transform.position.x < maxDespawn)
        {
            Destroy(gameObject);
            //Debug.Log("Je suis détruit");
        }
    }
    
}
