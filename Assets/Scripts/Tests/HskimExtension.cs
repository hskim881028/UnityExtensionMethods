using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class HskimExtension {
    public static Transform SetPositionX(this Transform transform, float x) {
        Vector3 position = transform.position;
        position.x = x;
        transform.position = position;
        return transform;
    }
    public static Transform SetPositionY(this Transform transform, float y) {
        Vector3 position = transform.position;
        position.y = y;
        transform.position = position;
        return transform;
    }
    public static Transform SetPositionZ(this Transform transform, float z) {
        Vector3 position = transform.position;
        position.z = z;
        transform.position = position;
        return transform;
    }

    public static Transform SetLocalScaleX(this Transform transform, float x) {
        Vector3 scale = transform.localScale;
        scale.x = x;
        transform.localScale = scale;
        return transform;
    }
    public static Transform SetLocalScaleY(this Transform transform, float y) {
        Vector3 scale = transform.localScale;
        scale.x = y;
        transform.localScale = scale;
        return transform;
    }
    public static Transform SetLocalScaleZ(this Transform transform, float z) {
        Vector3 scale = transform.localScale;
        scale.x = z;
        transform.localScale = scale;
        return transform;
    }

    public static Rigidbody Freeze (this Rigidbody rigidbody) {
        rigidbody.velocity = Vector3.zero;
        rigidbody.angularVelocity = Vector3.zero;
        rigidbody.isKinematic = true;
        return rigidbody;
    }
    public static Rigidbody2D Freeze (this Rigidbody2D rigidbody) {
        rigidbody.velocity = Vector2.zero;
        rigidbody.angularVelocity = 0;
        rigidbody.isKinematic = true;
        return rigidbody;
    }
}