using NX.DependencyInjection;
using System.Diagnostics;

namespace DiSample.Daos.Impl
{

    [Dao(Scope = ComponentScope.Singleton, TargetType = typeof(IDiDao))]
    public class DiDaoImpl : IDiDao
    {
        public string Get()
        {
            // 実行確認
            Debug.Print("Run DiDaoImpl");

            // ダミー実装
            return "DaoImpl:Get()";
        }
    }
}
