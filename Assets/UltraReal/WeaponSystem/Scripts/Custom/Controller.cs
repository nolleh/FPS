using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        move();
	}
    float mousePosX;
    public float speed = 5f;
    void move()
    {

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }

        float mousePosX = Input.GetAxis("Mouse X");
        float mousePosY = Input.GetAxis("Mouse Y");
        transform.Rotate(0, mousePosX * 10, 0);
        transform.Rotate(mousePosY * -1, 0, 0);
  
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);
    }
}
