using DiConsoleApp;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;

namespace DiConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // サービスコレクションを生成
            var collection = new ServiceCollection();

            // サービスコレクションにクラスと生成方法を登録
            // AddSingleton(): 最初にサービスコンテナから要求されたタイミングでインスタンスを生成
            // AddScoped(): クライアントから接続されたタイミングでインスタンスを生成
            // AddTransient(): サービスコンテナから要求されたタイミングでインスタンスを生成
            collection.AddTransient<IMyService, MyService>();

            // サービスプロバイダから型(IMyService)に対応するインスタンスを取得
            var provider = collection.BuildServiceProvider();
            var myService = provider.GetRequiredService<IMyService>();

            // メソッドを実行
            myService.getValue();
        }
    }
}
