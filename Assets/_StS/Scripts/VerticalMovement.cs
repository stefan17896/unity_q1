using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovement : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float verticalSpeed = 0.5f;
    public float horizontalSpeed = 0.5f;
    bool mode = false;

    public bool Mode { get => mode; set => mode = value; }

    public float moveSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Mode)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            }
        }
        if(!Mode){
            float h = Input.GetAxis("Mouse Y") * verticalSpeed;
            float v = Input.GetAxis("Mouse X") * horizontalSpeed;
            float t = h + 30;
            transform.Translate(v, h, 0);

        }

        if (Input.GetKeyDown(KeyCode.F2)){ Mode = true; }
        if (Input.GetKeyDown(KeyCode.F1)){ Mode = false; }
    }
}
