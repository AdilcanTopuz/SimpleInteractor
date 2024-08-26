using UnityEngine;

public class TestInteraction : MonoBehaviour, IInteractable
{
    public string GetKeyDescription()
    {
        return "Press E to Talk";
    }

    public void Interact()
    {
        print("Hi mate");
    }
}
