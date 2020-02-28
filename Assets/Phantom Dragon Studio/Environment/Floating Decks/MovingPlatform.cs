using System;
using System.Collections;
using System.Collections.Generic;
using Phantom_Dragon_Studio.Environment;
using UnityEngine;

namespace PhantomDragonStudio.Environment
{
    public class MovingPlatform : BasePlatform
    {
        [SerializeField] private List<Vector3> waypoints;
        [SerializeField] private float minimumDistance = default;
        [Range(0f, 10f)]
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
            if(hasOrders)
                this.transform.position = Vector3.Lerp(transform.position,currentDestination, speed * Time.deltaTime);
            
            if (Vector3.Distance(this.transform.position, currentDestination) <= minimumDistance)
            {
                nextIndex++;
                if (nextIndex >= waypoints.Count)
                    nextIndex = 0;
                currentDestination = waypoints[nextIndex];
            }
        }
    }
}