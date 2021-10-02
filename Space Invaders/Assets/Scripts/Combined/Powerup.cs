using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup: iPoolAble
{
    private Player player = new Player();

    private bool _active;
    bool iPoolAble.active { get => _active; set => _active = value; }

    public delegate void powerDel(Enemy enemy);
    public powerDel _Pickup;

    public Powerup()
    {
        EventSystem.Subscribe(EventType.UPDATE, Update);
    }

    //todo: Move the Powerup down. 
    public void Update()
    {
        //todo: on PlayerPickup distance to player
        //todo: slowly falls to the bottom and dispears
    }

    public void Pickup()
    {

        //todo: logic for incrmental increase of powerup by one
        Bullet bullet = new PlayerBullet();
        Bullet spreadShot = new SpreadShot(bullet);
        Bullet rapidFireShot = new RapidFireShot(spreadShot);
        Bullet clusterShot = new ClusterShot(rapidFireShot);
        Bullet piercingShot = new PiercingShot(clusterShot);
        player.bullet = bullet;
    }
void iPoolAble.OnEnableObject()
    {
        EventSystem.Subscribe(EventType.UPDATE, Update);
    }

    //TODO: Hide EnemyObject
    void iPoolAble.OnDisableObject()
    {
        EventSystem.Unsubscribe(EventType.UPDATE, Update);
    }

}
