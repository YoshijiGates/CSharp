using DiSample.Logics;
using NX.DependencyInjection;
using System.Diagnostics;

namespace DiSample.Services.Impl
{
    [Service(Scope = ComponentScope.Singleton, TargetType = typeof(IDiService))]
    public class DiServiceImpl : IDiService
    {
        private readonly DiLogic _diLogic;

        // コンストラクタ
        public DiServiceImpl(DiLogic diLogic)
        {
            _diLogic = diLogic;

        }

        public string Get()
        {
            // 実行確認
            Debug.Print("Run DiServiceImpl");

            return _diLogic.Get();
        }
    }
}
