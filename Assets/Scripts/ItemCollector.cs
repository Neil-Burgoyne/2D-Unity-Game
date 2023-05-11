using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int oranges = 0;
    [SerializeField] private Text OrangesText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Orange"))
        {
            Destroy(collision.gameObject);
            oranges++;
            OrangesText.text = "Oranges: " + oranges;
        }
    }
}
