using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Content.Interaction;
using UnityEngine.XR.Interaction.Toolkit;

public class KnobManager : MonoBehaviour
{
    [SerializeField] private Slider jauge;
    

    void Update()
    {
        jauge.value = gameObject.GetComponent<XRKnob>().value;   

        if (jauge.value > 0.52 && jauge.value < 0.54)
        {
            JaugeSuceed();
        }
    }

    public void JaugeSuceed()
    {
        Debug.Log("Tiroir ouvert");
    }
}
