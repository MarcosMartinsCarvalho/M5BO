using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    

    void Update()
    {
        transform.position += Vector3.right * (speed * Time.deltaTime);
    }

    

}
