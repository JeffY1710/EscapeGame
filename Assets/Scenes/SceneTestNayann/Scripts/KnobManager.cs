using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Content.Interaction;
using UnityEngine.XR.Interaction.Toolkit;

public class KnobManager : MonoBehaviour
{
    [SerializeField] private Slider jauge;
    private XRKnob knob;

    void Awake()
    {
        if (knob == null)
        {
            knob = gameObject.GetComponent<XRKnob>();
        }
    }

    void Update()
    {
        jauge.value = knob.value;   
    }


    void OnEnable()
    {
        if (knob == null)
            return;

        knob.selectExited.AddListener(OnKnobReleased);
    }

    void OnDisable()
    {
        if (knob == null)
            return;

        knob.selectExited.RemoveListener(OnKnobReleased);
    }

    void OnKnobReleased(SelectExitEventArgs args)
    {
        if (jauge.value > 0.52 && jauge.value < 0.54)
        {
            knob.enabled = false;
        }
    }
}
