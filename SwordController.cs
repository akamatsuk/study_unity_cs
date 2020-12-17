using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordController : MonoBehaviour{
    public GameObject ParticlePrefabs;
    public GameObject cubePrefabs;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BOX")
        {
            GameObject particle = Instantiate(ParticlePrefabs) as GameObject;
            Vector3 hitPos = this.transform.position;
            Debug.Log("hitPos="  + hitPos);
            particle.transform.position = hitPos;
            Destroy(cubePrefabs);
        }
    }
}
