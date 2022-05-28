using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    // This things position (camera) should be same as cars pos.
   
   
    void Update()
    {
        transform.position = thingToFollow.transform.position + new Vector3 (0,0,-10);
    }
}
