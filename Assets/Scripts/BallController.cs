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
    // Start is called before the first frame update
    void Start()
    {
      GetComponent<Rigidbody>().AddForce(-transform.up * 500);
      score = 0;
      scoreUI = GameObject.Find("UI Text - Score").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
      scoreUI.text = "Score: " + score.ToString();
    }

    private void OnCollisionEnter (Collision collision) {
      if (collision.gameObject.name == "CollisionWallBottom") {
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
    }
}
