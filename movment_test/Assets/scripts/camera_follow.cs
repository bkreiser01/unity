using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_follow : MonoBehaviour {

    public Transform c;
    public Transform player;
    public Vector3 offset;
	
	void Start()
    {
        offset = c.position;
    }
	void Update () {
        c.position = player.position + offset;
	}
}
