public static class DataGridViewViewer
{
    public static void ConfigureAsReadOnlyViewer(DataGridView grid, object dataSource)
    {
        // --- Binding ---
        grid.DataSource = null;
        grid.AutoGenerateColumns = true;
        grid.DataSource = dataSource;

        // --- Lecture seule totale ---
        grid.ReadOnly = true;
        grid.EditMode = DataGridViewEditMode.EditProgrammatically;

        // --- Suppression de toute interaction inutile ---
        grid.AllowUserToAddRows = false;
        grid.AllowUserToDeleteRows = false;
        grid.AllowUserToResizeRows = false;
        grid.AllowUserToResizeColumns = false;
        grid.MultiSelect = false;

        // --- Sélection propre ---
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        // --- En-têtes ---
        grid.RowHeadersVisible = true;
        grid.ColumnHeadersVisible = true;

        // --- Scrollbars natives ---
        grid.ScrollBars = ScrollBars.Both;

        // --- Rendu ---
        grid.BorderStyle = BorderStyle.FixedSingle;
        grid.BackgroundColor = SystemColors.Window;
        grid.EnableHeadersVisualStyles = false;

        // --- Colonnes ---
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

        // --- Numérotation des lignes ---
        grid.RowPostPaint -= DrawRowNumber;
        grid.RowPostPaint += DrawRowNumber;

        // --- Empêche toute tentative d’édition ---
        grid.CellBeginEdit += (_, e) => e.Cancel = true;

        // --- Final ---
        grid.ClearSelection();
    }

    private static void DrawRowNumber(object sender, DataGridViewRowPostPaintEventArgs e)
    {
        var grid = sender as DataGridView;
        if (grid == null) return;

        var rowNumber = (e.RowIndex + 1).ToString();

        var centerFormat = new StringFormat
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center
        };

        var headerBounds = new Rectangle(
            e.RowBounds.Left,
            e.RowBounds.Top,
            grid.RowHeadersWidth,
            e.RowBounds.Height);

        e.Graphics.DrawString(
            rowNumber,
            grid.Font,
            SystemBrushes.ControlText,
            headerBounds,
            centerFormat);
    }
}
