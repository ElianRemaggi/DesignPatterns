using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public IMeleWeapon weapon;

   
    void Start()
    {
        this.weapon = new Sword();
        weapon.desenfundar();
        weapon.afilar();
        weapon.atacar();
        weapon.afilar();
        weapon.enfundar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void atacar()
    {
        weapon.atacar();
    }

    public void combatReady()
    {
        weapon.desenfundar();
    }

    public void idle()
    {
        weapon.enfundar();
    }

    public void reparar()
    {
        weapon.afilar();
    }
}
