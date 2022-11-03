using Microsoft.Win32.TaskScheduler;
using System.Security.Principal;
using System.Windows.Forms;

namespace PBO2_Helper
{
    public partial class Main : Form
    {
        string pboPath = "";


        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            using (TaskService ts = new TaskService())
            {
                Microsoft.Win32.TaskScheduler.Task existTask = ts.FindTask("PBO2_Tuner");
                if (existTask != null)
                {

                    foreach (var action in existTask.Definition.Actions)
                    {
                        if (action.ActionType == TaskActionType.Execute)
                        {
                            if (action is ExecAction execAct)
                            {
                                string[] args = execAct.Arguments.Split(' ');

                                if (args.Length == 8)
                                {
                                    core_1_textBox.Text = args[0];
                                    core_2_textBox.Text = args[1];
                                    core_3_textBox.Text = args[2];
                                    core_4_textBox.Text = args[3];
                                    core_5_textBox.Text = args[4];
                                    core_6_textBox.Text = args[5];
                                    core_7_textBox.Text = args[6];
                                    core_8_textBox.Text = args[7];

                                    DeleteTaskButton.Enabled = true;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void selectPboButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            DialogResult result = fileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                if(fileDialog.CheckFileExists)
                {
                    pboPath = fileDialog.FileName;
                    selectPboButton.Text = pboPath;
                    selectPboButton.Enabled = false;
                    ApplyButton.Enabled = true;
                    applyToCore1.Enabled = true;
                    core_1_textBox.Enabled = true;
                    core_2_textBox.Enabled = true;
                    core_3_textBox.Enabled = true;
                    core_4_textBox.Enabled = true;
                    core_5_textBox.Enabled = true;
                    core_6_textBox.Enabled = true;
                    core_7_textBox.Enabled = true;
                    core_8_textBox.Enabled = true;
                }
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            try
            {
                int.Parse(core_1_textBox.Text);
                int.Parse(core_2_textBox.Text);
                int.Parse(core_3_textBox.Text);
                int.Parse(core_4_textBox.Text);
                int.Parse(core_5_textBox.Text);
                int.Parse(core_6_textBox.Text);
                int.Parse(core_7_textBox.Text);
                int.Parse(core_8_textBox.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


            // Get the service on the local machine
            using (TaskService ts = new TaskService())
            {
                Microsoft.Win32.TaskScheduler.Task existTask = ts.FindTask("PBO2_Tuner");
                if (existTask != null)
                {
                    DialogResult dialogResult = MessageBox.Show("PBO2_Tuner Task is Exists. Override?", "Exists!", MessageBoxButtons.YesNo);
                    if(dialogResult.HasFlag(DialogResult.Yes) == false)
                    {
                        return;
                    }
                    ts.RootFolder.DeleteTask("PBO2_Tuner");
                }


                TaskDefinition td = ts.NewTask();

                
                

                td.Principal.LogonType = TaskLogonType.S4U;

                td.Principal.RunLevel = TaskRunLevel.Highest;
                td.Principal.UserId = "SYSTEM";
                td.Settings.Compatibility = TaskCompatibility.V2_3;
                td.Settings.StopIfGoingOnBatteries = false;
                td.Settings.DisallowStartIfOnBatteries = false;
                td.Settings.ExecutionTimeLimit = TimeSpan.FromHours(1);

                td.RegistrationInfo.Author = "vilmire";
                td.RegistrationInfo.Description = "Run PBO2_tuner - vilmire";
                td.Settings.MultipleInstances = TaskInstancesPolicy.Queue;
                //td.Settings.AllowHardTerminate = true;

                td.Triggers.Add(new BootTrigger { Enabled = true});

                td.Triggers.Add(new EventTrigger("System", "Power-Troubleshooter", 1));

                td.Actions.Add(new ExecAction(path:pboPath, arguments:$"{core_1_textBox.Text} {core_2_textBox.Text} {core_3_textBox.Text} {core_4_textBox.Text} {core_5_textBox.Text} {core_6_textBox.Text} {core_7_textBox.Text} {core_8_textBox.Text}"));

                ts.RootFolder.RegisterTaskDefinition(@"PBO2_Tuner", td);
            }
            ApplyButton.Enabled = false;
            applyToCore1.Enabled = false;
            core_1_textBox.Enabled = false;
            core_2_textBox.Enabled = false;
            core_3_textBox.Enabled = false;
            core_4_textBox.Enabled = false;
            core_5_textBox.Enabled = false;
            core_6_textBox.Enabled = false;
            core_7_textBox.Enabled = false;
            core_8_textBox.Enabled = false;
            DeleteTaskButton.Enabled = true;

            MessageBox.Show("PBO2_Tuner Scheduled! Reboot and Test!", "Done!");
        }

        private void applyToCore1_Click(object sender, EventArgs e)
        {
            core_2_textBox.Text = core_1_textBox.Text;
            core_3_textBox.Text = core_1_textBox.Text;
            core_4_textBox.Text = core_1_textBox.Text;
            core_5_textBox.Text = core_1_textBox.Text;
            core_6_textBox.Text = core_1_textBox.Text;
            core_7_textBox.Text = core_1_textBox.Text;
            core_8_textBox.Text = core_1_textBox.Text;
        }

        private void DeleteTaskButton_Click(object sender, EventArgs e)
        {
            using (TaskService ts = new TaskService())
            {
                Microsoft.Win32.TaskScheduler.Task existTask = ts.FindTask("PBO2_Tuner");
                if (existTask != null)
                {
                    DialogResult dialogResult = MessageBox.Show("PBO2_Tuner Task is Exists. Delete?", "Confirm", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    ts.RootFolder.DeleteTask("PBO2_Tuner");
                    DeleteTaskButton.Enabled = false;

                    if(pboPath != "")
                    {
                        ApplyButton.Enabled = true;
                        applyToCore1.Enabled = true;
                        core_1_textBox.Enabled = true;
                        core_2_textBox.Enabled = true;
                        core_3_textBox.Enabled = true;
                        core_4_textBox.Enabled = true;
                        core_5_textBox.Enabled = true;
                        core_6_textBox.Enabled = true;
                        core_7_textBox.Enabled = true;
                        core_8_textBox.Enabled = true;
                    }
                }
            }
        }
    }
}