using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      GetComponent<Rigidbody>().AddForce(-transform.up * 500);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter (Collision collision) {
      if (collision.gameObject.name == "CollisionWallBottom") {
        SceneManager.LoadScene("end");
      }
      if (collision.gameObject.name == "CollisionWallTop") {
        SceneManager.LoadScene("end");
      }
    }
}
