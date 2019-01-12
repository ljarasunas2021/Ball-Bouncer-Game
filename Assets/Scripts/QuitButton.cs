using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{
  void Start()
  {
    Button quit = GetComponent<Button>();
    quit.onClick.AddListener(QuitGame);
  }

  void Update()
  {

  }

  void QuitGame () {
    Debug.Log("Good Bye");
    Application.Quit();
  }
}
