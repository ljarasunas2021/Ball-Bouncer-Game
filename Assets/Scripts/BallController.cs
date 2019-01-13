using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    public int hitScore = 10;
    public GameObject firework;

    private int score;
    private Text scoreUI;
    private PersistentData persistentScript;
    // Start is called before the first frame update
    void Start()
    {
      GetComponent<Rigidbody>().AddForce(-transform.up * 500);
      score = 0;
      scoreUI = GameObject.Find("UI Text - Score").GetComponent<Text>();
      persistentScript = GameObject.Find("PersistentObject").GetComponent<PersistentData>();
    }

    // Update is called once per frame
    void Update()
    {
      scoreUI.text = "Score: " + score.ToString();
    }

    private void OnCollisionEnter (Collision collision) {
      if (collision.gameObject.name == "CollisionWallBottom") {
        persistentScript.SetWin(false);
        SceneManager.LoadScene("end");
      }
      if (collision.gameObject.name == "CollisionWallTop") {
        SceneManager.LoadScene("end");
      }
      if (collision.gameObject.name == "angle" ||
          collision.gameObject.name == "ibeam" ||
          collision.gameObject.name == "diamond" ||
          collision.gameObject.name == "octogan" ||
          collision.gameObject.name == "platform") {
          score += hitScore;
          }
      if (collision.gameObject.name == "star") {
        score *= 2;
        Destroy(collision.gameObject);
        Instantiate(firework, transform.position, Quaternion.identity);
      }
      if (collision.gameObject.name == "GoalTop") {
        score *= 3;
        persistentScript.AddScore(score);
        persistentScript.SetWin(true);
        persistentScript.LevelComplete();
        SceneManager.LoadScene("end");
      }
    }

    public void AddScore(int amount) {
      score += amount;
    }

    public void SetWin(bool state) {
      win = state;
    }

    public void LevelComplete () {
      level += 1;
    }
}
