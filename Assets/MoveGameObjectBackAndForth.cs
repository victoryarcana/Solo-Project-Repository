﻿using UnityEngine;

public class MoveGameObjectBackAndForth : MonoBehaviour
{
    // How fast the object should move
    private float _speed = 3;

    // How far the object will travel before turning around
    private float _distance = 3;

    // save the starting position of the object here so we can calculate how far it has traveled
    private Vector3 _startingPos;
    
    // The current direction the object is moving in.
    // 1 = forward
    // -1 = backwards
    private int _travelDirection = 1;
    
    
    private void Start()
    {
        // Save the starting position of the game object. This allows us to use whatever position is set
        // in the unity editor and calculate distance from that point without hard coding any position
        // values in the script
        _startingPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the amount the object should move this frame
        Vector3 amountToMoveThisFrame = (Vector3.right * _speed) * Time.deltaTime;
        
        // check what direction the object should be moving in and flip the amountToMoveThisFrame based on the current direction
        amountToMoveThisFrame = amountToMoveThisFrame * _travelDirection;

        // Actually set the position of this object to its new position
        transform.position += amountToMoveThisFrame;

        // check if the object has reached its target travel distance
        if (Vector3.Distance(_startingPos, transform.position) >= _distance)
        {
            // if it did reach its distance then flip the _travelDirection so it knows to move 
            // the other direction.
            _travelDirection = _travelDirection * -1;
        }
    }
}
