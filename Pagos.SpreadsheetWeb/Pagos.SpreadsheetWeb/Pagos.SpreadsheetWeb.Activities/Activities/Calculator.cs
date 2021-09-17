using System;
using System.Activities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Pagos.SpreadsheetWeb.Web.Api.Objects.Calculation;
using Pagos.SpreadsheetWeb.Activities.Properties;
using SpreadsheetWeb;
using UiPath.Shared.Activities;
using UiPath.Shared.Activities.Localization;

namespace Pagos.SpreadsheetWeb.Activities
{

    [LocalizedDisplayName(nameof(Resources.Calculator_DisplayName))]
    [LocalizedDescription(nameof(Resources.Calculator_Description))]
    public class Calculator : ContinuableAsyncCodeActivity
    {
        #region Properties

        /// <summary>
        /// If set, continue executing the remaining activities even if the current activity has failed.
        /// </summary>
        [LocalizedCategory(nameof(Resources.Common_Category))]
        [LocalizedDisplayName(nameof(Resources.ContinueOnError_DisplayName))]
        [LocalizedDescription(nameof(Resources.ContinueOnError_Description))]
        public override InArgument<bool> ContinueOnError { get; set; }

        [LocalizedDisplayName(nameof(Resources.Calculator_ApiURL_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_ApiURL_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        [Browsable(false)]
        public InArgument<string> ApiURL { get; set; }

        [LocalizedDisplayName(nameof(Resources.Calculator_ApplicationKey_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_ApplicationKey_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        [Browsable(false)]
        public InArgument<string> ApplicationKey { get; set; }

        [LocalizedDisplayName(nameof(Resources.Calculator_Input_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_Input_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        [Browsable(false)]
        public InArgument<string> Input1 { get; set; }

        [LocalizedDisplayName(nameof(Resources.Calculator_Value_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_Value_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        [Browsable(false)]
        public InArgument<string> Value1 { get; set; }

        [LocalizedDisplayName(nameof(Resources.Calculator_Input_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_Input_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        [Browsable(false)]
        public InArgument<string> Input2 { get; set; }

        [LocalizedDisplayName(nameof(Resources.Calculator_Value_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_Value_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        [Browsable(false)]
        public InArgument<string> Value2 { get; set; }

        [LocalizedDisplayName(nameof(Resources.Calculator_Input_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_Input_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        [Browsable(false)]
        public InArgument<string> Input3 { get; set; }

        [LocalizedDisplayName(nameof(Resources.Calculator_Value_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_Value_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        [Browsable(false)]
        public InArgument<string> Value3 { get; set; }

        [LocalizedDisplayName(nameof(Resources.Calculator_Input_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_Input_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        [Browsable(false)]
        public InArgument<string> Input4 { get; set; }

        [LocalizedDisplayName(nameof(Resources.Calculator_Value_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_Value_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        [Browsable(false)]
        public InArgument<string> Value4 { get; set; }

        [LocalizedDisplayName(nameof(Resources.Calculator_Input_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_Input_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        [Browsable(false)]
        public InArgument<string> Input5 { get; set; }

        [LocalizedDisplayName(nameof(Resources.Calculator_Value_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_Value_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        [Browsable(false)]
        public InArgument<string> Value5 { get; set; }


        [LocalizedDisplayName(nameof(Resources.Calculator_Input_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_Input_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        [Browsable(false)]
        public InArgument<string> Input6 { get; set; }

        [LocalizedDisplayName(nameof(Resources.Calculator_Value_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_Value_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        [Browsable(false)]
        public InArgument<string> Value6 { get; set; }



        [LocalizedDisplayName(nameof(Resources.Calculator_Input_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_Input_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        [Browsable(false)]
        public InArgument<string> Input7 { get; set; }

        [LocalizedDisplayName(nameof(Resources.Calculator_Value_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_Value_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        [Browsable(false)]
        public InArgument<string> Value7 { get; set; }

        [LocalizedDisplayName(nameof(Resources.Calculator_Input_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_Input_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        [Browsable(false)]
        public InArgument<string> Input8 { get; set; }

        [LocalizedDisplayName(nameof(Resources.Calculator_Value_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_Value_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        [Browsable(false)]
        public InArgument<string> Value8 { get; set; }


        [LocalizedDisplayName(nameof(Resources.Calculator_Input_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_Input_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        [Browsable(false)]
        public InArgument<string> Input9 { get; set; }

        [LocalizedDisplayName(nameof(Resources.Calculator_Value_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_Value_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        [Browsable(false)]
        public InArgument<string> Value9 { get; set; }

        [LocalizedDisplayName(nameof(Resources.Calculator_Input_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_Input_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        [Browsable(false)]
        public InArgument<string> Input10 { get; set; }

        [LocalizedDisplayName(nameof(Resources.Calculator_Value_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_Value_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        [Browsable(false)]
        public InArgument<string> Value10 { get; set; }













        [LocalizedDisplayName(nameof(Resources.Calculator_Output_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_Output_Description))]
        [LocalizedCategory(nameof(Resources.Output_Category))]
        [Browsable(false)]
        public InArgument<string> Output1 { get; set; }

        [LocalizedDisplayName(nameof(Resources.Calculator_OutputVal1_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_OutputVal1_Description))]
        [LocalizedCategory(nameof(Resources.Output_Category))]
        public OutArgument<string> OutputVal1 { get; set; }


        [LocalizedDisplayName(nameof(Resources.Calculator_Output_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_Output_Description))]
        [LocalizedCategory(nameof(Resources.Output_Category))]
        [Browsable(false)]
        public InArgument<string> Output2 { get; set; }

        [LocalizedDisplayName(nameof(Resources.Calculator_OutputVal2_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_OutputVal2_Description))]
        [LocalizedCategory(nameof(Resources.Output_Category))]
        public OutArgument<string> OutputVal2 { get; set; }

        [LocalizedDisplayName(nameof(Resources.Calculator_Output_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_Output_Description))]
        [LocalizedCategory(nameof(Resources.Output_Category))]
        [Browsable(false)]
        public InArgument<string> Output3 { get; set; }

        [LocalizedDisplayName(nameof(Resources.Calculator_OutputVal3_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_OutputVal3_Description))]
        [LocalizedCategory(nameof(Resources.Output_Category))]
        public OutArgument<string> OutputVal3 { get; set; }

        [LocalizedDisplayName(nameof(Resources.Calculator_Output_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_Output_Description))]
        [LocalizedCategory(nameof(Resources.Output_Category))]
        [Browsable(false)]
        public InArgument<string> Output4 { get; set; }

        [LocalizedDisplayName(nameof(Resources.Calculator_OutputVal4_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_OutputVal4_Description))]
        [LocalizedCategory(nameof(Resources.Output_Category))]
        public OutArgument<string> OutputVal4 { get; set; }

        [LocalizedDisplayName(nameof(Resources.Calculator_Output_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_Output_Description))]
        [LocalizedCategory(nameof(Resources.Output_Category))]
        [Browsable(false)]
        public InArgument<string> Output5 { get; set; }

        [LocalizedDisplayName(nameof(Resources.Calculator_OutputVal5_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_OutputVal5_Description))]
        [LocalizedCategory(nameof(Resources.Output_Category))]
        public OutArgument<string> OutputVal5 { get; set; }
















        [LocalizedDisplayName(nameof(Resources.Calculator_Output_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_Output_Description))]
        [LocalizedCategory(nameof(Resources.Output_Category))]
        [Browsable(false)]
        public InArgument<string> Output6 { get; set; }

        [LocalizedDisplayName(nameof(Resources.Calculator_OutputVal6_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_OutputVal6_Description))]
        [LocalizedCategory(nameof(Resources.Output_Category))]
        public OutArgument<string> OutputVal6 { get; set; }

        [LocalizedDisplayName(nameof(Resources.Calculator_Output_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_Output_Description))]
        [LocalizedCategory(nameof(Resources.Output_Category))]
        [Browsable(false)]
        public InArgument<string> Output7 { get; set; }

        [LocalizedDisplayName(nameof(Resources.Calculator_OutputVal7_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_OutputVal7_Description))]
        [LocalizedCategory(nameof(Resources.Output_Category))]
        public OutArgument<string> OutputVal7 { get; set; }

        [LocalizedDisplayName(nameof(Resources.Calculator_Output_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_Output_Description))]
        [LocalizedCategory(nameof(Resources.Output_Category))]
        [Browsable(false)]
        public InArgument<string> Output8 { get; set; }

        [LocalizedDisplayName(nameof(Resources.Calculator_OutputVal8_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_OutputVal8_Description))]
        [LocalizedCategory(nameof(Resources.Output_Category))]
        public OutArgument<string> OutputVal8 { get; set; }

        [LocalizedDisplayName(nameof(Resources.Calculator_Output_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_Output_Description))]
        [LocalizedCategory(nameof(Resources.Output_Category))]
        [Browsable(false)]
        public InArgument<string> Output9 { get; set; }

        [LocalizedDisplayName(nameof(Resources.Calculator_OutputVal9_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_OutputVal9_Description))]
        [LocalizedCategory(nameof(Resources.Output_Category))]
        public OutArgument<string> OutputVal9 { get; set; }


        [LocalizedDisplayName(nameof(Resources.Calculator_Output_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_Output_Description))]
        [LocalizedCategory(nameof(Resources.Output_Category))]
        [Browsable(false)]
        public InArgument<string> Output10 { get; set; }

        [LocalizedDisplayName(nameof(Resources.Calculator_OutputVal10_DisplayName))]
        [LocalizedDescription(nameof(Resources.Calculator_OutputVal10_Description))]
        [LocalizedCategory(nameof(Resources.Output_Category))]
        public OutArgument<string> OutputVal10 { get; set; }

        #endregion

        #region Constructors

        public Calculator()
        {
        }

        #endregion

        #region Protected Methods

        protected override void CacheMetadata(CodeActivityMetadata metadata)
        {
            if (ApiURL == null) metadata.AddValidationError(string.Format(Resources.ValidationValue_Error, nameof(ApiURL)));
            if (ApplicationKey == null) metadata.AddValidationError(string.Format(Resources.ValidationValue_Error, nameof(ApplicationKey)));
            if (Input1==null 
                && Input2==null
                && Input3 == null
                && Input4 == null
                && Input5 == null
                && Input6 == null
                && Input7 == null
                && Input8 == null
                && Input9 == null
                && Input10 == null
                )
                metadata.AddValidationError("You must define at least 1 input.");

            if (Output1 == null
                && Output2 == null
                && Output3 == null
                && Output4 == null
                && Output5 == null
                && Output6 == null
                && Output7 == null
                && Output8 == null
                && Output9 == null
                && Output10 == null
            )
                metadata.AddValidationError("You must define at least 1 output.");

            base.CacheMetadata(metadata);
        }

        protected override async Task<Action<AsyncCodeActivityContext>> ExecuteAsync(AsyncCodeActivityContext context, CancellationToken cancellationToken)
        {
            // Inputs
            var apiUrl = ApiURL.Get(context);
            var applicationKey = ApplicationKey.Get(context);
            List<string> inputNamedRanges = new List<string>()
            {
                Input1.Get(context),
                Input2.Get(context),
                Input3.Get(context),
                Input4.Get(context),
                Input5.Get(context),
                Input6.Get(context),
                Input7.Get(context),
                Input8.Get(context),
                Input9.Get(context),
                Input10.Get(context)
            };

            List<string> inputNamedValues = new List<string>()
            {
                Value1.Get(context),
                Value2.Get(context),
                Value3.Get(context),
                Value4.Get(context),
                Value5.Get(context),
                Value6.Get(context),
                Value7.Get(context),
                Value8.Get(context),
                Value9.Get(context),
                Value10.Get(context)
            };

            List<string> outputNamedRanges = new List<string>()
            {
                Output1.Get(context),
                Output2.Get(context),
                Output3.Get(context),
                Output4.Get(context),
                Output5.Get(context),
                Output6.Get(context),
                Output7.Get(context),
                Output8.Get(context),
                Output9.Get(context),
                Output10.Get(context)
            };

            List<OutArgument<string>> outputs = new List<OutArgument<string>>()
            {
                OutputVal1,
                OutputVal2,
                OutputVal3,
                OutputVal4,
                OutputVal5,
                OutputVal6,
                OutputVal7,
                OutputVal8,  
                OutputVal9,
                OutputVal10
            };

            
            var api = new SpreadsheetWebApiAdaptor(apiUrl);
            var req = new CalculationRequest
            {
                ApplicationKey = applicationKey,
                Inputs = new List<RangeReference>(),
                Outputs = new List<string>()
            };
            for (var n = 0; n < inputNamedRanges.Count; n++)
            {
                var namedRange = inputNamedRanges[n];
                if (!string.IsNullOrEmpty(namedRange))
                {
                    
                    var exists = req.Inputs.Any(x => x.Ref == namedRange.Trim());
                    if (!exists)
                    {
                        req.Inputs.Add(new RangeReference()
                        {
                            Ref = namedRange.Trim(), Value = new[] { new[] { new CellValue { Value = inputNamedValues[n] } } }
                        });
                    }
                }
            }

            foreach (var namedRange in outputNamedRanges)
            {
                if (!string.IsNullOrEmpty(namedRange))
                {
                    var range = namedRange;
                    var exists = req.Outputs.Any(x => x == range.Trim());
                    if (!exists)
                    {
                        req.Outputs.Add(namedRange.Trim());
                    }
                }
            }
            
            CalculationResponse resp = api.Calculate(req);
            return (ctx) =>
            {
                if (resp.Success)
                {
                    RangeReference namedRange = null;
                    for (int n = 0; n < outputNamedRanges.Count; n++)
                    {
                        if (!string.IsNullOrEmpty(outputNamedRanges[n]))
                        {
                            namedRange = resp.Outputs.FirstOrDefault(x => x.Ref == outputNamedRanges[n]);
                            if (namedRange != null)
                            {
                                if (namedRange.Value != null && namedRange.Value.Length>0)
                                {
                                    if (namedRange.Value[0] != null && namedRange.Value[0].Length>0)
                                    {
                                        if (namedRange.Value[0][0] != null)
                                            outputs[n].Set(ctx, namedRange.Value[0][0].Value);
                                    }
                                }
                                
                            }
                        }
                    }
                    
                }
                
            };
        }

        #endregion
    }
}

