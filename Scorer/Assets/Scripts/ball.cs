using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {

    Vector2 cur_vel;
    Vector2 des_Vel;
    public float initSpeed = 2;
    public float speed;
    Rigidbody2D rb;
    float startTime = 0;
    public float increaseRate = 0.1f;
    public float startIncrease = 20f;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        transform.position = Vector2.zero;
        cur_vel = initSpeed*Vector2.up;
        float theta = Random.Range(-30f, 30f);
        cur_vel = new Vector2(initSpeed * Mathf.Sin(theta), initSpeed * Mathf.Cos(theta));
        Debug.Log(cur_vel);
        rb.velocity = cur_vel;
        speed = initSpeed;
        startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time > startTime + startIncrease)
        {
            speed += increaseRate * (Time.time - startTime - startIncrease) * Time.deltaTime;
            cur_vel = speed * rb.velocity.normalized;
            rb.velocity = cur_vel;
        }
	}
}
