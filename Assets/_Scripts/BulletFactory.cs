using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFactory : MonoBehaviour
{
    [Header("Bullet Types")]
    public GameObject Bullet;
    public GameObject BulletFat;
    public GameObject PulsingBullet;

    public BulletManager bulletManager;
    // Start is called before the first frame update
 

    public GameObject createBullet(BulletType type = BulletType.RANDOM)
    {
        if (type == BulletType.RANDOM)
        {


            var randomBullet = Random.Range(0, 3);
            type = (BulletType)randomBullet;
        }

        GameObject tempBullet = null;
        switch (type)
        {
            
            case BulletType.BULLET:
               tempBullet = Instantiate(Bullet);
                tempBullet.GetComponent<BulletController>().damage = 10;
                break;
            case BulletType.BULLETFAT:
                tempBullet = Instantiate(BulletFat);
                tempBullet.GetComponent<BulletController>().damage = 20;
                break;
            case BulletType.PULSINGBULLET:
                tempBullet = Instantiate(PulsingBullet);
                tempBullet.GetComponent<BulletController>().damage = 30;
                break;
            
        }

        tempBullet.transform.parent = transform;
        tempBullet.SetActive(false);
        return tempBullet;
    }
}
