using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{




    public string sceneToLoad;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Exit") {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}

public class Pickup : MonoBehaviour
{
    string name; 
}


/*
public class DropOff : MonoBehaviour
{




    public string sceneToLoad;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Exit")
        {
            switch(other.GetComponentsInChildren<DropOff>()) {
                case "Pizza":
                    {

                        break''
                    }
        }
    }
}*/
