using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarraMove : MonoBehaviour {

    private Rigidbody2D barra;
    public float barraSpeed;
	// Use this for initialization
	void Start () {
        barra = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        barraMovimiento();
	}

    public void barraMovimiento()
    {

            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                // Get movement of the finger since last frame
                Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

            
            //transform.Translate(-touchDeltaPosition.x * barraSpeed, -touchDeltaPosition.y * barraSpeed, 0);
            barra.velocity = new Vector2(barra.velocity.x, touchDeltaPosition.y);
            }


            /*
        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);//SAcar posicion de mouse
        Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);//asignarla a la camara del juego
        barra.velocity = new Vector2(0, objPosition.y);//mandar a llamar la velocidad en eje x y eje y 
        if (objPosition.y > 0)
        {
            barra.velocity=new Vector2(barra.velocity.x,barraSpeed);
        }
        if (objPosition.y < 0)
        {
            barra.velocity = new Vector2(barra.velocity.x, -barraSpeed);
        }*/
    }
}
