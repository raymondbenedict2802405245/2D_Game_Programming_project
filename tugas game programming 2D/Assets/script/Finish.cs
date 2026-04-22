using UnityEngine;

public class Finish : MonoBehaviour, IInteractable
{
    public Animator animasi;

    void Start()
    {
        animasi = GetComponent<Animator>();
    }

    public void interact()
    {
        Debug.Log("Finish interacted!");
        gameManager.instance.RestartGame();
        GetComponent<Collider2D>().enabled = false;

        if (animasi != null)
        {
            animasi.SetTrigger("Finish"); 
        }
    }

    public void OnTouchingPlayer()
    {
       
    }

    public void OnNotTouchingPlayer()
    {
        
    }
}
