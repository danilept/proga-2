using System.Drawing;
using System.Windows.Forms;

public static class ThemeManager
{
    public static bool IsDarkTheme { get; set; }
    public static void ApplyTheme(Form form)
    {
        if (IsDarkTheme)
        {
            form.BackColor = Color.Black;
            form.ForeColor = Color.White;
        }
        else
        {
            form.BackColor = Color.White;
            form.ForeColor = Color.Black;
        }
    }

    public static void ApplyThemeToAllForms()
    {
        foreach (Form form in Application.OpenForms)
        {
            ApplyTheme(form);
        }
    }
}
