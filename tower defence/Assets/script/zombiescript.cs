using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class zombiescript : MonoBehaviour
{
    public float speed;
    public int healh;

    private void FixedUpdate()
    {
        transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
    }
    private void Update()
    {
       
    }


    void updatehealth()
    {
        if (healh <= 0)
        {
            Destroy(gameObject);
        }

    }

     public void takedamage(int damage)
    {
        healh -= damage;    
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            takedamage(5);
            updatehealth();
        }
    }
}
