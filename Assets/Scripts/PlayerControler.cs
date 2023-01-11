using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    int playerHealth = 3;

    public float playerSpeed = 5.5f;

    string texto = "Hello World";

    bool isGrounded = false;


    // Start is called before the first frame update
    void Start()
    {
        playerHealth = 10;
        Debug.Log(texto);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal"),0,0) * Time.deltaTime; 
    }
}
