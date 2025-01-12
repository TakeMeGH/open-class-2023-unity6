using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
    }
    
    private void Movement()
    {
        // TODO : Implementasikan fungsi untuk pergerakan player

    }
    
    bool OnGround() {
        // TODO : Implementasikan fungsi untuk mendeteksi apakah player sedang berada pada ground
        return true;
    }
}
