namespace AutoBuySJC
{
    public class Result
    {
        public class Root
        {
            public int StatusCode { get; set; }
            public string StatusText { get; set; }
            public object StatusDescription { get; set; }
            public object ResponseData { get; set; }
            public int DataLength { get; set; }
        }
    }
}
