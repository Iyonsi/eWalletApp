using System.Collections.Generic;

namespace eWallet.API.Models
{
    public class ExecuterReaderResult
    {
        public List<string> Fields { get; set; }
        public List<string> Values { get; set; }

        public ExecuterReaderResult()
        {
            Fields = new List<string>();
            Values = new List<string>();

        }
}
