using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetScore : MonoBehaviour
{
    private PersistentData persistentScript;
    // Start is called before the first frame update
    void Start()
    {
      persistentScript = gameObject.Find("PersistentObject").GetComponent<PersistentData>();
      gameObject.GetComponent<Text>().text = "Score: " + persistentScript.GetScore().ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddScore(int amount) {
      score += amount;
    }

    public int GetScore() {
      return score;
    }

    public void LevelComplete() {
      level += 1;
    }

    public int GetLevel() {
      return level;
    }
}
