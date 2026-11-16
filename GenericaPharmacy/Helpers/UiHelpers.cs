namespace GenericaPharmacy;

public sealed class ComboItem
{
    public ComboItem(string text, string? value)
    {
        Text = text;
        Value = value;
    }

    public string Text { get; }
    public string? Value { get; }

    public override string ToString() => Text;
}

public interface IPage
{
    void RefreshPage();
}

internal static class UiHelpers
{
    public static void FillCombo(ComboBox combo, string allText, IEnumerable<ComboItem> items)
    {
        string? previous = SelectedValue(combo);

        combo.BeginUpdate();
        combo.Items.Clear();
        combo.Items.Add(new ComboItem(allText, null));
        foreach (ComboItem item in items)
            combo.Items.Add(item);

        int index = 0;
        if (previous != null)
        {
            for (int i = 1; i < combo.Items.Count; i++)
            {
                if (combo.Items[i] is ComboItem candidate && candidate.Value == previous)
                {
                    index = i;
                    break;
                }
            }
        }
        combo.SelectedIndex = index;
        combo.EndUpdate();
    }

    public static string? SelectedValue(ComboBox combo) => (combo.SelectedItem as ComboItem)?.Value;

    public static void SetCard(Label value, Label note, string text)
    {
        value.Text = text;

        int valueWidth = TextRenderer.MeasureText(text, value.Font).Width;
        int noteWidth = TextRenderer.MeasureText(note.Text, note.Font).Width;
        int left = value.Left + valueWidth + 6;
        int cardWidth = value.Parent?.ClientSize.Width ?? 300;

        if (left + noteWidth > cardWidth - 8)
            note.Location = new Point(value.Left + 2, value.Bottom - 2);
        else
            note.Location = new Point(left, value.Top + 15);
    }

    public static void AlignRightHeaders(DataGridView grid)
    {
        foreach (DataGridViewColumn column in grid.Columns)
        {
            if (column.DefaultCellStyle.Alignment == DataGridViewContentAlignment.MiddleRight)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                column.HeaderCell.Style.Padding = new Padding(6, 0, 14, 0);
            }
        }
    }

    private static readonly Font StatusFont = new("Segoe UI", 8.5F, FontStyle.Bold);

    public static void ColorStatusCell(DataGridViewCellFormattingEventArgs e)
    {
        if (e.CellStyle != null && e.Value is string status)
        {
            e.CellStyle.ForeColor = Theme.StatusColor(status);
            e.CellStyle.Font = StatusFont;
        }
    }

    public static DialogResult Info(IWin32Window? owner, string message, string title = "Generica Pharmacy") =>
        MessageBox.Show(owner, message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);

    public static bool Confirm(IWin32Window? owner, string message, string title = "Please confirm") =>
        MessageBox.Show(owner, message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes;
}
