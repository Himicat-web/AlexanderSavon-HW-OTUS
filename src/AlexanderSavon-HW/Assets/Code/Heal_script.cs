using UnityEngine;

public class Heal_script : MonoBehaviour
{


    void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag ("Player"))
            {
                
                Destroy(gameObject);
            }
        }
}
