using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Web;

namespace 专治骗子
{
    public class BomberPerformer {
        private int mSuccessCount = 0;
        private int mThreadCount = 16;
        public int ThreadCount {
            get { return mThreadCount; }
            set { mThreadCount = value; }
        }
        public int SuccessCount {
            get {
                return mSuccessCount;
            }
        }
        private IBomber mBomber;
        private bool isStarted = false;
        private List<Thread> BomberThreads = new List<Thread>();
        public BomberPerformer(IBomber bomber) {
            mBomber = bomber;
        }
        public void StartBomber() {
            new Thread(mStartBomber).Start();
        }
        private void mStartBomber() {
            isStarted = true;
            while (BomberThreads.Count < mThreadCount)
            {
                Thread t = new Thread(run);
                Thread.Sleep(100);
                BomberThreads.Add(t);
                t.Start();
            }
        }
        public void StopBomber() {
            isStarted = false;
            BomberThreads.Clear();
        }
        private void run() {
            while (isStarted) {
                if (mBomber.perform()) {
                    mSuccessCount++;
                }
            }
        }
    }
    public static class BomberUtils
    {

        public static string useragent = "Mozilla/5.0 (Linux; Android 9; PH-1 Build/PPR1.180610.091; wv) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/66.0.3359.126 MQQBrowser/6.2 TBS/044807 Mobile Safari/537.36 V1_AND_SQ_8.0.8_1218_YYB_D QQ/8.0.8.4115 NetType/WIFI WebP/0.3.0 Pixel/1312 StatusBarHeight/151";

