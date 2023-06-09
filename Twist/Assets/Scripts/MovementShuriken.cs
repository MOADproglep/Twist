﻿using UnityEngine;

namespace Assets.Scripts
{
    public class MovementShuriken : MonoBehaviour
    {
        public Transform[] points;
        public float forwardSpeed;
        public float speed;

        private int _nextPointIndex;
        private Transform _nextPoint;


        private void Start()
        {
            _nextPoint = points[0];
        }
        private void FixedUpdate()
        {
            transform.Rotate(0, 0, forwardSpeed);

            if (transform.position == _nextPoint.position)
            {
                _nextPointIndex++;
                if( _nextPointIndex >= points.Length )
                {
                    _nextPointIndex = 0;
                }
                _nextPoint = points[ _nextPointIndex ];
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, _nextPoint.position, speed * Time.deltaTime);
            }
        }
    }
}
