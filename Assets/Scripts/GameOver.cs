using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Canvas canvas;
    public RectTransform panel;
    private GameObject player;
    public Button pauseButton;
    public Image pauseImg;

    void Start()
    {
        panel.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        panel.gameObject.SetActive(true);
        collision.gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
        pauseButton.gameObject.SetActive(false);
        pauseImg.gameObject.SetActive(false);

    }

}
