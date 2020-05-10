using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    public Camera Cam;
    private Rigidbody2D pl;
    private Vector2 moveVelocity;
    Vector2 movement;
    Vector2 mousePos;
    public int health = 10;
    public Text healthDisplay;
    
    void Start(){
        pl = GetComponent<Rigidbody2D>();
        }

    // Update is called once per frame
    void Update(){
        healthDisplay.text = "HEALTH :" + health;   
        movement.x = Input.GetAxisRaw("Horizontal"); 
        movement.y = Input.GetAxisRaw("Vertical");
        mousePos = Cam.ScreenToWorldPoint(Input.mousePosition);

        if(health <= 0){
        SceneManager.LoadScene("Game Over");    
        }
    }
    
    void FixedUpdate(){
    pl.MovePosition(pl.position + movement * speed *Time.fixedDeltaTime);
    
    Vector2 lookDir = mousePos - pl.position;
    float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
    pl.rotation = angle;
    }


}
