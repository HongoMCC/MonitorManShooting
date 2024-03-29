using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Threading.Tasks;

public class CubeMove : MonoBehaviour
{
    int number;
    void Update()
    {   
        //numberの値を1~3の中で調整する
        if(number == 1)
        {
            Delay();
            number = 2;
        }
        if(number == 2)
        {
            Delay();
            number = 3;
        }
        if(number == 3)
        {
            Delay();
            number = 1;
        }
    }
    static async void Delay()
    {
        await Task.Delay(500);
    } 
}