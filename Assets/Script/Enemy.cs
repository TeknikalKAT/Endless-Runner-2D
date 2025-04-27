using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    GameObject player;
    public GameObject particle;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
        else if (collision.tag == "Player")
        {
            Destroy(player.gameObject);
            Instantiate(particle, player.transform.position, player.transform.rotation);
        }
    }
}
