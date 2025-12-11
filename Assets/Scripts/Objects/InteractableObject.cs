using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public virtual void Interact()
    {
        Debug.Log("This objects is a son of the InteractableObject");
    }
}
