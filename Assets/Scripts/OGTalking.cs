using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
public class OGTalking : MonoBehaviour
{
  using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class TalkingNPC : MonoBehaviour
{
    public List<string> dialogue = new List<string>();
    private GameObject _talkIcon;
    public bool sendToNextLevel = false;

    private void Start()
    {
        _talkIcon = transform.Find(Structs.GameObjects.talkIcon).gameObject;
        _talkIcon.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == Structs.Tags.playerTag)
        {
            _talkIcon.SetActive(true);
            collision.GetComponent<PlayerDialogue>().CopyDialogue(dialogue);
            collision.GetComponent<PlayerDialogue>().SetCanSpeak(true);
            collision.GetComponent<PlayerDialogue>().flagLoad = sendToNextLevel;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == Structs.Tags.playerTag)
        {
            _talkIcon.SetActive(false);
            collision.GetComponent<PlayerDialogue>().SetCanSpeak(false);
        }
    }

}
*\