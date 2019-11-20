using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombScript : MonoBehaviour
{
    public Rigidbody bombRigid;
    public GameObject explotionParticles;
    // Start is called before the first frame update
    void Start()
    {
        float randomX = UnityEngine.Random.Range(10f, 100f);
        float randomY = UnityEngine.Random.Range(10f, 100f);
        float randomZ = UnityEngine.Random.Range(10f, 100f);

        bombRigid = GetComponent<Rigidbody>();
        bombRigid.AddTorque(randomX, randomY, randomZ);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collsion)
    {
        //if (explotionParticles)
        //{
          Instantiate(explotionParticles, transform.position, transform.rotation);
          //Destroy(explotionParticles);
        //}
        
    }
}
