using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombEffectScript : MonoBehaviour
{
    public GameObject bomb;
    //public Rigidbody bombRigid;
    //public GameObject floor;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("createBomb", 2f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void createBomb()
    {
        Instantiate(bomb,new Vector3(0,10,0),Quaternion.identity);

    }
    public void OnCollisionEnter(Collision collision)
    {
        
            Destroy(collision.gameObject);
        
    }
}
