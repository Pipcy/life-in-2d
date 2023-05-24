using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LeftBlock : MonoBehaviour
{
    public TextMeshProUGUI text;
    void Start()
    {
        text.enabled = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("left_block"))
        {
            text.enabled = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("left_block"))
        {
            text.enabled = false;
        }
    }
}

