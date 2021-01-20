using UnityEngine;

namespace GeekbrainsStudy
{
    internal static class ResourcesLoader
    {
        internal static T GetData<T>(string root, string name) where T : ScriptableObject
        {
            var path = $"{root}/{name}";
            T data = Resources.Load<T>(path);
            return data;
        }
        internal static GameObject GetPrefab(string root, string name)
        {
            var path = $"{root}/{name}";
            var prefab = Resources.Load<GameObject>(path);
            return prefab;
        }
    }
}
