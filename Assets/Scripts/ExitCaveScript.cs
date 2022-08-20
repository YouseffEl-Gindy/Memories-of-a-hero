using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ExitCaveScript : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerMovementCave player;
    public TMP_Text warningText;


    private void Start()
    {
        warningText.text = "";
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (player.amountToCollect == player.collected)
        {

        }
        else
        {
            
            StartCoroutine(ActivateWarningText());
            //Debug.Log("hoi");
        }
    }

    IEnumerator ActivateWarningText()
    {
        warningText.text = "Collect all gems before you leave";

        yield return new WaitForSeconds(3);
        warningText.text = "";

    }

    
}