        public static event EventHandler<HttpRequestCreatedEventArgs> BeforeRequestSend;
        public static long GetTimestamp()
        {
            TimeSpan ts = DateTime.Now.ToUniversalTime() - new DateTime(1970, 1, 1);
            return (long)ts.TotalMilliseconds;
        }
        public static string DictionaryToHttpKeyValue(Dictionary<string, string> dic) {
            StringBuilder builder = new StringBuilder();
            int i = 0;
            foreach (var item in dic)
            {
                if (i > 0)
                    builder.Append("&");
                builder.AppendFormat("{0}={1}", item.Key, item.Value);
                i++;
            }
            return builder.ToString();
        }
        public static HttpWebRequest MakeHttpRequest(string url, string httpKeyValue, string method) {
            if (method == "GET") {
                return MakeHttpGet(url, httpKeyValue);
            }
            return MakeHttpPost(url, httpKeyValue);
        }
        public static HttpWebRequest MakeHttpGet(string url, string httpKeyValue)
        {
            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url + "?" + httpKeyValue);
            req.Timeout = 5000;
            req.Method = "GET";
            req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";
            req.UserAgent = useragent;
            req.Headers.Add("Accept-Language", "zh,zh-CN;q=0.9;q=0.9");
            //req.Connection = "Keep-Alive";
            req.AllowAutoRedirect = false;
            if (null != BeforeRequestSend)
            {
                BeforeRequestSend.Invoke(req, new HttpRequestCreatedEventArgs(req));
            }
            return req;
        }
        public static HttpWebRequest MakeHttpPost(string url, string httpKeyValue)
        {
            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Timeout = 5000;
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";
            req.UserAgent = useragent;
            req.Headers.Add("Accept-Language", "zh,zh-CN;q=0.9;q=0.9");
            //req.Connection = "Keep-Alive";
            byte[] data = Encoding.UTF8.GetBytes(httpKeyValue);
            req.ContentLength = data.Length;
            req.AllowAutoRedirect = false;
            if (null != BeforeRequestSend) {
                BeforeRequestSend.Invoke(req, new HttpRequestCreatedEventArgs(req));
            }
            using (Stream reqStream = req.GetRequestStream())
            {
                reqStream.Write(data, 0, data.Length);
                reqStream.Close();
            }
            return req;
        }
        public static string GetHttpResponse(HttpWebRequest req) {
            string result = "";
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            return "["+resp.StatusCode.ToString()+"] " + result;
        }
        public static string GenerateRandomSequence(string charpool, int minlen, int maxlen)
        {
            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();
            int len = minlen + (rnd.Next() % (maxlen - minlen + 1));
            for (int i = 0; i < len; i++)
            {
                sb.Append(charpool[rnd.Next() % charpool.Length]);
            }
            return sb.ToString();
        }
        public static string RandomQQNumber() {
            return GenerateRandomSequence("1234567890", 7, 10);
        }
        public static string RandomPassword() {
            return GenerateRandomSequence("1234567890qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM！@#￥%……&*()_+-=[];',./<>?:\"{}\\`~", 6, 12);
        }
        public static string Base64Encode(string input) {
            return Base64Encode(input, Encoding.Default);
        }
        public static string Base64Encode(string input, Encoding encoding) {
            return Convert.ToBase64String(encoding.GetBytes(input));
        }
        private static object syncobj = new object();
        public static void PrintResult(string user, string pass, string result)
        {
            lock (syncobj)
            {
                Console.WriteLine("USER=" + user);
                Console.WriteLine("PASS=" + pass);
                Console.WriteLine("Result: " + result);
                Console.WriteLine("-------------------------------------------");
            }
        }
        public static void startColorfulEffect()
        {
            System.Threading.Thread.Sleep(5000);
            while (true)
            {
                System.Threading.Thread.Sleep(333);
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Clear();
                System.Threading.Thread.Sleep(333);
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Clear();
                System.Threading.Thread.Sleep(333);
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Clear();
                System.Threading.Thread.Sleep(333);
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.Clear();
            }
        }
        public static string UrlEncode(string raw) { return HttpUtility.UrlEncode(raw); }
    }
    public class HttpRequestCreatedEventArgs : EventArgs
    {
        private HttpWebRequest request;
        public HttpWebRequest Request { get { return request; } }
        public HttpRequestCreatedEventArgs(HttpWebRequest req) { this.request = req; }
    }
    public interface IBomber {
        event EventHandler<BomberResultEventArgs> OnBomberComplete;
        bool perform();
    }
    public class GeneralBomber : IBomber
    {
        public event EventHandler<BomberResultEventArgs> OnBomberComplete;
        public GeneralBomber(string baseUrl, string userKey, string passKey, string httpMethod)
        {
            this.mBaseUrl = baseUrl;
            this.mUserKey = userKey;
            this.mPassKey = passKey;
            this.mHttpMethod = httpMethod;
        }
        private string mBaseUrl, mUserKey, mPassKey, mHttpMethod;
        public virtual string BaseUrl
        {
            get
            {
                return mBaseUrl;
            }
            set
            {
                mBaseUrl = value;
            }
        }
        public virtual string HttpMethod
        {
            get
            {
                return mHttpMethod;
            }
            set
            {
                mHttpMethod = value;
            }
        }
        public virtual string PassowordKey
        {
            get
            {
                return mPassKey;
            }
            set
            {
                mPassKey = value;
            }
        }
        public virtual string UserKey
        {
            get
            {
                return mUserKey;
            }
            set
            {
                mUserKey = value;
            }
        }
        public virtual string MakeRandomQQ() {
            return BomberUtils.RandomQQNumber();
        }
        public virtual string MakeRandomPassowrd() {
            return BomberUtils.RandomPassword();
        }
        public virtual Dictionary<string, string> MakeWebform(string user, string pass) {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add(UserKey,BomberUtils.UrlEncode(user));
            dic.Add(PassowordKey, BomberUtils.UrlEncode(pass));
            return dic;
        }
        public virtual string MakeHttpKeyValue(Dictionary<string, string> dic) {
            return BomberUtils.DictionaryToHttpKeyValue(dic);
        }
        public virtual HttpWebRequest CreateRequest(string httpKeyValue) {
            return BomberUtils.MakeHttpRequest(BaseUrl, httpKeyValue, HttpMethod);
        }
        public virtual bool perform()
        {
            string user = MakeRandomQQ();
            string pass = MakeRandomPassowrd();
            Dictionary<string, string> form = MakeWebform(user,pass);
            string httpkeyvalue = MakeHttpKeyValue(form);
            string result = "";
            bool success = false;
            Exception exception = null;
            try
            {
                HttpWebRequest request = CreateRequest(httpkeyvalue);
                result = BomberUtils.GetHttpResponse(request);
                success = true;
            }
            catch (Exception ex) {
                exception = ex;
                result = ex.Message;
            }
            if (OnBomberComplete != null)
            {
                OnBomberComplete.Invoke(this, new BomberResultEventArgs(success, user, pass, BaseUrl,result, exception));
            }
            return success;
        }
    } 
    public class GeneralBomberWithAdditional : GeneralBomber
    {
        public GeneralBomberWithAdditional(string baseUrl, string userKey, string passKey, string httpMethod,params KeyValuePair<string,string>[] additionalKeyValue)
        :base(baseUrl, userKey, passKey, httpMethod)
        {
            foreach (KeyValuePair<string, string> kvs in additionalKeyValue)
            {
                AdditionalKeyValue.Add(kvs.Key, kvs.Value);
            }
        }
        private Dictionary<string, string> AdditionalKeyValue = new Dictionary<string, string>();
        public override Dictionary<string, string> MakeWebform(string user, string pass)
        {
            Dictionary<string,string> based = base.MakeWebform(user, pass);
            foreach (KeyValuePair<string, string> kvs in AdditionalKeyValue) {
                based.Add(kvs.Key, kvs.Value);
            }
            return based;
        }
    }
    public class BomberResultEventArgs : EventArgs {
        bool mBomberResult;
        string mUsesUser,mUsesPassword,mUsesUrl,mReturnValue;
        Exception mException;

        public bool BomberResult
        {
            get
            {
                return mBomberResult;
            }

            set
            {
                mBomberResult = value;
            }
        }

        public string UsesUser
        {
            get
            {
                return mUsesUser;
            }

            set
            {
                mUsesUser = value;
            }
        }

        public string UsesPassword
        {
            get
            {
                return mUsesPassword;
            }

            set
            {
                mUsesPassword = value;
            }
        }

        public string UsesUrl
        {
            get
            {
                return mUsesUrl;
            }

            set
            {
                mUsesUrl = value;
            }
        }

        public Exception Exception
        {
            get
            {
                return mException;
            }

            set
            {
                mException = value;
            }
        }

        public string ReturnValue
        {
            get
            {
                return mReturnValue;
            }

            set
            {
                mReturnValue = value;
            }
        }

        public BomberResultEventArgs(bool bomberResult,string usesUser,string usesPassword,string usesUrl,string returnValue,Exception ex) {
            this.mBomberResult = bomberResult;
            this.mUsesUser = usesUser;
            this.mUsesPassword = usesPassword;
            this.mUsesUrl = usesUrl;
            this.mReturnValue = returnValue;
            this.mException = ex;
        }


    }
}
