using JsonFileIO.Jsons;
using Newtonsoft.Json;
using System.Diagnostics;
using System.IO;

namespace JsonFileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonJson person = new PersonJson();

            // データを設定
            person.Name = "YoshijiGate";
            person.Age = 27;
            person.Height = 190.5;

            // 1. JSON データにシリアライズ
            // --------------------------------
            var jsonWriteData = JsonConvert.SerializeObject(person);

            // C:¥work¥PersonJson.json.json を UTF-8 で書き込み用でオープン
            using (var sw = new StreamWriter(@"C:\work\PersonJson.json", false, System.Text.Encoding.UTF8))
            {
                // JSON データをファイルに書き込み
                sw.Write(jsonWriteData);
            }

            // 2. JSON データにデシリアライズ
            // --------------------------------
            // C:¥work¥test.json を UTF-8 で開く
            using (var sr = new StreamReader(@"C:\work\test.json", System.Text.Encoding.UTF8))
            {
                // 変数 jsonReadData にファイルの内容を代入 
                var jsonReadData = sr.ReadToEnd();

                // デシリアライズして person にセット
                person = JsonConvert.DeserializeObject<PersonJson>(jsonReadData);
            }

            // デバッグで確認
            Debug.WriteLine(person.Name);
            Debug.WriteLine(person.Age);
            Debug.WriteLine(person.Height);
        }
    }
}
