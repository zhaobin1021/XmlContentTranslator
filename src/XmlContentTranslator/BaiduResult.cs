using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlContentTranslator
{
    public class BaiduResult
    {
        //{"from":"en","to":"zh","trans_result":[{"src":"en","dst":"en"}]}
        private string from;
        private string to;
        private List<TransResult> trans_result;

        public string From { get => from; set => from = value; }
        public string To { get => to; set => to = value; }
        public List<TransResult> Trans_result { get => trans_result; set => trans_result = value; }
    }

    public class TransResult
    {
        private string src;
        private string dst;

        public string Src { get => src; set => src = value; }
        public string Dst { get => dst; set => dst = value; }
    }
}
