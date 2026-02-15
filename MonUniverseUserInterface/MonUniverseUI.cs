using MonUniverse.MonUniverseRessources;
using System.Diagnostics;

namespace MonUniverse.MonUniverseUI
{
    public partial class MonUniverseUI : Form
    {
        #region SELECTABLE CONTROLS
        private readonly Button clearNotificationButton;
        private readonly Button corellationButton;
        private readonly Button showTrustedDb;
        private readonly Button showViewDb;
        private readonly Button startButton;
        private readonly Label notificationsCounter;
        private readonly Label notRunningArrow;
        private readonly Label notRunningText;
        private readonly Label statusText;
        #endregion

        #region SELECTABLE COLLECTIONS
        private readonly Dictionary<ServiceGenerique.State, Label> mainStateTexts = [];
        private readonly Dictionary<MonUniverseService.State, Label> runStateArrows = [];
        private readonly Dictionary<MonUniverseService.State, Label> runStateStatus = [];
        private readonly Dictionary<MonUniverseService.State, Label> runStateTexts = [];
        private readonly Dictionary<Enums.StatusControls, Panel> statusPanels = [];
        private readonly Dictionary<Enums.ListingButtons, Button> showListButtons = [];
        private Label[] mainStateArrows;
        #endregion

        private MonUniverseUI()
        {
            if (_instance == null)
            {
                _instance = this;
                this.Text = "MonUniverse - Windows 11 PC Requests Monitor";
                this.Size = new Size(796, 559);
                this.BackColor = Settings.IVORY;
                this.FormBorderStyle = FormBorderStyle.FixedDialog;
                this.Padding = Settings.NOPADDING;
                this.MaximizeBox = false;
                //
                this.clearNotificationButton = CreateClearNotificationButton();
                this.corellationButton = CreateCorellationButton();
                this.showTrustedDb = CreateImageButton();
                this.showViewDb = CreateImageButton();
                this.startButton = CreateStartButton();
                this.notificationsCounter = CreateNoficationCounter();
                this.notRunningArrow = CreateNotRunningArrow();
                this.notRunningText = CreateNotRunningText();
                this.statusText = CreateStatusText();
                //
                CreateMainStateLabels();
                CreateRunStateControls();
                CreateStatusPanel();
                CreateShowTextButtons();
                //
                FirstCut();
            }
        }
    }
}