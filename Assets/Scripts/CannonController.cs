using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CannonController : MonoBehaviour
{
    public int minRot = -50;
    public int maxRot = 50;
    public float minX;
    public float maxX;
    public float speed = 1.0f;

    private bool drag;
    private int oldMouseX;

    // Start is called before the first frame update
    void Start()
    {
      transform.Rotate(0, 0, Random.Range(minRot, maxRot));
      drag = false;
    }

    // Update is called once per frame
    void Update()
    {
      if (drag) {
        Debug.Log(Input.mousePosition.x);
        float posX = transform.position.x + ((Input.mousePosition.x - oldMouseX) * speed);
        posX = Mathf.Min (Mathf.Max (minX, posX), maxX);
        transform.position = new Vector3(posX, transform.position.y, transform.position.z);
        oldMouseX = (int)Input.mousePosition.x;
      }
    }

    void OnMouseDown() {
      drag = true;
      oldMouseX = (int)Input.mousePosition.x;
    }

    void OnMouseUp() {
      drag = false;
    }
}
