using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGun : Weapon
{
    [SerializeField] private float _distanceBetweenBullets;

    public override void Shoot(Transform shootPoint)
    {
        Instantiate(Bullet, shootPoint.position, Quaternion.identity);
        Instantiate(Bullet, new Vector2(shootPoint.position.x, shootPoint.position.y + _distanceBetweenBullets), Quaternion.identity);
        Instantiate(Bullet, new Vector2(shootPoint.position.x, shootPoint.position.y - _distanceBetweenBullets), Quaternion.identity);
    }
}
