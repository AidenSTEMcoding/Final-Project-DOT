using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;
using static Structs;

public class Player : MonoBehaviour
{
    public void SetTag(string newTag)
    {
        gameObject.tag = newTag;
        savedTag = newTag;
    }
}