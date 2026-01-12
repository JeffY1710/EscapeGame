using UnityEngine;

public class PriceScript : MonoBehaviour
{
    [SerializeField] private float total;

    public void addPrice(float price)
    {
        total = total + price;
    }

    public void removePrice(float price)
    {
        total = total - price;
    }

    public float getTotal()
    {
        //Debug.Log(total);
        return total;
    }
}
