using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PVZ.Barrage
{
    public class PeaBullet : Barrages
    {
        public void Move()
        {
            this.transform.position += MoveDirection * MoveSpeed * Time.deltaTime;
        }

        private void FixedUpdate()
        {
            Move();
        }
    }
}