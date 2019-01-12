using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DropButton : MonoBehaviour
{

    public GameObject ball;
    private Vector3 pos;
    private Quaternion rot;

    // Start is called before the first frame update
    void Start()
    {
        pos = new Vector3(650, 650, 0);
        rot = Quaternion.identity;

        Button drop = GetComponent<Button>();
        drop.onClick.AddListener(DropBall);
    }

    void Update()
    {

    }

    // Update is called once per frame
    void DropBall()
    {
      Debug.Log("DropBall");
      Instantiate(ball, pos, rot);
    }
}
