using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderUpdate : MonoBehaviour
{
    [SerializeField] private Rigidbody body;
    [SerializeField] private string velocityName = "_Velocity";

    void Update()
    {
        if (body == null)
        {
            return;
        }

        Shader.SetGlobalFloat(velocityName, body.velocity.magnitude);
    }
}
