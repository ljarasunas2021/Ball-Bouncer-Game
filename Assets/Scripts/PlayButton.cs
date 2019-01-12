using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    void Start()
    {
      Button start = GetComponent<Button>();
      start.onClick.AddListener(StartGame);
    }

    void Update()
    {

    }

    void StartGame () {
      Debug.Log("Starting Game");
      SceneManager.LoadScene("level1");
    }
}
