using UnityEngine;
using System.Collections;
using System.Collections.Generic;


/** 
 *  Just attach to see it work
 */
public class Coroutines : MonoBehaviour {


    Sprite a;
    Sprite b;
    Sprite c;
    Sprite d;
    Sprite e;

    int ii = 0;

    void Start () {

        

    }
    IEnumerator ee = BackAndForth();
    void Update() {;

        object o = ee.Current;
        ee.MoveNext();
        

        //sdfjkl
        //sdfjkl
        //sdfjkl
        //sdfjkl
        //sdfjkl
    }

    static IEnumerator BackAndForth()
    {
        while(true)
        {
            print("Hey"); yield return null;
            print("Listen"); yield return null;
        }
    }

    //
    IEnumerator Script () {
        int i = 0;
        Debug.Log("Pos " + i++);
        yield return 0;
        Debug.Log("Pos " + i++);

        //    //change color
        yield return 0;
        Debug.Log("Pos " + i++);

        //    //turn
        yield return new WaitForSeconds(2);
        Debug.Log("Pos " + i++);

        //forward
        yield return 0;
        Debug.Log("Pos " + i++);

        //    //if color flag = true 
        yield return 0;
        Debug.Log("Pos " + i++);

        //
        //
        yield return new Donut();
    }
}
