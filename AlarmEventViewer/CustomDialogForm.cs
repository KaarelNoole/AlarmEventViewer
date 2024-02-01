using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoOS.Platform.Data;
using VideoOS.Platform.Proxy.AlarmClient;
using VideoOS.Platform;
using VideoOS.Platform.UI.Controls;

namespace AlarmEventViewer
{
    public class CustomDialogForm : Form
    {
        private TextBox textBox;
        private Button closeButton;
        private Button addButton;
        DataGridViewRow _selectedRow = null;
        private AlarmClientManager _alarmClientManager;

        public CustomDialogForm()
        {
            textBox = new TextBox();
            closeButton = new Button();
            addButton = new Button();


            textBox.Location = new System.Drawing.Point(10, 10);
            textBox.Size = new System.Drawing.Size(250, 20);


            addButton.Text = "Add";
            addButton.Location = new System.Drawing.Point(10, 40);
            addButton.Click += AddButton_Click;

            closeButton.Text = "Close";
            closeButton.Location = new System.Drawing.Point(90, 40);
            closeButton.Click += CloseButton_Click;


            Controls.Add(textBox);
            Controls.Add(addButton);
            Controls.Add(closeButton);

            Text = "Custom Dialog Box";
            Size = new System.Drawing.Size(300, 120);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(Object sender, EventArgs e)
        {
            // Get the content of the textBox
            string milestoneText = textBox.Text;

            // Check if the milestone text is not empty
            if (!string.IsNullOrWhiteSpace(milestoneText))
            {
                if (_selectedRow != null)
                {
                    Alarm alarm = _selectedRow.Tag as Alarm;
                    if (alarm != null)
                    {
                        try
                        {
                            IAlarmClient alarmClient = LookupAlarmClient(alarm.EventHeader.Source.FQID);
                            alarmClient.UpdateAlarm(alarm.EventHeader.ID, $"Operator changed alarm tag to '{ milestoneText}'", 4, 1, DateTime.UtcNow, "");
                        }
                        catch (Exception ex)
                        {
                            EnvironmentManager.Instance.ExceptionDialog("MessageHandler", ex);
                        }
                    }
                }
                // Display an alert (for example, MessageBox) - Replace with your actual alarm logic
                MessageBox.Show($"Milestone '{milestoneText}' added to Xproject Smart Client!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Clear the textBox for the next entry
                textBox.Clear();
                Close();
            }
            else
            {
                // Display an error message if the milestone text is empty
                MessageBox.Show("Please enter a text.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private IAlarmClient LookupAlarmClient(FQID fqid)
        {
            return _alarmClientManager.GetAlarmClient(fqid.ServerId);
        }
    }
}
