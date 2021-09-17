using System;
using System.Windows;

namespace Pagos.SpreadsheetWeb.Activities.Design.Designers
{

    public partial class CalculatorDesigner
    {
        int currentInputRowIndex = 0;
        int currentOutputRowIndex = 0;
        private const int MAX_VISIBLE_INPUT_ROWS = 10;
        private const int MAX_VISIBLE_OUTPUT_ROWS = 10;


        public CalculatorDesigner()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if ((currentInputRowIndex + 1) < MAX_VISIBLE_INPUT_ROWS)
            {
                currentInputRowIndex++;
                grdInputs.RowDefinitions[currentInputRowIndex].Height = GridLength.Auto;
            }
            
        }
        private void BtnRemove_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                
                System.Windows.Controls.Button b = (System.Windows.Controls.Button)sender;
                int index = Convert.ToInt32(b.Tag.ToString());
                for (var n = (index + 1); n <= MAX_VISIBLE_INPUT_ROWS; n++)
                {
                    ModelItem.Properties[$"Input{n - 1}"].SetValue(ModelItem.Properties[$"Input{n}"].Value);
                    ModelItem.Properties[$"Value{n - 1}"].SetValue(ModelItem.Properties[$"Value{n}"].Value);
                }

                ModelItem.Properties[$"Input10"].ClearValue();
                ModelItem.Properties[$"Value10"].ClearValue();
                if (currentInputRowIndex > 0)
                {
                    grdInputs.RowDefinitions[currentInputRowIndex].Height = new GridLength(0);
                    currentInputRowIndex--;
                }
            }
            catch
            {
            }
            

        }

        private void BtnRemoveOutput_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {

                System.Windows.Controls.Button b = (System.Windows.Controls.Button)sender;

                int index = Convert.ToInt32(b.Tag.ToString());
                for (var n=(index+1);n <= MAX_VISIBLE_OUTPUT_ROWS;n++)
                {
                    ModelItem.Properties[$"Output{n - 1}"].SetValue(ModelItem.Properties[$"Output{n}"].Value);
                }

                ModelItem.Properties[$"Output10"].ClearValue();
                if (currentOutputRowIndex > 0)
                {
                    grdOutputs.RowDefinitions[currentOutputRowIndex].Height = new GridLength(0);
                    currentOutputRowIndex--;
                }

            }
            catch
            {
            }
        }

        private void btnAddOutput_Click(object sender, RoutedEventArgs e)
        {
            if ((currentOutputRowIndex + 1) < MAX_VISIBLE_OUTPUT_ROWS)
            {
                currentOutputRowIndex++;
                grdOutputs.RowDefinitions[currentOutputRowIndex].Height = GridLength.Auto;
            }
        }

        private void FrameworkElement_OnLoaded(object sender, RoutedEventArgs e)
        {
            for (var n = 2; n <= MAX_VISIBLE_INPUT_ROWS; n++)
            {
                try
                {
                    var val = ModelItem.Properties[$"Input{n}"].ComputedValue.ToString();
                    if (!string.IsNullOrEmpty(val))
                    {
                        currentInputRowIndex++;
                        grdInputs.RowDefinitions[currentInputRowIndex].Height = GridLength.Auto;
                    }
                }
                catch
                {
                }
            }

            for (var n = 2; n <= MAX_VISIBLE_OUTPUT_ROWS; n++)
            {
                try
                {

                    var val = ModelItem.Properties[$"Output{n}"].ComputedValue.ToString();
                    if (!string.IsNullOrEmpty(val))
                    {
                        currentOutputRowIndex++;
                        grdOutputs.RowDefinitions[currentOutputRowIndex].Height = GridLength.Auto;
                    }
                }
                catch 
                {
                }
            }
        }
    }
}
