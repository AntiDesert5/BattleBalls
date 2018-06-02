using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {
    public float ballLife;
    public float velocidad;
    private Rigidbody2D balls;
    public static int damage;
    public int damagereference;

    void Awake()//valores antes de que empice todo 
    {
        damage = damagereference;
        balls = GetComponent<Rigidbody2D>();
    }

        // Use this for initialization
        void Start () {
        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);//SAcar posicion de mouse
        Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);//asignarla a la camara del juego
        balls.velocity = new Vector2(velocidad, objPosition.y);//mandar a llamar la velocidad en eje x y eje y 
    }
	
	// Update is called once per frame
	void Update () {
        Destroy(gameObject, ballLife);//destruir objeto bala con tiempo asignado en bulletLife
    }
}
