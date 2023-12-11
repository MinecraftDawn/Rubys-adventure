using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour {
    public int maxHealth = 5;
    public float speed = 3.0f;
    int currentHealth;
    public int health { get { return currentHealth; }}
    private Rigidbody2D rigidbody2D;
    float horizontal; 
    float vertical;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        // QualitySettings.vSyncCount = 0;
        // Application.targetFrameRate = 10;
        
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        
        
    }

    private void FixedUpdate() {
        // Debug.Log(horizontal + " " + vertical);
        Vector2 position = transform.position;
        position.x += speed * horizontal * Time.deltaTime;
        position.y += speed * vertical * Time.deltaTime; 
        
        rigidbody2D.MovePosition(position);
    }
    
    public void ChangeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }
}
