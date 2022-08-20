using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableScript : MonoBehaviour
{

    public PlayerMovementCave player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.IncrementCollectable();
        Destroy(this.gameObject);
    }
}
