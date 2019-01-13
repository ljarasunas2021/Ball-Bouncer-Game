using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PersistentData : MonoBehaviour
{
    private int score;
    private bool win;
    private int level;

    // Start is called before the first frame update
    void Start()
    {
      Reset();
      DontDestroyOnLoad(transform.gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Reset() {
      score = 0;
      win = false;
      level = 0;
    }
}
