using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private static string savedTag;

    void Awake()
    {
        // If we already saved a tag before, apply it
        if (!string.IsNullOrEmpty(savedTag))
        {
            gameObject.tag = savedTag;
        }
        else
        {
            // First time: store the current tag
            savedTag = gameObject.tag;
        }

        DontDestroyOnLoad(gameObject);
    }

    // Call this whenever you change the tag
    public void SetTag(string newTag)
    {
        gameObject.tag = newTag;
        savedTag = newTag;
    }
}
