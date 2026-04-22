using UnityEngine;
using UnityEngine.InputSystem;

public interface IInteractable
{
    void interact();
    void OnTouchingPlayer();
    void OnNotTouchingPlayer();
}
public class intractableChest : MonoBehaviour
{

    private IInteractable currentInteractable;

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.eKey.IsActuated() && currentInteractable != null)
        {
            currentInteractable.interact();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        IInteractable interactable= collision.GetComponent<IInteractable>();

        if(interactable != null)
        {
            currentInteractable = interactable;
            currentInteractable.OnTouchingPlayer();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        IInteractable interactable= collision.GetComponent<IInteractable>();

        if(interactable != null && interactable == currentInteractable)
        {
            currentInteractable.OnNotTouchingPlayer();
            currentInteractable = null;
            
        }
    }
}
