﻿using UnityEngine;
using System;
using System.Collections.Generic;
using uMVVMCS;
using uMVVMCS.DIContainer;

public class NewBehaviourScript : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        print(typeof(a.aa).Namespace == typeof(a.b.ab).Namespace);
        print(typeof(a.aa).Namespace);
        print(typeof(a.b.ab).Namespace);

    }

    // Update is called once per frame
    void Update () {
	
	}


}

public interface p {  }
public class ren : p { public int age; public string name; }
public class ren1 : ren {  }
public class ren2 : ren {  }

public static class renKZ
{
    public static void printAge(this ren r) { UnityEngine.Debug.Log(r.age); }
}

public class someClass : IInjectionFactory, IComparable<someClass>
{
    public int id;
    public object Create(InjectionInfo context) { return this; }

    #region IComparable implementation 

    public int CompareTo(someClass other)
    {
        if (other == null) { return 1; }
        else { return -id.CompareTo(other.id); }
    }

    #endregion
}

public class someClass_b : someClass { }

public class someClass_c : someClass { }

namespace a { public class aa { } }

namespace a.b { public class ab { } }



