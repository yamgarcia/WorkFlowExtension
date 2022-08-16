using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Activities;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;

namespace WorkFlowExtension
{
    public class IncrementByTen : CodeActivity
    {

        [RequiredArgument]
        [Input("Decimal input")]
        public InArgument<decimal> DecInput { get; set; }

        [Output("Decimal output")]
        public OutArgument<decimal> DecOutput { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            decimal input = DecInput.Get(context);
            DecOutput.Set(context, input + 10);
        }

    }
}
