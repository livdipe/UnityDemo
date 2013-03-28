using UnityEngine;
using System.Collections;
 
public class ClassAndStruct : MonoBehaviour {
    DogC dogC = new DogC();
    DogS dogS = new DogS();

    void Update () {
        if(Input.GetKeyDown(KeyCode.Alpha1))
            Print (dogS);
        if(Input.GetKeyDown(KeyCode.Alpha2))
            Print (dogC);
        if(Input.GetKeyDown(KeyCode.Alpha3))
            print ("Struct: The dog's name is "+dogS.name +" and is "+dogS.age);
        if(Input.GetKeyDown(KeyCode.Alpha4))
            print ("Class: The dog's name is "+dogC.name +" and is "+dogC.age);

        if(Input.GetKeyDown(KeyCode.Alpha5))
            PrintRef(ref dogS );
    }

    void Print(DogS d){
        d.age = 10;
        d.name = "Rufus";
        print ("Struct:The dog's name is "+d.name +" and is "+d.age);
    }

    void Print(DogC d){
        d.age = 10;
        d.name = "Rufus";
        print ("Class:The dog's name is "+d.name +" and is "+d.age);
    }

    void PrintRef(ref DogS d) {
        d.age = 10;
        d.name = "Rufus";
        print ("Struct:The dog's name is "+d.name +" and is "+d.age);
    }
}

public class DogC{
    public string name { get; set;}
    public int age { get; set;}
}
 
public struct DogS {
    public string name;
    public int age;
}
