using MonUniverse.MonUniverseRessources;
using System.Diagnostics;

namespace MonUniverse.MonUniverseUI
{
    public partial class MonUniverseUI
    {

        private static void SelectMainStateLabel(ServiceGenerique.State state)
        {

            Instance.Invoke(() =>
            {
                Label selectedLabel = Instance.mainStateTexts[state];
                if (state == ServiceGenerique.State.STOP) selectedLabel.ForeColor = Settings.STOPPED;
                else selectedLabel.ForeColor = Settings.RUNNING;
                selectedLabel.Font = Settings.FONT13LINE;
            });
        }
        private static void UnelectMainStateLabel(ServiceGenerique.State state)
        {
            Instance.Invoke(() =>
            {
                Label selectedLabel = Instance.mainStateTexts[state];
                selectedLabel.ForeColor = Settings.BLUE;
                selectedLabel.Font = Settings.FONT13;
            });
        }
        public static void foo()
        {

            MonUniverseUI i = MonUniverseUI.Instance;
            Debug.Write("??????? 22 ");
            ServiceGenerique.Service.SetEnterAction(ServiceGenerique.State.INIT, () =>
            {
                SelectMainStateLabel(ServiceGenerique.State.INIT);
            });

            ServiceGenerique.Service.SetEnterAction(ServiceGenerique.State.CHECK, () =>
            {
                SelectMainStateLabel(ServiceGenerique.State.CHECK);
            });

            ServiceGenerique.Service.SetEnterAction(ServiceGenerique.State.RUN, () =>
            {
                SelectMainStateLabel(ServiceGenerique.State.RUN);
            });

            ServiceGenerique.Service.SetEnterAction(ServiceGenerique.State.CLEAN, () =>
            {
                SelectMainStateLabel(ServiceGenerique.State.CLEAN);
            });

            ServiceGenerique.Service.SetEnterAction(ServiceGenerique.State.RESET, () =>
            {
                SelectMainStateLabel(ServiceGenerique.State.RESET);
            });

            ServiceGenerique.Service.SetEnterAction(ServiceGenerique.State.STOP, () =>
            {
                SelectMainStateLabel(ServiceGenerique.State.STOP);
            });
            //

            ServiceGenerique.Service.SetExitAction(ServiceGenerique.State.INIT, () =>
            {
                UnelectMainStateLabel(ServiceGenerique.State.INIT);
            });

            ServiceGenerique.Service.SetExitAction(ServiceGenerique.State.CHECK, () =>
            {
                UnelectMainStateLabel(ServiceGenerique.State.CHECK);
            });

            ServiceGenerique.Service.SetExitAction(ServiceGenerique.State.RUN, () =>
            {
                UnelectMainStateLabel(ServiceGenerique.State.RUN);
            });

            ServiceGenerique.Service.SetExitAction(ServiceGenerique.State.CLEAN, () =>
            {
                UnelectMainStateLabel(ServiceGenerique.State.CLEAN);
            });

            ServiceGenerique.Service.SetExitAction(ServiceGenerique.State.RESET, () =>
            {
                UnelectMainStateLabel(ServiceGenerique.State.RESET);
            });

            ServiceGenerique.Service.SetExitAction(ServiceGenerique.State.STOP, () =>
            {
                UnelectMainStateLabel(ServiceGenerique.State.STOP);
            });
        }

    }
}