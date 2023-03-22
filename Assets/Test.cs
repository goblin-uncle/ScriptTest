using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //配列を初期化する
        int[] array = new int[5];

        //配列の各要素に値を代入する。
        array[0] = 10;
        array[1] = 20;
        array[2] = 40;
        array[3] = 70;
        array[4] = 90;
        

        //配列の要素を全て表示する
        for(int a = 0; a<5; a++)
        {
            Debug.Log(array[a]);
        }
        //配列の要素を全て逆順に表示する
        for(int b = 4; b>=0; b--)
        {
            Debug.Log(array[b]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
