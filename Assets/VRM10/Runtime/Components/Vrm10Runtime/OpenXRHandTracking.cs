using System.Collections.Generic;
using UnityEngine;

namespace UniVRM10
{
    /// <summary>
    /// TPose のときに XR_EXT_hand_tracking の joint が向いている向きを定義する。
    /// 
    /// https://registry.khronos.org/OpenXR/specs/1.0/html/xrspec.html#_conventions_of_hand_joints
    /// 
    /// Unityは左手系なので、X軸を反転させます。
    /// </summary>
    public static class OpenXRHandTracking
    {
        public static Quaternion GetRotation(Vector3 up, Vector3 forward)
        {
            var xAxis = Vector3.Cross(up, forward).normalized;
            var m = new Matrix4x4(xAxis, up, forward, new Vector4(0, 0, 0, 1));
            return m.rotation;
        }

        public static Quaternion LeftHand = GetRotation(Vector3.up, Vector3.right);
        public static Quaternion LeftThumb = GetRotation(Vector3.up, (Vector3.right + Vector3.forward).normalized);
        public static Quaternion RightHand = GetRotation(Vector3.up, Vector3.left);
        public static Quaternion RightThumb = GetRotation(Vector3.up, (Vector3.left + Vector3.forward).normalized);

        public static readonly Dictionary<HumanBodyBones, Quaternion> InitialRotations = new Dictionary<HumanBodyBones, Quaternion>()
        {
            // Left
            // {HumanBodyBones.LeftHand, LeftHand},
            // {HumanBodyBones.LeftThumbProximal, LeftThumb},
            // {HumanBodyBones.LeftThumbIntermediate, LeftThumb},
            // {HumanBodyBones.LeftThumbDistal, LeftThumb},
            {HumanBodyBones.LeftIndexProximal, LeftHand},
            {HumanBodyBones.LeftIndexIntermediate, LeftHand},
            {HumanBodyBones.LeftIndexDistal, LeftHand},
            // {HumanBodyBones.LeftMiddleProximal, LeftHand},
            // {HumanBodyBones.LeftMiddleIntermediate, LeftHand},
            // {HumanBodyBones.LeftMiddleDistal, LeftHand},
            // {HumanBodyBones.LeftRingProximal, LeftHand},
            // {HumanBodyBones.LeftRingIntermediate, LeftHand},
            // {HumanBodyBones.LeftRingDistal, LeftHand},
            // {HumanBodyBones.LeftLittleProximal, LeftHand},
            // {HumanBodyBones.LeftLittleIntermediate, LeftHand},
            // {HumanBodyBones.LeftLittleDistal, LeftHand},
            // Right
            // {HumanBodyBones.RightHand, RightHand},
            // {HumanBodyBones.RightThumbProximal, RightThumb},
            // {HumanBodyBones.RightThumbIntermediate, RightThumb},
            // {HumanBodyBones.RightThumbDistal, RightThumb},
            // {HumanBodyBones.RightIndexProximal, RightHand},
            // {HumanBodyBones.RightIndexIntermediate, RightHand},
            // {HumanBodyBones.RightIndexDistal, RightHand},
            // {HumanBodyBones.RightMiddleProximal, RightHand},
            // {HumanBodyBones.RightMiddleIntermediate, RightHand},
            // {HumanBodyBones.RightMiddleDistal, RightHand},
            // {HumanBodyBones.RightRingProximal, RightHand},
            // {HumanBodyBones.RightRingIntermediate, RightHand},
            // {HumanBodyBones.RightRingDistal, RightHand},
            // {HumanBodyBones.RightLittleProximal, RightHand},
            // {HumanBodyBones.RightLittleIntermediate, RightHand},
            // {HumanBodyBones.RightLittleDistal, RightHand},
       };
    }
}