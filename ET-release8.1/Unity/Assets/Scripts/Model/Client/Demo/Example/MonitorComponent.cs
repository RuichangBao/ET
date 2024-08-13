

namespace ET.Client
{
    ///<summary>显示器实体</summary>
    [ComponentOf(typeof(Computer))]
    public class MonitorComponent : Entity, IAwake<int>,IDestroy
    {
        public int Brightness;//亮度

    }
}
