using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTPTCSClient.Model
{
    public class MyMessage
    {
        public enum Status
        {
            SUCCESS,
            FAIL
        }

        public MyMessage() : base()
        {
        }

        public MyMessage(string content)
        {
            MStatus = Status.SUCCESS;
            Content = content;
        }

        public Status MStatus { get; set; }
        public string Content { get; set; }
    }
}
