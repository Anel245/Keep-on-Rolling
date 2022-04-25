using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISaveable 
{
    object SaveState();
    void LoadState(object state);
}
