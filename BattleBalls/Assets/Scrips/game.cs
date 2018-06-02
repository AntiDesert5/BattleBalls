using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game : MonoBehaviour {
    public GameObject ballPrefap;
    public Transform ballSpawner;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        playerShooting();//llama a metodo disparar
    }

    public void playerShooting()
    {
        Touch touch = Input.GetTouch(0);

        switch (touch.phase)
        {

            case TouchPhase.Ended:
                // Report that the touch has ended when it ends
                //if (Input.GetButtonDown("Fire"))//si se aprieta boton asignado a fire1 que en este caso es clic de mouse
                //{
                    Instantiate(ballPrefap, ballSpawner.position, ballSpawner.rotation);//crea copia de prefat

                //}
                break;
                
        }
       
    }
}
