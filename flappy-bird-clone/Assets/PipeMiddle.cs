using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeMiddle : MonoBehaviour
{
    public Logic logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    public void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.layer == 6) {
            logic.addScore();
        }
    }
}
