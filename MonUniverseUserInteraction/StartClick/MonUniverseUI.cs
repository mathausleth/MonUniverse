using MonUniverse.Enums;
using MonUniverse.MonUniverseRessources;
using System.Diagnostics;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace MonUniverse.MonUniverseUI
{
    public partial class MonUniverseUI
    {

        private Enums.RunStates state = Enums.RunStates.STOPPED;

        private async void StartButtonClick(object? sender, EventArgs e)
        {
            if (state == RunStates.STOPPED) OnStart();
            else if (state == RunStates.RUNNING) await OnStop();
            else startButton.Enabled = false;
        }
        private void OnStart()
        {
            startButton.Text = "STARTING";
            startButton.Enabled = false;
            state = RunStates.STARTING;
            UpdateStatusBar();
            Task.Run(async () =>
            {
                await Task.Delay(2000);
                state = RunStates.RUNNING;
                Invoke(() =>
                {
                    startButton.Text = "STOP";
                    startButton.Enabled = true;
                    UpdateStatusBar();
                });
                try
                {
                    await ServiceGenerique.Service.StartAsync();
                }
                catch (Exception)
                {

                }
                finally
                {

                }
            });
        }
        private async Task OnStop()
        {
            startButton.Text = "STOPPING";
            startButton.Enabled = false;
            state = RunStates.STOPPING;
            UpdateStatusBar();
            try
            {
                await ServiceGenerique.Service.StopAsync();
                state = RunStates.STOPPED;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error STOP");
                state = RunStates.RUNNING;
            }
            finally
            {
                UpdateStatusBar();
                startButton.Text = "START";
                startButton.Enabled = true;
            }
        }
        private void UpdateStatusBar()
        {
            Color color = Color.White;
            switch (state)
            {
                case RunStates.STOPPED:
                    color = Settings.STOPPED;
                    break;
                case RunStates.STARTING:
                    color = Settings.STARTING;
                    break;
                case RunStates.RUNNING:
                    color = Settings.RUNNING;
                    break;
                case RunStates.STOPPING:
                    color = Settings.STOPPING;
                    break;
                default:
                    break;
            }
            statusText.Text = $"{state.ToString().ToUpper()}";
            statusPanels[StatusControls.TOPLINE].BackColor = color;
            statusPanels[StatusControls.BOTLINE].BackColor = color;
            statusPanels[StatusControls.ICON].ForeColor = color;
            statusPanels[StatusControls.TEXT].ForeColor = color;
            statusPanels[StatusControls.SEPARATOR].ForeColor = color;
            foreach (var item in mainStateArrows)
            {
                item.ForeColor = color;
            }
        }
    }
}