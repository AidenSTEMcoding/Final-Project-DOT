using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

using UnityEngine;

public class ItemController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Assign tag based on this item's name
            if (gameObject.name == "FI")
                collision.gameObject.tag = "FM";
            else if (gameObject.name == "GI")
                collision.gameObject.tag = "GM";
            else if (gameObject.name == "MI")
                collision.gameObject.tag = "MM";

            Destroy(gameObject);
        }
    }
}