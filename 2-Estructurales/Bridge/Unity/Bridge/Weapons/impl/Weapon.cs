using UnityEngine;
public abstract class Weapon : IMeleWeapon
{
    protected int power;
    protected bool enable;
    protected bool afilada;

    public void afilar()
    {
        if (!this.afilada)
        {
            this.power++;
            this.afilada = true;
            Debug.Log("Afilar");
        }
        else
        {
            Debug.Log("No se puede afilar, el arma ya se encuentra afilada");
        }
    }

    public void atacar()
    {
        if (this.enable)
        {
            Debug.Log("Atacar");
        }
        else
        {
            Debug.Log("No puede atacar");
        }

    }

    public void desenfundar()
    {
        if (!this.enable)
        {
            this.enable = true;
            Debug.Log("desenfundar");
        }else
        {
            Debug.Log("No se puede desenfundar");
        }
    }

    public void enfundar()
    {
        if (this.enable)
        {
            this.enable = false;
            Debug.Log("Enfundar");
        }else
        {
            Debug.Log("No se puede enfundar");
        }
    }
}