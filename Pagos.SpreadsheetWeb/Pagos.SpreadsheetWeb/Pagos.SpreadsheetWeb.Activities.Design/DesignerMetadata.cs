using System.Activities.Presentation.Metadata;
using System.ComponentModel;
using System.ComponentModel.Design;
using Pagos.SpreadsheetWeb.Activities.Design.Designers;
using Pagos.SpreadsheetWeb.Activities.Design.Properties;

namespace Pagos.SpreadsheetWeb.Activities.Design
{
    public class DesignerMetadata : IRegisterMetadata
    {
        public void Register()
        {
            var builder = new AttributeTableBuilder();
            builder.ValidateTable();

            var categoryAttribute = new CategoryAttribute($"{Resources.Category}");

            builder.AddCustomAttributes(typeof(Calculator), categoryAttribute);
            builder.AddCustomAttributes(typeof(Calculator), new DesignerAttribute(typeof(CalculatorDesigner)));
            builder.AddCustomAttributes(typeof(Calculator), new HelpKeywordAttribute(""));


            MetadataStore.AddAttributeTable(builder.CreateTable());
        }
    }
}
