using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class ItemController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collided object is the Player
        Player player = collision.GetComponent<Player>();
        if (player != null)
        {
            player.SetTag("Test");
            Destroy(gameObject);   
        }
    }
}