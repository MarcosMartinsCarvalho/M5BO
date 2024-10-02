using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public Transform[] SpawnPoints;

    public GameObject[] Zombie;

    private void Start()
    {
        InvokeRepeating("SpawnZombie", 0 , 1);
    }

    void SpawnZombie()
    {
        int RandomZombie = Random.Range(0, Zombie.Length);
        int RandomPoint = Random.Range(0, SpawnPoints.Length);
        GameObject myZombie = Instantiate(Zombie[RandomZombie], SpawnPoints[RandomPoint].position, Quaternion.identity);
    }
}
    