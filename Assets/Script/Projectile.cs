using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Vector2 Target;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Target, speed * Time.deltaTime);
    }
}
