using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDelete : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z >157)
        {
            Destroy(gameObject);
        }
    }
}
