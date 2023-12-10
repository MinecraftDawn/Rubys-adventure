using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour {
    private Rigidbody2D rigidbody2D;
    float horizontal; 
    float vertical;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        // QualitySettings.vSyncCount = 0;
        // Application.targetFrameRate = 10;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        
        
    }

    private void FixedUpdate() {
        Debug.Log(horizontal + " " + vertical);
        Vector2 position = transform.position;
        position.x += 3f * horizontal * Time.deltaTime;
        position.y += 3f * vertical * Time.deltaTime; 
        
        rigidbody2D.MovePosition(position);
    }
}
