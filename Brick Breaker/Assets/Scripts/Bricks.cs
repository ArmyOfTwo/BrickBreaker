using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{
    public GameObject brickParti;

    void OnCollisionEnter(Collision other)
    {
        Instantiate(brickParti, transform.position, Quaternion.identity);
        GM.instance.DestroyBrick();
        Destroy(gameObject, 0.2f);
        Ball.rb.AddForce(Ball.rb.velocity.normalized * Time.deltaTime * 30f);
    }
}
