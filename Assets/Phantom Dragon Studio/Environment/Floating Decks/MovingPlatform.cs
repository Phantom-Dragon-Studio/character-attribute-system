using System;
using System.Collections;
using System.Collections.Generic;
using Phantom_Dragon_Studio.Environment;
using UnityEngine;

namespace PhantomDragonStudio.Environment
{
    public class MovingPlatform : BasePlatform, IMoveable, IPatrol
    {
        [SerializeField] private List<Vector3> waypoints;
        [SerializeField] private float minimumDistance = default;
        public float speed;
        public List<Vector3> Waypoints => waypoints;
        private Vector3 currentDestination;
        private Vector3 previousDestination;
        private Vector3 nextDestination;
        private int nextIndex;
        private bool hasOrders = false;
        private IEnumerator executeOrders;
        private WaitUntil waitUntilTrue;

        private void Awake()
        {    
            //TODO Make this calculate the closest waypoint to me and continue from there.
            waitUntilTrue = new WaitUntil(ReadyForNewOrders);
            executeOrders = ExecuteOrders();
            nextIndex = 0;
            currentDestination = waypoints[0]; 
            nextDestination = waypoints[1];
            StartCoroutine(executeOrders);
        }

        public void OverrideOrders(Vector3 destination)
        {
            hasOrders = true;
            MoveTo(destination);
        }

        public void Patrol()
        {
            if (hasOrders) return;
            hasOrders = true;
            for (int i = 0; i < waypoints.Count; i++)
            {
                Debug.Log("Patrolling....");
                previousDestination = currentDestination;
                currentDestination = nextDestination;

                nextIndex = i+1;
                if (nextIndex == waypoints.Count)
                    nextIndex = 0;    
                nextDestination = waypoints[nextIndex];
            }
        }
        
        public void MoveTo(Vector3 destination)
        {
            Debug.Log("Moving....");
            hasOrders = true;
            gameObject.transform.position = Vector3.Lerp(transform.position,destination, speed * Time.deltaTime);
        }

        public void MoveInstant(Vector3 destination)
        {
            this.gameObject.transform.position = destination;
        }

        public bool ReadyForNewOrders()
        {
            Debug.Log("Checking...");
            if (!(Vector3.Distance(this.transform.position, currentDestination) <= minimumDistance)) 
                return false;
            
            hasOrders = false;
            return true;
        }
        
        private IEnumerator ExecuteOrders()
        {
            Debug.Log("Coroutine Tick"); 
            yield return waitUntilTrue;
            MoveTo(Waypoints[nextIndex]);
            Debug.Log("Coroutine Wait Completed.");
        }

        private void FixedUpdate()
        {
            ReadyForNewOrders();
        }
    }
}