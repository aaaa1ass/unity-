using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    public int hp = 5;
    
    
    public void Damaged(int damage)
    {
        hp -= damage;
    }
}
