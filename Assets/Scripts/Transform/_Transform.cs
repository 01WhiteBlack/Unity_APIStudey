using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Transform : MonoBehaviour
{
    private void Awake()
    {
        #region transform属性 
        //层级关系
        //Debug.Log(transform.parent);//父对象的变换  没有父对象返回Null
        //Debug.Log(transform.root);//当前层级的根节点 没有根节点返回自己 (永远不为空)
        //Debug.Log(transform.childCount);//父对象第一层级的数量

        //Debug.Log(transform.hasChanged);
        //Debug.Log(transform.hierarchyCapacity);//层级数据结构的容量 
        //Debug.Log(transform.hierarchyCount);//层级数据结构中变换的数量

        //位置变换
        //Transform 组件中显示的Position 是相对于父对象的位置
        //没有父对象的时候 Position显示的数值和 transform.position、transform.localPosition一致
        //有父对象的时候 Position显示的数值和 transform.localPosition 一致
        //Debug.Log(transform.position);//世界空间中变换的位置变换
        //Debug.Log(transform.localPosition);//相对于父对象本地坐标系中的位置

        //旋转变换
        //Transform 组件中显示的Rotation 是相对于父对象的旋转变换
        //没有父对象的时候 Rotation显示的数值和 transform.rotation.eulerAngles、transform.localRotation.eulerAngles一致
        //有父对象的时候 Rotation显示的数值和 transform.localRotation.eulerAngles一致

        //Transform.rotation 小于 180 度 Transform.rotation 没有万向锁
        //Debug.Log(transform.rotation.eulerAngles);//一个 Quaternion，用于存储变换在世界空间中的旋转
        //Debug.Log(transform.localRotation.eulerAngles);//相对于父级变换旋转的 变换旋转
        //Debug.Log(transform.eulerAngles);//以欧拉角表示的旋转（以度为单位）。
        //Debug.Log(transform.localEulerAngles);//以欧拉角表示的相对于父变换旋转的旋转（以度为单位）

        //缩放变换
        //Transform 组件中显示的Scale 是相对于父对象的缩放变换
        //没有父对象的时候 Scale显示的数值和 transform.lossyScale、transform.localScale一致
        //有父对象的时候 Scale显示的数值和 transform.localScale一致
        //Debug.Log(transform.lossyScale);//对象的全局缩放
        //Debug.Log(transform.localScale);//相对于 GameObjects 父对象的变换缩放

        //本地坐标系在世界坐标系中的表示
        //Debug.Log(transform.forward); //本地坐标系的z轴在世界坐标系中的表示(单位化) 
        //Debug.Log(transform.right); //本地坐标系的X轴在世界坐标系中的表示(单位化) 
        //Debug.Log(transform.up); //本地坐标系的Y轴在世界坐标系中的表示(单位化) 

        //变换矩阵
        //Debug.Log(transform.worldToLocalMatrix);//将点从世界空间转换到本地空间的矩阵（只读）
        //Debug.Log(transform.localToWorldMatrix);//将点从本地空间转换到世界空间的矩阵（只读）。

        #endregion
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log(transform.hasChanged);
            //transform.Rotate(Vector3.up,5f,Space.Self);
            //Debug.Log(transform.hasChanged);
        }
    }
}
