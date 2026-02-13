using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] float destroyDelay = 0.3f;
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Package") && !hasPackage)
        {
            Debug.Log("Package picked up!");
            hasPackage = true;
            GetComponent<ParticleSystem>().Play();
            Destroy(collision.gameObject, destroyDelay);
        }

        if (collision.gameObject.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("Package delivered!");
            hasPackage = false;
            GetComponent<ParticleSystem>().Stop();
            Destroy(collision.gameObject, destroyDelay);
        }
    }
}
