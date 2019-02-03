using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Padel : MonoBehaviour
{
    private Vector3 pdlPos = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pdlPos = transform.position;
        float xPos = transform.position.x;
        float zPos = transform.position.z;
        pdlPos.x = Mathf.Clamp(xPos, -0.27f, 0.27f);
        pdlPos.z = Mathf.Clamp(zPos, 0f, 0.17f);
        transform.position = pdlPos;
    }

    void OnCollisionEnter(Collision other)
    {
        Ball.rb.AddForce(Ball.rb.velocity.normalized * Time.deltaTime * 30f);
    }
}
