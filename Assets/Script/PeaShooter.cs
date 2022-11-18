using PVZ.Barrage;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PVZ.Plants
{
    public class PeaShooter : MonoBehaviour
    {
        public GameObject peaBullet;
        public Transform bulletPos;
        float loopTime = 0;
        private void ShootBullet()
        {
            GameObject Temp = Instantiate(peaBullet, bulletPos);
            Temp.GetComponent<PeaBullet>().MoveDirection = Vector3.right;
            Temp.GetComponent<PeaBullet>().MoveSpeed = 123;
        }

        private void Update()
        {
            loopTime += Time.deltaTime;
            if (loopTime >= 3)
            {
                ShootBullet();
                loopTime = 0;
            }
        }
    }
}