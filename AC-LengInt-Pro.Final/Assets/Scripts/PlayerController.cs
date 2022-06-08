using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Script de:
    // WASD movimiento de jugador, Flechas movimiento de la camara y Space salto 
    //  UnityInputSystem 

    public float mouseHorizontal = 1f;
    public float mouseVertical= 2f;

    float h_mouse;
    float v_mouse;

    public float movespeed = 2;

    public Camera cam;

    float h;
    float v;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();

    }

    private void Move()
    {

        h_mouse = mouseHorizontal * Input.GetAxis("Mouse X");
        v_mouse = mouseVertical * Input.GetAxis("Mouse Y");

        transform.Rotate(0, h_mouse, 0);
        cam.transform.Rotate(-v_mouse, 0, 0);

        h= Input.GetAxis("Horizontal");
        v= Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(h, 0, v);

        //transform.Translate(direction * movespeed * Time.deltaTime);
        GetComponent<CharacterController>().SimpleMove(direction * movespeed * Time.deltaTime);

    }

}
