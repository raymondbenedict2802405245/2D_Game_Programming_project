using System;
using UnityEngine;

public class ChestReald : MonoBehaviour, IInteractable 
{
    public GameObject coin;
    public AudioSource source;

    public bool chestRealdIsOpen = false;
    public Animator animasi;

    void Start()
    {
        animasi = GetComponent<Animator>();
    }

    public void interact()
    {
        openChestReald();
        Debug.Log("chestRealdIsOpen");
        gameManager.instance.addScore(10);
        GetComponent<Collider2D>().enabled = false;
        source.Play();
    }

    public void OnTouchingPlayer()
    {
        
    }

    public void OnNotTouchingPlayer()
    {
        
    }

    void openChestReald()
    {
        chestRealdIsOpen = true;
        animasi.SetBool("IsOpened", chestRealdIsOpen);
        Debug.Log("penanda");
        Instantiate(coin, transform.position, Quaternion.identity);
    }
}