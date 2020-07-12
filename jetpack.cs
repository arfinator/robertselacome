using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class jetpack : MonoBehaviour {

    public float speed = 1;
    CharacterController character;


    public void FixedUpdate() {

        character = GameObject.FindGameObjectWithTag("VR Rig").GetComponentInChildren<CharacterController>();

        Vector3 direction = new Vector3(0.0f, 5.0f, 0.0f);

    }
}