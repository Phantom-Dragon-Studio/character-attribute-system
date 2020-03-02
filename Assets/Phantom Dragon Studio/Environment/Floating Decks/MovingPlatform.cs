﻿using System;
using System.Collections;
using System.Collections.Generic;
using Phantom_Dragon_Studio.Environment;
using UnityEngine;
using UnityEngine.Serialization;

namespace PhantomDragonStudio.Environment
{
    public class MovingPlatform : BasePlatform, IPatrol
    {
        [SerializeField] private List<Vector3> waypoints = default;
        [SerializeField] private float minimumDistance = default;
        [SerializeField] private AnimationCurve curve = default;
        public float speed;
        public List<Vector3> Waypoints => waypoints;
        
        private Vector3 currentDestination;
        private Vector3 previousDestination;
        private Vector3 nextDestination;
        private int nextIndex;
        private bool hasOrders = false;

        private void Awake()
        {    
            //TODO Make this calculate the closest waypoint to me and continue from there.
            nextIndex = 1;
            currentDestination = waypoints[0]; 
            nextDestination = waypoints[1];
            hasOrders = true;
        }

        private void Update()
        {
            Patrol();
        }

        public void Patrol()
        {
            if(hasOrders)
                this.transform.position = Vector3.Lerp(transform.position,currentDestination, speed * curve.Evaluate(Time.deltaTime) * 100);
            
            if (Vector3.Distance(this.transform.position, currentDestination) <= minimumDistance)
            {
                nextIndex++;
                if (nextIndex >= waypoints.Count)
                    nextIndex = 0;
                currentDestination = waypoints[nextIndex];
            }
        }

        private void OnDisable()
        {
            hasOrders = false;
        }
        
        private void OnEnable()
        {
            hasOrders = true;
        }
    }
}