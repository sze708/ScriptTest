using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        //要素数5の配列arrayを初期化
        int[] points = new int[5];
        //配列の各要素に値を代入
        //配列は0から始まる
        points[0] = 1;
        points[1] = 2;
        points[2] = 3;
        points[3] = 4;
        points[4] = 5;

        //配列要素を昇順で表示
        for (int i = 0; i <points.Length; i++)
        {
            Debug.Log(points[i]);
        }
        //配列要素を降順で表示
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(points[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {
     
    }
}