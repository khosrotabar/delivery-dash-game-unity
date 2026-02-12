using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Package"))
        {
            Debug.Log("Package picked up!");
        }

        if (collision.gameObject.CompareTag("Customer"))
        {
            Debug.Log("Package delivered!");
        }
    }
}
