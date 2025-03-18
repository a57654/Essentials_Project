using UnityEngine;

public class Collectible : MonoBehaviour
{

    public float rotationSpeed;
    public GameObject OnCollectEffect;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(0, rotationSpeed, 0);
        
    }

    private void OnTriggerEnter(Collider other) {

        // Destroy the collectable
        Destroy(gameObject);

        // Instanciar o nosso Efeito
        Instantiate(OnCollectEffect, transform.position, transform.rotation);

    }
}
