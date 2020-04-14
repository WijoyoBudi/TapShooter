using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawners : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    public Transform[] spawnSpots;
    private float timeDiantaraSpawn;
    public float startTimeDiantaraSpawn;
    void Start()
    {
        timeDiantaraSpawn = startTimeDiantaraSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeDiantaraSpawn <= 0){
          int randPos = Random.Range(0, spawnSpots.Length);
          Instantiate(enemy, spawnSpots[randPos].position, Quaternion.identity);
          timeDiantaraSpawn = startTimeDiantaraSpawn;
        }else{
            timeDiantaraSpawn -= Time.deltaTime;
        }
    }
}
