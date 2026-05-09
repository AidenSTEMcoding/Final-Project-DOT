using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player _instance { get; private set; }

    private static string savedTag; // Stores the last tag

    void Awake()
    {
        if (_instance != null)
        {
            Destroy(gameObject);
            return;
        }

        _instance = this;
        DontDestroyOnLoad(gameObject);
    
        // Apply saved tag if it exists
        if (!string.IsNullOrEmpty(savedTag))
        {
            gameObject.tag = savedTag;
        }
        else
        {
            savedTag = gameObject.tag;
        }

        Debug.Log("Player Awake, tag: " + gameObject.tag);
    }
   
    // Use this method to change the tag
    public void SetTag(string newTag)
    {
        if (!string.IsNullOrEmpty(newTag))
        {
            gameObject.tag = newTag;
            savedTag = newTag;
            Debug.Log("Player tag changed to: " + newTag);
        }
        else
        {
            Debug.LogWarning("Tried to set empty tag!");
        }
    }
}