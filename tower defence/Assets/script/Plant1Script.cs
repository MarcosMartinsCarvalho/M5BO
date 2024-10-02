using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant1Script : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private float fireRate = 1f;

    private float nextFireTime = 0f;

    private void Update()
    {
        if (Time.time >= nextFireTime)
        {
            Instantiate(prefab, transform.position, Quaternion.identity);
            nextFireTime = Time.time + 1f / fireRate;

        }
    }
}
