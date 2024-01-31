using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI PointText;
    private int Score;
    private void Awake()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        PointText.text = ("Score: " + Score);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Score")
        {
            Score += 1;
        }
        
    }
}
