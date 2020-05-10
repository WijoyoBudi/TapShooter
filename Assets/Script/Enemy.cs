using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private Transform playerPos;
    private Player player;
    public int scoreValue = 10;
    public GameObject effect;
    void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
    }

     void OnTriggerEnter2D(Collider2D other) {
     if (other.CompareTag("Player")){
         Instantiate(effect, transform.position, Quaternion.identity);
         player.health--;
         Destroy(gameObject);
        }   
    
     if (other.CompareTag("Projectile")){
        Instantiate(effect, transform.position, Quaternion.identity);
        Destroy (other.gameObject);
        ScoreManager.score += scoreValue;
        Destroy(gameObject);
        }

    }
}
