using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class LeverInteract : MonoBehaviour
{
    [SerializeField]
    private XRLever lever;

    void Awake()
    {
        if (lever == null)
        {
            lever = GetComponent<XRLever>();
        }
    }

    void OnEnable()
    {
        if (lever == null)
            return;

        lever.onLeverActivate.AddListener(OnLeverAtMax);
        lever.onLeverDeactivate.AddListener(OnLeverAtMin);
    }

    void OnDisable()
    {
        if (lever == null)
            return;

        lever.onLeverActivate.RemoveListener(OnLeverAtMax);
        lever.onLeverDeactivate.RemoveListener(OnLeverAtMin);
    }

    void OnLeverAtMax()
    {
        Debug.Log($"[XRLever] Levier à l'ANGLE MAX ({lever.maxAngle}°)");
    }

    void OnLeverAtMin()
    {
        lever.enabled = false;
        Debug.Log($"[XRLever] Levier à l'ANGLE MIN ({lever.minAngle}°)");
    }
}
