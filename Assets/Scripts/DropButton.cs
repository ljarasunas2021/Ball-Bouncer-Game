using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DropButton : MonoBehaviour
{

    public GameObject ball;
    public GameObject spawn;

    private Vector3 pos;
    private Quaternion rot;
    private bool dropped;

    // Start is called before the first frame update
    void Start()
    {
        dropped = false;
        Button drop = GetComponent<Button>();
        drop.onClick.AddListener(DropBall);
    }

    void Update()
    {

    }

    // Update is called once per frame
    void DropBall()
    {
      if (!dropped) {
        Debug.Log("DropBall");
        pos = spawn.transform.position;
        rot = spawn.transform.rotation;
        Instantiate(ball, pos, rot);
        dropped = true;
      }
    }
}
