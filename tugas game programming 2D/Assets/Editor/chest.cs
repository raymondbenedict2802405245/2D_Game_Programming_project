using System;
using UnityEditor.Rendering;
using UnityEngine;

public class chest : MonoBehaviour, IInteractable 
{
    public GameObject coin;
    public AudioSource source;

    public bool chestIsOpen = false;
    public Animator animasi;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animasi = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    public void interact()
    {
        openChest();
        Debug.Log("chestIsOpen");
        gameManager.instance.addScore(10);
        GetComponent<Collider2D> ().enabled = false;
        source.Play();
    }

    public void OnTouchingPlayer()
    {
        // throw new System.NotImplementedException();
    }

    public void OnNotTouchingPlayer()
    {
        // throw new System.NotImplementedException();
    }

    void openChest()
    {
        chestIsOpen = true;
        animasi.SetBool("IsOpened", chestIsOpen);
        Debug.Log("penanda");
        Instantiate(coin,transform.position, Quaternion.identity);
    }
}
