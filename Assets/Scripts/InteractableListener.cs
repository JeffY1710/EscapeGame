using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class InteractableListener : MonoBehaviour
{
    public XRSimpleInteractable interable;

    private void Awake()
    {
     interable = GetComponent<XRSimpleInteractable>();   
    }
    private void OnEnable()
    {
        interable.selectEntered.AddListener(Test);
    }

    private void OnDisable()
    {
        interable.selectEntered.RemoveListener(Test);
    }

    public void Test(SelectEnterEventArgs args)
    {
        Debug.Log(args);
    }
}
