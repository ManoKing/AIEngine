using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.AddressableAssets;
//using UnityEngine.ResourceManagement.AsyncOperations;
public class UIHome : MonoBehaviour
{
    public Button ret;
    void Start()
    {
        ret.onClick.AddListener(()=> {
            Load();
        });
    }

    void Load()
    {
        //Addressables.LoadAssetAsync<GameObject>("Res/Content").Completed +=
        //    (op) =>
        //    {
        //        if (op.Status == AsyncOperationStatus.Succeeded)
        //        {
        //            Debug.Log(op.Result as GameObject);
        //            var go = Instantiate(op.Result as GameObject, Vector3.zero, Quaternion.identity, transform);
        //            go.transform.localPosition = Vector3.zero;
        //        }
        //    };
    }
}
