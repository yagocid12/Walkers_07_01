using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

/// <summary>
/// //////////////////////////////////////////////////////////////////////////////////////
/// ///////////  ARTIFICIAL INTELLIGENCE  player Script 
/// Author : 	Miguel Angel Fernandez Graciani
/// Date :	2021-02-07
/// Observations :
///     - THIS IS AN ARTIFICIAL INTELLIGENT SCRIPT
///     - You must call to the "public void moveOn(Vector3 directionForce, float movUnits)" in "ScPlayerControl" to move the player 
///     - You must Change it to define the artiicial intelligence of this player
/// </summary>
public class ScPlayerAI_Near : MonoBehaviour {
    protected Vector3 movement;  // Direction of the force that will be exerted on the gameobject
    protected float minionsMovUnits = 25;  //  Amount of force that will be exerted on the gameobject

    public Rigidbody rb;
    private Transform target;

    // Use this for initialization
    /// <summary>
    /// ///////////  ARTIFICIAL INTELLIGENCE  MINION Script 
    /// Author : 	
    /// Date :	
    /// Observations :
    /// </summary>



    void Start()
    {
        target = GameObject.FindWithTag("Profit").transform;
        rb = GetComponent<Rigidbody>();

    }  // FIn de - void Start()


    /// <summary>
    /// //////////////////////////////////////////////////////////////////////////////////////
    /// ///////////  FixedUpdate()
    /// Author : 	Miguel Angel Fernandez Graciani
    /// Date :	2021-02-07
    /// Observations :
    ///     - THIS IS AN ARTIFICIAL INTELLIGENT SCRIPT
    ///     - You must Change it to define the artiicial intelligence of this player
    ///     - This one is only an example to manage the player
    /// </summary>
    void FixedUpdate()
    {

        movement = Vector3.Normalize(target.position - transform.position).normalized;
        transform.position += movement * minionsMovUnits * Time.deltaTime;
    }  // Fin de - void FixedUpdate()



}  // Fin de - public class ScPlayerAI_Near : MonoBehaviour {
