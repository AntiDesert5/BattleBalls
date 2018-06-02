using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemidestroy : MonoBehaviour {
    public int saludEnemy;
    public int puntos;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "bullet")
        {
            saludEnemy -= ball.damage;
            if (saludEnemy <= 0)
            {
                Debug.Log(puntos);
                Destroy(gameObject);
                
            }
            
        }
    }
  
}
