using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography.Xml;
using System.Text;
using WebAPITest.Models;
using static System.Windows.Forms.Design.AxImporter;

namespace WebAPITest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = @"https://localhost:7097/api/Books";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var uri = new Uri(textBox1.Text);

            using (var client = new HttpClient())
            {

                // Postの場合は、JSONをシリアライズする
                // var book = new Book()
                // {
                //    id = 1,
                //    title = "Title",
                //    price = 101,
                //    page = 1001,
                // };
                // 
                // var json = JsonConvert.SerializeObject(book);
                // var content = new StringContent(json, Encoding.UTF8, "application/json");
                // var httpsResponse = await client.PostAsync(uri,content);

                // WebAPIをGETで呼び出す
                var httpsResponse = await client.GetAsync(uri);

                // WebAPIの返却値を取得する
                // ヘッダー
                richTextBox1.Text = httpsResponse.Headers.ToString();
                // ステータスコード
                richTextBox1.Text = richTextBox1.Text + "\r\n" + httpsResponse.StatusCode;

                // JSON結果（N件)
                var json = await httpsResponse.Content.ReadAsStringAsync();
                var books = JsonConvert.DeserializeObject<List<Book>>(json);
                foreach (Book book in books)
                {
                    richTextBox1.Text = richTextBox1.Text + "\r\n" + book.ToString();
                }
            }
        }
    }
}