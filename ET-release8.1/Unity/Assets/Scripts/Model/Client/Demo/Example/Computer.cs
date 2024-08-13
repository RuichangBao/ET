namespace ET.Client
{
    ///<summary>电脑实体</summary>
    [ChildOf(typeof(ComputersComponent))]
    public class Computer : Entity, IAwake, IUpdate, IDestroy
    {
    }
}
