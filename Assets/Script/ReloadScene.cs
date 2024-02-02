using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
  public void RestartScene()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }
}
